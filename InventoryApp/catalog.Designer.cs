﻿
namespace InventoryApp
{
    partial class catalog
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.catalog_panel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.search_box = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.next_catalog = new System.Windows.Forms.Button();
            this.prev_catalog = new System.Windows.Forms.Button();
            this.catalog_view = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.card_details_panel = new System.Windows.Forms.Panel();
            this.market_price = new System.Windows.Forms.TextBox();
            this.card_rarity = new System.Windows.Forms.TextBox();
            this.set_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.set_code = new System.Windows.Forms.TextBox();
            this.card_race = new System.Windows.Forms.TextBox();
            this.card_type = new System.Windows.Forms.TextBox();
            this.card_name = new System.Windows.Forms.TextBox();
            this.card_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inventory_panel = new System.Windows.Forms.Panel();
            this.warning_label = new System.Windows.Forms.Label();
            this.card_copies = new System.Windows.Forms.TextBox();
            this.store_price = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CardImage = new System.Windows.Forms.PictureBox();
            this.delete_card = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.update_card = new System.Windows.Forms.Button();
            this.cancel_bttn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Return = new System.Windows.Forms.Button();
            this.price_label = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.refresh_chart = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.EndRange = new System.Windows.Forms.DateTimePicker();
            this.StartRange = new System.Windows.Forms.DateTimePicker();
            this.GraphPic = new System.Windows.Forms.PictureBox();
            this.marketChart = new ScottPlot.FormsPlot();
            this.catalog_panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalog_view)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.card_details_panel.SuspendLayout();
            this.inventory_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphPic)).BeginInit();
            this.SuspendLayout();
            // 
            // catalog_panel
            // 
            this.catalog_panel.Controls.Add(this.tabControl1);
            this.catalog_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catalog_panel.Location = new System.Drawing.Point(0, 0);
            this.catalog_panel.Name = "catalog_panel";
            this.catalog_panel.Size = new System.Drawing.Size(1280, 720);
            this.catalog_panel.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 60);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1280, 720);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabPage1.Controls.Add(this.search_box);
            this.tabPage1.Controls.Add(this.search_button);
            this.tabPage1.Controls.Add(this.next_catalog);
            this.tabPage1.Controls.Add(this.prev_catalog);
            this.tabPage1.Controls.Add(this.catalog_view);
            this.tabPage1.Location = new System.Drawing.Point(4, 64);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1272, 652);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(325, 59);
            this.search_box.Name = "search_box";
            this.search_box.PlaceholderText = "Card Name";
            this.search_box.Size = new System.Drawing.Size(272, 23);
            this.search_box.TabIndex = 1;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // search_button
            // 
            this.search_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_button.AutoSize = true;
            this.search_button.Location = new System.Drawing.Point(628, 59);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(208, 25);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // next_catalog
            // 
            this.next_catalog.Location = new System.Drawing.Point(570, 672);
            this.next_catalog.Name = "next_catalog";
            this.next_catalog.Size = new System.Drawing.Size(99, 23);
            this.next_catalog.TabIndex = 9;
            this.next_catalog.Text = "Next Page";
            this.next_catalog.UseVisualStyleBackColor = true;
            this.next_catalog.Click += new System.EventHandler(this.next_catalog_Click);
            // 
            // prev_catalog
            // 
            this.prev_catalog.Enabled = false;
            this.prev_catalog.Location = new System.Drawing.Point(453, 672);
            this.prev_catalog.Name = "prev_catalog";
            this.prev_catalog.Size = new System.Drawing.Size(99, 23);
            this.prev_catalog.TabIndex = 8;
            this.prev_catalog.Text = "Previous Page";
            this.prev_catalog.UseVisualStyleBackColor = true;
            this.prev_catalog.Click += new System.EventHandler(this.prev_catalog_Click);
            // 
            // catalog_view
            // 
            this.catalog_view.AllowUserToAddRows = false;
            this.catalog_view.AllowUserToDeleteRows = false;
            this.catalog_view.AllowUserToResizeColumns = false;
            this.catalog_view.AllowUserToResizeRows = false;
            this.catalog_view.BackgroundColor = System.Drawing.Color.White;
            this.catalog_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.catalog_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalog_view.GridColor = System.Drawing.SystemColors.Control;
            this.catalog_view.Location = new System.Drawing.Point(100, 121);
            this.catalog_view.Name = "catalog_view";
            this.catalog_view.RowHeadersVisible = false;
            this.catalog_view.RowHeadersWidth = 51;
            this.catalog_view.RowTemplate.Height = 25;
            this.catalog_view.Size = new System.Drawing.Size(1080, 528);
            this.catalog_view.TabIndex = 7;
            this.catalog_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catalog_view_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.card_details_panel);
            this.tabPage2.Controls.Add(this.inventory_panel);
            this.tabPage2.Controls.Add(this.CardImage);
            this.tabPage2.Controls.Add(this.delete_card);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.update_card);
            this.tabPage2.Controls.Add(this.cancel_bttn);
            this.tabPage2.Location = new System.Drawing.Point(4, 64);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1272, 652);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(516, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Inventory:";
            // 
            // card_details_panel
            // 
            this.card_details_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card_details_panel.Controls.Add(this.market_price);
            this.card_details_panel.Controls.Add(this.card_rarity);
            this.card_details_panel.Controls.Add(this.set_name);
            this.card_details_panel.Controls.Add(this.label10);
            this.card_details_panel.Controls.Add(this.set_code);
            this.card_details_panel.Controls.Add(this.card_race);
            this.card_details_panel.Controls.Add(this.card_type);
            this.card_details_panel.Controls.Add(this.card_name);
            this.card_details_panel.Controls.Add(this.card_id);
            this.card_details_panel.Controls.Add(this.label9);
            this.card_details_panel.Controls.Add(this.label8);
            this.card_details_panel.Controls.Add(this.label7);
            this.card_details_panel.Controls.Add(this.label6);
            this.card_details_panel.Controls.Add(this.label5);
            this.card_details_panel.Controls.Add(this.label4);
            this.card_details_panel.Controls.Add(this.label2);
            this.card_details_panel.Location = new System.Drawing.Point(516, 54);
            this.card_details_panel.Name = "card_details_panel";
            this.card_details_panel.Size = new System.Drawing.Size(508, 284);
            this.card_details_panel.TabIndex = 22;
            // 
            // market_price
            // 
            this.market_price.Cursor = System.Windows.Forms.Cursors.No;
            this.market_price.Location = new System.Drawing.Point(142, 233);
            this.market_price.Name = "market_price";
            this.market_price.ReadOnly = true;
            this.market_price.Size = new System.Drawing.Size(100, 23);
            this.market_price.TabIndex = 19;
            // 
            // card_rarity
            // 
            this.card_rarity.Cursor = System.Windows.Forms.Cursors.No;
            this.card_rarity.Location = new System.Drawing.Point(17, 233);
            this.card_rarity.Name = "card_rarity";
            this.card_rarity.ReadOnly = true;
            this.card_rarity.Size = new System.Drawing.Size(100, 23);
            this.card_rarity.TabIndex = 18;
            // 
            // set_name
            // 
            this.set_name.Cursor = System.Windows.Forms.Cursors.No;
            this.set_name.Location = new System.Drawing.Point(142, 168);
            this.set_name.Name = "set_name";
            this.set_name.ReadOnly = true;
            this.set_name.Size = new System.Drawing.Size(300, 23);
            this.set_name.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(143, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Market Price";
            // 
            // set_code
            // 
            this.set_code.Cursor = System.Windows.Forms.Cursors.No;
            this.set_code.Location = new System.Drawing.Point(17, 168);
            this.set_code.Name = "set_code";
            this.set_code.ReadOnly = true;
            this.set_code.Size = new System.Drawing.Size(100, 23);
            this.set_code.TabIndex = 16;
            // 
            // card_race
            // 
            this.card_race.Cursor = System.Windows.Forms.Cursors.No;
            this.card_race.Location = new System.Drawing.Point(17, 98);
            this.card_race.Name = "card_race";
            this.card_race.ReadOnly = true;
            this.card_race.Size = new System.Drawing.Size(100, 23);
            this.card_race.TabIndex = 15;
            // 
            // card_type
            // 
            this.card_type.Cursor = System.Windows.Forms.Cursors.No;
            this.card_type.Location = new System.Drawing.Point(142, 98);
            this.card_type.Name = "card_type";
            this.card_type.ReadOnly = true;
            this.card_type.Size = new System.Drawing.Size(100, 23);
            this.card_type.TabIndex = 14;
            // 
            // card_name
            // 
            this.card_name.Cursor = System.Windows.Forms.Cursors.No;
            this.card_name.Location = new System.Drawing.Point(142, 33);
            this.card_name.Name = "card_name";
            this.card_name.ReadOnly = true;
            this.card_name.Size = new System.Drawing.Size(300, 23);
            this.card_name.TabIndex = 13;
            // 
            // card_id
            // 
            this.card_id.Cursor = System.Windows.Forms.Cursors.No;
            this.card_id.Location = new System.Drawing.Point(17, 33);
            this.card_id.Name = "card_id";
            this.card_id.ReadOnly = true;
            this.card_id.Size = new System.Drawing.Size(100, 23);
            this.card_id.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(17, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Rarity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(143, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Set Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(16, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Set Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(142, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Card Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(15, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Card Race";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(142, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Card Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Card ID";
            // 
            // inventory_panel
            // 
            this.inventory_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventory_panel.Controls.Add(this.warning_label);
            this.inventory_panel.Controls.Add(this.card_copies);
            this.inventory_panel.Controls.Add(this.store_price);
            this.inventory_panel.Controls.Add(this.label12);
            this.inventory_panel.Controls.Add(this.label11);
            this.inventory_panel.Location = new System.Drawing.Point(516, 380);
            this.inventory_panel.Name = "inventory_panel";
            this.inventory_panel.Size = new System.Drawing.Size(508, 99);
            this.inventory_panel.TabIndex = 21;
            // 
            // warning_label
            // 
            this.warning_label.AutoSize = true;
            this.warning_label.ForeColor = System.Drawing.Color.Red;
            this.warning_label.Location = new System.Drawing.Point(15, 48);
            this.warning_label.Name = "warning_label";
            this.warning_label.Size = new System.Drawing.Size(38, 15);
            this.warning_label.TabIndex = 21;
            this.warning_label.Text = "label1";
            this.warning_label.Visible = false;
            // 
            // card_copies
            // 
            this.card_copies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.card_copies.Location = new System.Drawing.Point(142, 38);
            this.card_copies.Name = "card_copies";
            this.card_copies.Size = new System.Drawing.Size(100, 23);
            this.card_copies.TabIndex = 20;
            // 
            // store_price
            // 
            this.store_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.store_price.Location = new System.Drawing.Point(17, 38);
            this.store_price.Name = "store_price";
            this.store_price.Size = new System.Drawing.Size(100, 23);
            this.store_price.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(142, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 21);
            this.label12.TabIndex = 13;
            this.label12.Text = "Copies";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(17, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "Store Price";
            // 
            // CardImage
            // 
            this.CardImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardImage.Location = new System.Drawing.Point(82, 28);
            this.CardImage.Name = "CardImage";
            this.CardImage.Size = new System.Drawing.Size(400, 546);
            this.CardImage.TabIndex = 16;
            this.CardImage.TabStop = false;
            // 
            // delete_card
            // 
            this.delete_card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.delete_card.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_card.ForeColor = System.Drawing.Color.White;
            this.delete_card.Location = new System.Drawing.Point(500, 515);
            this.delete_card.Name = "delete_card";
            this.delete_card.Size = new System.Drawing.Size(160, 45);
            this.delete_card.TabIndex = 17;
            this.delete_card.Text = "Delete From Inventory";
            this.delete_card.UseVisualStyleBackColor = false;
            this.delete_card.Click += new System.EventHandler(this.delete_card_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.label13.Location = new System.Drawing.Point(516, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 23);
            this.label13.TabIndex = 20;
            this.label13.Text = "Card Details:";
            // 
            // update_card
            // 
            this.update_card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.update_card.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_card.ForeColor = System.Drawing.Color.White;
            this.update_card.Location = new System.Drawing.Point(691, 515);
            this.update_card.Name = "update_card";
            this.update_card.Size = new System.Drawing.Size(160, 45);
            this.update_card.TabIndex = 18;
            this.update_card.Text = "Save Changes";
            this.update_card.UseVisualStyleBackColor = false;
            this.update_card.Click += new System.EventHandler(this.update_card_Click);
            // 
            // cancel_bttn
            // 
            this.cancel_bttn.BackColor = System.Drawing.SystemColors.Control;
            this.cancel_bttn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.cancel_bttn.Location = new System.Drawing.Point(876, 515);
            this.cancel_bttn.Name = "cancel_bttn";
            this.cancel_bttn.Size = new System.Drawing.Size(160, 45);
            this.cancel_bttn.TabIndex = 19;
            this.cancel_bttn.Text = "Cancel";
            this.cancel_bttn.UseVisualStyleBackColor = false;
            this.cancel_bttn.Click += new System.EventHandler(this.cancel_bttn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Return);
            this.tabPage3.Controls.Add(this.price_label);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.date_label);
            this.tabPage3.Controls.Add(this.refresh_chart);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.EndRange);
            this.tabPage3.Controls.Add(this.StartRange);
            this.tabPage3.Controls.Add(this.GraphPic);
            this.tabPage3.Controls.Add(this.marketChart);
            this.tabPage3.Location = new System.Drawing.Point(4, 64);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1272, 652);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "graph";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Return.Location = new System.Drawing.Point(82, 598);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(131, 33);
            this.Return.TabIndex = 12;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.graphReturn_Click);
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.price_label.ForeColor = System.Drawing.Color.White;
            this.price_label.Location = new System.Drawing.Point(882, 28);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(0, 19);
            this.price_label.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(823, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 19);
            this.label17.TabIndex = 10;
            this.label17.Text = "Price:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(623, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 19);
            this.label16.TabIndex = 9;
            this.label16.Text = "Date:";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date_label.ForeColor = System.Drawing.Color.White;
            this.date_label.Location = new System.Drawing.Point(680, 28);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(0, 19);
            this.date_label.TabIndex = 8;
            // 
            // refresh_chart
            // 
            this.refresh_chart.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.refresh_chart.Location = new System.Drawing.Point(1069, 611);
            this.refresh_chart.Name = "refresh_chart";
            this.refresh_chart.Size = new System.Drawing.Size(106, 24);
            this.refresh_chart.TabIndex = 7;
            this.refresh_chart.Text = "Refresh";
            this.refresh_chart.UseVisualStyleBackColor = true;
            this.refresh_chart.Click += new System.EventHandler(this.refresh_chart_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(823, 611);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "To";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(523, 611);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "From";
            // 
            // EndRange
            // 
            this.EndRange.CustomFormat = "yyyy-MM-dd";
            this.EndRange.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndRange.Location = new System.Drawing.Point(855, 611);
            this.EndRange.Name = "EndRange";
            this.EndRange.Size = new System.Drawing.Size(200, 23);
            this.EndRange.TabIndex = 4;
            // 
            // StartRange
            // 
            this.StartRange.CustomFormat = "yyyy-MM-dd";
            this.StartRange.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartRange.Location = new System.Drawing.Point(575, 611);
            this.StartRange.Name = "StartRange";
            this.StartRange.Size = new System.Drawing.Size(200, 23);
            this.StartRange.TabIndex = 3;
            // 
            // GraphPic
            // 
            this.GraphPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GraphPic.Location = new System.Drawing.Point(82, 28);
            this.GraphPic.Name = "GraphPic";
            this.GraphPic.Size = new System.Drawing.Size(400, 546);
            this.GraphPic.TabIndex = 1;
            this.GraphPic.TabStop = false;
            // 
            // marketChart
            // 
            this.marketChart.Location = new System.Drawing.Point(575, 50);
            this.marketChart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.marketChart.Name = "marketChart";
            this.marketChart.Size = new System.Drawing.Size(616, 555);
            this.marketChart.TabIndex = 0;
            // 
            // catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.catalog_panel);
            this.Name = "catalog";
            this.Size = new System.Drawing.Size(1280, 720);
            this.catalog_panel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalog_view)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.card_details_panel.ResumeLayout(false);
            this.card_details_panel.PerformLayout();
            this.inventory_panel.ResumeLayout(false);
            this.inventory_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel catalog_panel;
        private TextBox search_box;
        private Button search_button;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private Panel card_details_panel;
        private TextBox market_price;
        private TextBox card_rarity;
        private TextBox set_name;
        private Label label10;
        private TextBox set_code;
        private TextBox card_race;
        private TextBox card_type;
        private TextBox card_name;
        private TextBox card_id;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Panel inventory_panel;
        private TextBox card_copies;
        private TextBox store_price;
        private Label label12;
        private Label label11;
        private PictureBox CardImage;
        private Button delete_card;
        private Label label13;
        private Button update_card;
        private Button cancel_bttn;
        private TabPage tabPage3;
        private PictureBox GraphPic;
        private ScottPlot.FormsPlot marketChart;
        private DateTimePicker EndRange;
        private DateTimePicker StartRange;
        private Button refresh_chart;
        private Label label15;
        private Label label14;
        private Button next_catalog;
        private Button prev_catalog;
        private DataGridView catalog_view;
        private Label warning_label;
        private Label price_label;
        private Label label17;
        private Label label16;
        private Label date_label;
        private Button Return;
    }
}
