﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using InventoryApp.Processors;
using InventoryApp.API_Model;
using System.IO;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Web;
using System.Collections;
using System.Security.Cryptography;
using System.Drawing;


namespace InventoryApp.Helpers
{

    class SQLHelper
    {
        //change this to your server name and the path for the image folder
        public static readonly String connectionString = Global.connectionString;
        public static readonly String path = Global.path;



        //-------------------------------------------------------------------Basic Functionality-------------------------------------------------------
        /*
         This function only execute the sql query, it does not read the result from SELECT query
        */
        public void Execute(string Query)
        {
            //setting up connection with DB
            SqlConnection myConnection = new SqlConnection(connectionString);
            SqlCommand myCommand; //passing query command here
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand(Query, myConnection); //preparing the query string
                myCommand.ExecuteNonQuery();    //execute query
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myConnection.Close(); //close connection
            }
        }

        /*
         This function will return the result of a query 
        */
        public DataTable Select(string query)
        {
            SqlCommand myCommand;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                try
                {
                    myConnection.Open();
                    myCommand = new SqlCommand(query, myConnection); //preparing the query string
                    myCommand = new SqlCommand(query, myConnection);
                    adapter = new SqlDataAdapter(query, myConnection);
                    adapter.Fill(dt);
                    myConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dt = null;
                }
                finally {myConnection.Close(); }
            }
            return dt;
        }

        public int LoadCatalog(DataTable catalog, string uid, int scrollVal, string filters) /*Paging the result, passing in scroll value to indicate the start point*/
        {
            SqlCommand myCommand;
            int total;
            int end = 0;
            string num = String.Format("SELECT COUNT(user_id) as num from YGOStorePrice where user_id = '{0}'", uid);
            string query = "select CM.image, S.card_id, CM.card_name, S.set_code, CM.set_name, S.rarity,  CM.market_price, S.store_price, S.copies from YGOStorePrice as S inner join YGOCardsInfo as ci on s.card_id = ci.card_id inner join" +
                "(Select Y.image, Y.card_id, Y.set_code, Y.rarity, Y.card_name, Y.card_type, Y.card_race, Y.set_name, ROUND(Y.market_price / C.rate, 2) as market_price " +
                "from YGOCurrentMarket as Y, dbo.ConversionRate as C\r\nwhere C.update_date = ((select MAX(update_date) from dbo.ConversionRate))) as CM " +
                "on S.card_id = CM.card_id and S.set_code = CM.set_code and S.rarity = CM.rarity where S.user_id = @UID";
            if (filters !=  null) { query += " and " + filters + " "; }
            query += " ORDER BY card_name";
            
            SqlDataAdapter pagingAdapter;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myConnection.Open();
                myCommand = new SqlCommand(num, myConnection);
                total = (int)myCommand.ExecuteScalar();
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@UID", SqlDbType.VarChar, 64).Value = uid;
                pagingAdapter = new SqlDataAdapter(myCommand);
                //Check if end of database is reached
                if (scrollVal > 0 && scrollVal + 20 > total) 
                {
                    pagingAdapter.Fill(scrollVal, scrollVal + 20 - total, catalog);
                    end = 1;
                }
                else
                {
                    pagingAdapter.Fill(scrollVal, 20, catalog);
                }
                myConnection.Close();
            }
            return end;
        }

        public void search_autoFill(string search, string uid)
        {
            SqlCommand myCommand;
            string query = "select CM.image, S.card_id, CM.card_name, S.set_code, CM.set_name, S.rarity,  CM.market_price, S.store_price, S.copies from YGOStorePrice as S inner join YGOCurrentMarket as CM on S.card_id = " +
               $"CM.card_id and S.set_code = CM.set_code and S.rarity = CM.rarity where S.user_id = '{uid}' and CM.card_name like ?";
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.AddWithValue("CM.card_name", search + "%");
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------Card Related-------------------------------------------------------------
        public int InsertCard(string uid, string cid, string set_code, string cname, string ctype, string crace, string set_name, string rarity, string m_price, string copies, string image, string s_price) //return status code 
        {
            SqlCommand myCommand;
            SqlDataReader myReader;
            int status;
            cname = cname.Replace("'", "''");
            set_name = set_name.Replace("'", "''");
            String image_file = cid + ".jpg";
            String query = "Execute AddCard @UID, @CID, @Set_Code, @Rarity, @Game, @C_name, @C_type, @C_race, @Set_name, @M_price, @S_price, @Copies, @image, @Status output";
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@UID", SqlDbType.VarChar, 64).Value = uid; 
                myCommand.Parameters.Add("@CID", SqlDbType.Int).Value = cid;
                myCommand.Parameters.Add("@Set_Code", SqlDbType.VarChar, 50).Value = set_code;
                myCommand.Parameters.Add("@Rarity", SqlDbType.VarChar, 20).Value = rarity;
                myCommand.Parameters.Add("@Game", SqlDbType.VarChar, 20).Value = "YGO";
                myCommand.Parameters.Add("@C_name", SqlDbType.VarChar, -1).Value = cname;
                myCommand.Parameters.Add("@C_type", SqlDbType.VarChar, -1).Value = ctype;
                myCommand.Parameters.Add("@C_race", SqlDbType.VarChar, -1).Value = crace;
                myCommand.Parameters.Add("@Set_name", SqlDbType.VarChar, -1).Value = set_name;
                myCommand.Parameters.Add("@M_price", SqlDbType.Money).Value = m_price;
                myCommand.Parameters.Add("@S_price", SqlDbType.Money).Value = s_price;
                myCommand.Parameters.Add("@Copies", SqlDbType.Int).Value = copies;
                myCommand.Parameters.Add("@Image", SqlDbType.VarChar, -1).Value = image_file;
                myCommand.Parameters.Add("@Status", SqlDbType.Int).Direction = ParameterDirection.Output;
                try
                {
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    status = (int)myCommand.Parameters["@Status"].Value;
                    SaveImage(image, cid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    status = -1; //db connection error
                }
                finally 
                { 
                     myConnection.Close(); 
                }
            }
            return status;
        }

        public int DeleteCard(string uid, string cid, string setcode, string rarity)
        {
            SqlCommand myCommand;
            SqlDataReader myReader;
            int status;
            String query = "Exec deleteCard @UID, @CID, @Setcode, @Rarity, @stat output";
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                /* This way will prevent sql injection attack*/
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@UID", SqlDbType.VarChar, 64).Value = uid;
                myCommand.Parameters.Add("@CID", SqlDbType.Int).Value = cid;
                myCommand.Parameters.Add("@Setcode", SqlDbType.VarChar, 20).Value = setcode;
                myCommand.Parameters.Add("@Rarity", SqlDbType.VarChar, 20).Value = rarity;
                myCommand.Parameters.Add("@stat", SqlDbType.Int).Direction = ParameterDirection.Output;
                try
                {
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    status = (int)myCommand.Parameters["@stat"].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    status = -1;
                    
                }
                finally 
                { 
                    myConnection.Close(); 
                }
            }
            return status;
        }

        private async void SaveImage(string url, string card_ID)
        {
            String file_name = card_ID + ".jpg";
            String file_path = path + @"\" + file_name;
            var uri = new Uri(url);
            if (File.Exists(file_path)) //check if file exist
            {
                return;
            }
            else
            {
                HttpClient client = new HttpClient();
                    using (var stream = await client.GetStreamAsync(uri))
                    {
                        using (var file_stream = new FileStream(file_path, FileMode.CreateNew))
                        {
                            await stream.CopyToAsync(file_stream);
                        }
                    }
                create_thumbnail(file_name);
            }
        }

        /*Create thumbnail from image*/
        private void create_thumbnail(String file_name)
        {
            DirectoryInfo d = new DirectoryInfo(path);
            string save_path = path + @"\Card_Thumbnails\";
            Image img = new Bitmap(path + @"\" + file_name);
            Image myThumbnail = img.GetThumbnailImage(105, 153, () => false, IntPtr.Zero);
            myThumbnail.Save(save_path + file_name);
        }
        
        public DataTable GetCardMarket(string query)
        {
            DataTable ds = new DataTable();
            SqlDataAdapter adapter;
            SqlCommand myCommand;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                try 
                {
                    myConnection.Open();
                    myCommand = new SqlCommand(query, myConnection);
                    adapter = new SqlDataAdapter(query, myConnection);
                    adapter.Fill(ds); 
                }
                catch (Exception ex)
                {
                    ds = null;
                }   
                finally { myConnection.Close(); }
            }
            return ds;
        }

        public DataTable CPriceHistory(string cid, string setcode, string rarity, string startdate, string enddate)
        {
            DataTable dt = new DataTable();
            string query = "Exec CardPriceHistory @CID, @SC, @R, @Start, @End";
            SqlCommand myCommand;
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@CID", SqlDbType.Int).Value= cid;
                myCommand.Parameters.Add("@SC", SqlDbType.VarChar, 50).Value = setcode;
                myCommand.Parameters.Add("@R", SqlDbType.VarChar, 50).Value = rarity;
                myCommand.Parameters.Add("@Start", SqlDbType.Date).Value= startdate;
                myCommand.Parameters.Add("@End", SqlDbType.Date).Value = enddate;
                try
                {
                    myConnection.Open();
                    myAdapter.SelectCommand = myCommand;
                    myAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dt = null;
                }
                finally { myConnection.Close(); }
            }
            return dt;
        }

        public int UpdateInventory(string uid, string cid, string setcode, string rarity, string s_price, string copies)
        {
            int status;
            string query = "Exec UpdateInventory @UID, @CID, @Set_code, @Rarity, @S_price, @Copies, @Status output";
            SqlCommand myCommand;
            SqlDataReader myReader;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@UID", SqlDbType.VarChar, -1).Value = uid;
                myCommand.Parameters.Add("@CID", SqlDbType.Int).Value = cid;
                myCommand.Parameters.Add("@Set_code", SqlDbType.VarChar, 50).Value = setcode;
                myCommand.Parameters.Add("@Rarity", SqlDbType.VarChar, 50).Value = rarity;
                myCommand.Parameters.Add("@S_price", SqlDbType.Money).Value = s_price;
                myCommand.Parameters.Add("@Copies", SqlDbType.Int).Value = copies;
                myCommand.Parameters.Add("@Status", SqlDbType.Int).Direction = ParameterDirection.Output;
                try
                {
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    status = (int)myCommand.Parameters["@Status"].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    status = -1;
                }
                finally { myConnection.Close(); }
            }
            return status;
        }

        public (string start, string end) DateRange(string cid, string setcode, string rarity)
        {
            string query = "Exec DateRange @CID, @SC, @R, @Start output, @End output";
            string start = null;
            string end = null;
            SqlCommand myCommand;
            SqlDataReader myReader;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@CID", SqlDbType.Int).Value = cid;
                myCommand.Parameters.Add("@SC", SqlDbType.VarChar, 50).Value = setcode;
                myCommand.Parameters.Add("@R", SqlDbType.VarChar, 50).Value = rarity;
                myCommand.Parameters.Add("@Start", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                myCommand.Parameters.Add("@End", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                try
                {
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    start = myCommand.Parameters["@Start"].Value.ToString();
                    end = myCommand.Parameters["@End"].Value.ToString();
                    myConnection.Close();
                    return (start, end);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    myConnection.Close();
                    return (start, end);
                }
            }
        }

        /*Insert the entire table of latest market price of all cards into market price table*/
        public void UpdateTable(DataTable data)
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            SqlCommand myCommand;
            myConnection.Open();
            myCommand = new SqlCommand("UpdateDB2", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@datatable";
            parameter.Value = data;
            myCommand.Parameters.Add(parameter);
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------

        //-----------------------------------------------------------------Conversion Rate Related-----------------------------------------------------
        /*
         Check current rate from database with api rate
        */
        public double GetRate()
        {
            SqlCommand myCommand;
            double rate;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                try
                {
                    myConnection.Open();
                    String query = "Select rate from ConversionRate where update_date = (Select MAX(update_date) as date from ConversionRate)";
                    myCommand = new SqlCommand(query, myConnection);
                    myCommand.Parameters.Add("@rate", System.Data.SqlDbType.Float).Direction = System.Data.ParameterDirection.Output;
                    rate = (double)myCommand.ExecuteScalar();
                }
                catch(Exception ex)
                {
                    rate = 1;
                }
                finally { myConnection.Close(); }
            }
            return rate; 
        }

        /*Insert and return the previously latest or latest rate in the database*/
        public double InsertRate(double rate)
        {
            SqlCommand myCommand;
            double db_rate = 0;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myConnection.Open();
                String query = String.Format("Exec InsertRate {0}", rate);
                myCommand = new SqlCommand(query, myConnection);
                myCommand.ExecuteNonQuery();
            }
            return db_rate;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------

        //-------------------------------------------------------------User Login----------------------------------------------------------------------
        public (string uid, int status) AppLogin(string username, string password)
        {
            SqlCommand myCommand;
            SqlDataReader myReader;
            int status;
            string UID;
            string query = "Exec LoginVerification @user_name, @pw, @status output, @UID output";
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@user_name", SqlDbType.VarChar, 50).Value = username;
                myCommand.Parameters.Add("@pw", SqlDbType.VarChar, 50).Value = password;
                myCommand.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                myCommand.Parameters.Add("@UID", SqlDbType.VarChar, 64).Direction = ParameterDirection.Output;
                try
                {
                    //status should be 1 if success
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    status = (int)myCommand.Parameters["@status"].Value;
                    UID = myCommand.Parameters["@UID"].Value.ToString();
                }
                catch (Exception ex)
                {
                    status = 0;
                    UID = null;
                }
                finally
                {
                    myConnection.Close();
                }
            }
            return (UID, status);

        }
        public (string uid, int status) ExternalLogin(string GID, string auth_type)
        {
            SqlCommand myCommand;
            SqlDataReader myReader;
            int status;
            string UID;
            string query = "Exec ExternalLogin @GID, @auth_type, @status output, @UID output";
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand= new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@GID", SqlDbType.VarChar, 64).Value = GID;
                myCommand.Parameters.Add("@auth_type", SqlDbType.VarChar, 50).Value = auth_type;
                myCommand.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                myCommand.Parameters.Add("@UID", SqlDbType.VarChar, 64).Direction = ParameterDirection.Output;
                try
                {
                    //status should be 1 if success
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    status = (int)myCommand.Parameters["@status"].Value;
                    UID = myCommand.Parameters["@UID"].Value.ToString();
                }
                catch (Exception ex)
                {
                    status = 0;
                    UID = null;
                }
                finally 
                { 
                    myConnection.Close(); 
                }
            }
            return (UID, status);
        }

        public int CreateExternalAccount(string GID, string auth_type, string email, string username)
        {
            SqlCommand myCommand;
            SqlDataReader myReader;
            int status;
            string query = "Exec CreateExternalLogin @GID, @auth_type, @Email, @Username, @status output";
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@GID", SqlDbType.VarChar, 64).Value = GID;
                myCommand.Parameters.Add("@auth_type", SqlDbType.VarChar, 50).Value = auth_type;
                myCommand.Parameters.Add("@Email", SqlDbType.VarChar, -1).Value = email;
                myCommand.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = username;
                myCommand.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                try
                {
                    /*should be 1 if successfully create an account*/
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    status = (int)myCommand.Parameters["@status"].Value;
                }
                catch
                {
                    status = 0;
                }
                finally { myConnection.Close(); }
            }
            return status;
        }

        public int CreateAccount(string hashed_email, string hashed_username, string hashed_password, string re_entered_hash_pw)
        {
            SqlCommand myCommand;
            SqlDataReader myReader;
            int status;
            string query = "Exec CreateUser @UN, @PW, @REPW, @EMAIL, @Status output";
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@UN", SqlDbType.VarChar, 64).Value = hashed_username;
                myCommand.Parameters.Add("@PW", SqlDbType.VarChar, 50).Value = hashed_password;
                myCommand.Parameters.Add("@REPW", SqlDbType.VarChar, -1).Value = re_entered_hash_pw;
                myCommand.Parameters.Add("@EMAIL", SqlDbType.VarChar, 50).Value = hashed_email;
                myCommand.Parameters.Add("@Status", SqlDbType.Int).Direction = ParameterDirection.Output;
                try
                {
                    /*should be 1 if successfully create an account*/
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    status = (int)myCommand.Parameters["@status"].Value;
                }
                catch
                {
                    status = 0;
                }
                finally { myConnection.Close(); }
            }
            return status;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------

        //-------------------------------------------------------------Shopping Cart----------------------------------------------------------------------
        //Inputs = userid
        //Outputs = datatable of card id, set code, rarity, quantity, price
        public DataTable GetShoppingCart(string uid)
        {
            string query = "Exec GetCart @UID";
            DataTable dt = new DataTable();
            SqlCommand myCommand;
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@UID", SqlDbType.VarChar, 64).Value = uid;
                try
                {
                    myConnection.Open();
                    myAdapter.SelectCommand = myCommand;
                    myAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dt = null;
                }
                finally { myConnection.Close(); }
            }
            return dt;
        }

        public int AddToShoppingCart(string uid, string cid, string setcode, string rarity, int quantity)
        {
            int status;
            SqlCommand myCommand;
            SqlDataReader myReader;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                string query = "Exec AddToCart @UID, @CID, @setcode, @rarity, @quantity, @status output";
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@UID", SqlDbType.VarChar, 64).Value = uid;
                myCommand.Parameters.Add("@CID", SqlDbType.Int).Value = cid;
                myCommand.Parameters.Add("@setcode", SqlDbType.VarChar, 50).Value = setcode;
                myCommand.Parameters.Add("@rarity", SqlDbType.VarChar, 50).Value = rarity;
                myCommand.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
                myCommand.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                try
                {
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    status = (int)myCommand.Parameters["@status"].Value;
                    myConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    myConnection.Close();
                    status = -1;
                }
                finally { myConnection.Close(); }
            }
            return status;
        }

        public int EditShoppingCart(string uid, string cid, string setcode, string rarity, int quantity)
        {
            int status;
            SqlCommand myCommand;
            SqlDataReader myReader;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                string query = "Exec EditCart @UID, @CID, @setcode, @rarity, @quantity, @status output";
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@UID", SqlDbType.VarChar, 64).Value = uid;
                myCommand.Parameters.Add("@CID", SqlDbType.Int).Value = cid;
                myCommand.Parameters.Add("@setcode", SqlDbType.VarChar, 50).Value = setcode;
                myCommand.Parameters.Add("@rarity", SqlDbType.VarChar, 50).Value = rarity;
                myCommand.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
                myCommand.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                try
                {
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    status = (int)myCommand.Parameters["@status"].Value;
                    myConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    myConnection.Close();
                    status = -1;
                }
                finally { myConnection.Close(); }
            }
            return status;
        }


        public int ClearShoppingCart(string uid)
        {
            int status = 1;
            SqlCommand myCommand;
            SqlDataReader myReader;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                string query = "Delete from dbo.ShoppingCart where user_id = @UID";
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@UID", SqlDbType.VarChar, 64).Value = uid;
                try
                {
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    status = -1;
                }
                finally { myConnection.Close(); }
            }
            return status;
        }



        /*Generate receipt, takes uid and the shopping card datatable as input*/
        public int Check_Out(string uid, DataTable datatable, string total)
        {
            SqlCommand myCommand;
            SqlDataReader myReader;
            SqlParameter myParameter;
            DataTable dt = datatable.Copy();

            //Removing columns to match table-valued parameter, refer to ReceiptQuery
            dt.Columns.Remove("Card Name");
            dt.Columns.Remove("Card Image");
            dt.Columns.Remove("image");
            dt.Columns.Remove("copies");
            int status = 0;
            Random rand = new Random((int)DateTime.Now.Ticks);
            int tid = rand.Next(1, 100000000); //generate transaction id 
            string time = DateTime.Now.ToString("HH:mm:ss");
            dt.Columns.Add("transaction_id", typeof(System.Int32));
            dt.Columns.Add("user_id", typeof(System.String));
            foreach (DataRow r in dt.Rows)
            {
                r["transaction_id"] = tid;
                r["user_id"] = uid;
            }
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand("AddReceipt", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add("@tid", SqlDbType.Int).Value = tid;
                myCommand.Parameters.Add("@uid", SqlDbType.VarChar, 64).Value = uid;
                myParameter = new SqlParameter();
                myParameter.ParameterName = "@table";
                myParameter.Value = dt;
                myCommand.Parameters.Add(myParameter);
                myCommand.Parameters.Add("@total", SqlDbType.Money).Value = total;
                myCommand.Parameters.Add("@time", SqlDbType.Time).Value = time;
                myCommand.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                try
                {
                    /*should be 1 if successfully create an account*/
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    status = (int)myCommand.Parameters["@status"].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    status = -1;
                }
                finally { myConnection.Close(); }
            }
            if (status == 1)
            {
                MessageBox.Show("Invoice Generated");
            } 
            if(status == 0) { MessageBox.Show("failed"); }

            return status;
        }
    //---------------------------------------------------Sales Report-----------------------------------------------------------------------------------
        public DataSet load_receipt(string start, string end, string uid)
        {
            DataSet ds = new DataSet();
            SqlCommand myCommand;
            SqlDataAdapter myAdapter;;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand("SalesHistory", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add("@UID", SqlDbType.VarChar, 64).Value = uid;
                myCommand.Parameters.Add("@Start", SqlDbType.Date).Value = start;
                myCommand.Parameters.Add("@End", SqlDbType.Date).Value = end;
                try
                {
                    myConnection.Open();
                    myAdapter = new SqlDataAdapter(myCommand);
                    myAdapter.Fill(ds);
                }
                catch (Exception ex)
                {
                    ds = null;
                }
                finally { myConnection.Close(); }
            }
            return ds;
        }


        public DataTable GetRarities()
        {
            string query = "Select distinct rarity from dbo.YGOMarketPrice";
            DataTable dt = new DataTable();
            SqlCommand myCommand;
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand(query, myConnection);
                try
                {
                    myConnection.Open();
                    myAdapter.SelectCommand = myCommand;
                    myAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dt = null;
                }
                finally { myConnection.Close(); }
            }
            return dt;
        }

        public DataTable GetCardType()
        {
            string query = "Select distinct card_type from dbo.YGOCardsInfo";
            DataTable dt = new DataTable();
            SqlCommand myCommand;
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand(query, myConnection);
                try
                {
                    myConnection.Open();
                    myAdapter.SelectCommand = myCommand;
                    myAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dt = null;
                }
                finally { myConnection.Close(); }
            }
            return dt;
        }

        public DataTable GetCardRace()
        {
            string query = "Select distinct card_race from dbo.YGOCardsInfo";
            DataTable dt = new DataTable();
            SqlCommand myCommand;
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand(query, myConnection);
                try
                {
                    myConnection.Open();
                    myAdapter.SelectCommand = myCommand;
                    myAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dt = null;
                }
                finally { myConnection.Close(); }
            }
            return dt;
        }

        public int CheckIfUpdated()
        {
            int status;
            SqlCommand myCommand;
            SqlDataReader myReader;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                string query = "Exec CheckIfUpdated @status output";
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                try
                {
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    status = (int)myCommand.Parameters["@status"].Value;
                    myConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    myConnection.Close();
                    status = -1;
                }
                finally { myConnection.Close(); }
            }
            return status;
        }
    }
}
