﻿namespace InventoryApp
{
    partial class AddCardForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cn_label = new System.Windows.Forms.Label();
            this.api_cn = new System.Windows.Forms.TextBox();
            this.card_srch = new System.Windows.Forms.TextBox();
            this.rtv_card = new System.Windows.Forms.Button();
            this.api_id = new System.Windows.Forms.TextBox();
            this.api_setcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.api_setname = new System.Windows.Forms.TextBox();
            this.s_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.image_url = new System.Windows.Forms.TextBox();
            this.add_bttn = new System.Windows.Forms.Button();
            this.set_gridview = new System.Windows.Forms.DataGridView();
            this.api_rare = new System.Windows.Forms.TextBox();
            this.rare_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.api_crace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.api_ctype = new System.Windows.Forms.TextBox();
            this.card_qnty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.api_price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.srch_option = new System.Windows.Forms.ComboBox();
            this.card_gridview = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.set_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // cn_label
            // 
            this.cn_label.AutoSize = true;
            this.cn_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cn_label.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cn_label.Location = new System.Drawing.Point(285, 89);
            this.cn_label.Name = "cn_label";
            this.cn_label.Size = new System.Drawing.Size(76, 17);
            this.cn_label.TabIndex = 0;
            this.cn_label.Text = "Card Name";
            // 
            // api_cn
            // 
            this.api_cn.Cursor = System.Windows.Forms.Cursors.No;
            this.api_cn.Location = new System.Drawing.Point(285, 109);
            this.api_cn.Name = "api_cn";
            this.api_cn.ReadOnly = true;
            this.api_cn.Size = new System.Drawing.Size(300, 23);
            this.api_cn.TabIndex = 1;
            // 
            // card_srch
            // 
            this.card_srch.Location = new System.Drawing.Point(307, 31);
            this.card_srch.Name = "card_srch";
            this.card_srch.Size = new System.Drawing.Size(406, 23);
            this.card_srch.TabIndex = 2;
            // 
            // rtv_card
            // 
            this.rtv_card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(171)))), ((int)(((byte)(254)))));
            this.rtv_card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtv_card.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtv_card.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.rtv_card.Location = new System.Drawing.Point(719, 25);
            this.rtv_card.Name = "rtv_card";
            this.rtv_card.Size = new System.Drawing.Size(126, 33);
            this.rtv_card.TabIndex = 3;
            this.rtv_card.Text = "Search";
            this.rtv_card.UseVisualStyleBackColor = false;
            this.rtv_card.Click += new System.EventHandler(this.rtv_card_Click);
            // 
            // api_id
            // 
            this.api_id.Cursor = System.Windows.Forms.Cursors.No;
            this.api_id.Location = new System.Drawing.Point(152, 109);
            this.api_id.Name = "api_id";
            this.api_id.ReadOnly = true;
            this.api_id.Size = new System.Drawing.Size(100, 23);
            this.api_id.TabIndex = 4;
            // 
            // api_setcode
            // 
            this.api_setcode.Cursor = System.Windows.Forms.Cursors.No;
            this.api_setcode.Location = new System.Drawing.Point(152, 162);
            this.api_setcode.Name = "api_setcode";
            this.api_setcode.ReadOnly = true;
            this.api_setcode.Size = new System.Drawing.Size(100, 23);
            this.api_setcode.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(152, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Card ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(152, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Set Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(286, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Set Name";
            // 
            // api_setname
            // 
            this.api_setname.Cursor = System.Windows.Forms.Cursors.No;
            this.api_setname.Location = new System.Drawing.Point(286, 162);
            this.api_setname.Name = "api_setname";
            this.api_setname.ReadOnly = true;
            this.api_setname.Size = new System.Drawing.Size(300, 23);
            this.api_setname.TabIndex = 9;
            // 
            // s_price
            // 
            this.s_price.Location = new System.Drawing.Point(297, 245);
            this.s_price.Name = "s_price";
            this.s_price.Size = new System.Drawing.Size(100, 23);
            this.s_price.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(297, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Store Price ";
            // 
            // image_url
            // 
            this.image_url.Location = new System.Drawing.Point(725, 162);
            this.image_url.Name = "image_url";
            this.image_url.ReadOnly = true;
            this.image_url.Size = new System.Drawing.Size(87, 23);
            this.image_url.TabIndex = 12;
            this.image_url.Visible = false;
            // 
            // add_bttn
            // 
            this.add_bttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.add_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.add_bttn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_bttn.ForeColor = System.Drawing.Color.White;
            this.add_bttn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_bttn.Location = new System.Drawing.Point(442, 719);
            this.add_bttn.Name = "add_bttn";
            this.add_bttn.Size = new System.Drawing.Size(164, 43);
            this.add_bttn.TabIndex = 13;
            this.add_bttn.Text = "Add To Inventory";
            this.add_bttn.UseVisualStyleBackColor = false;
            this.add_bttn.Click += new System.EventHandler(this.add_bttn_Click);
            // 
            // set_gridview
            // 
            this.set_gridview.AllowUserToAddRows = false;
            this.set_gridview.AllowUserToDeleteRows = false;
            this.set_gridview.AllowUserToResizeColumns = false;
            this.set_gridview.AllowUserToResizeRows = false;
            this.set_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.set_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.set_gridview.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.set_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.set_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.set_gridview.EnableHeadersVisualStyles = false;
            this.set_gridview.Location = new System.Drawing.Point(134, 527);
            this.set_gridview.MultiSelect = false;
            this.set_gridview.Name = "set_gridview";
            this.set_gridview.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.set_gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.set_gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.set_gridview.RowTemplate.Height = 25;
            this.set_gridview.Size = new System.Drawing.Size(798, 186);
            this.set_gridview.TabIndex = 14;
            this.set_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.api_gridview_CellContentClick);
            // 
            // api_rare
            // 
            this.api_rare.Cursor = System.Windows.Forms.Cursors.No;
            this.api_rare.Location = new System.Drawing.Point(619, 162);
            this.api_rare.Name = "api_rare";
            this.api_rare.ReadOnly = true;
            this.api_rare.Size = new System.Drawing.Size(100, 23);
            this.api_rare.TabIndex = 15;
            // 
            // rare_label
            // 
            this.rare_label.AutoSize = true;
            this.rare_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rare_label.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rare_label.Location = new System.Drawing.Point(619, 143);
            this.rare_label.Name = "rare_label";
            this.rare_label.Size = new System.Drawing.Size(43, 17);
            this.rare_label.TabIndex = 16;
            this.rare_label.Text = "Rarity";
            // 
            // api_crace
            // 
            this.api_crace.Cursor = System.Windows.Forms.Cursors.No;
            this.api_crace.Location = new System.Drawing.Point(745, 110);
            this.api_crace.Name = "api_crace";
            this.api_crace.ReadOnly = true;
            this.api_crace.Size = new System.Drawing.Size(100, 23);
            this.api_crace.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(745, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Card Race";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(619, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Card Type";
            // 
            // api_ctype
            // 
            this.api_ctype.Cursor = System.Windows.Forms.Cursors.No;
            this.api_ctype.Location = new System.Drawing.Point(619, 110);
            this.api_ctype.Name = "api_ctype";
            this.api_ctype.ReadOnly = true;
            this.api_ctype.Size = new System.Drawing.Size(100, 23);
            this.api_ctype.TabIndex = 20;
            // 
            // card_qnty
            // 
            this.card_qnty.Location = new System.Drawing.Point(442, 245);
            this.card_qnty.Name = "card_qnty";
            this.card_qnty.Size = new System.Drawing.Size(100, 23);
            this.card_qnty.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(442, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Quantity ";
            // 
            // api_price
            // 
            this.api_price.Cursor = System.Windows.Forms.Cursors.No;
            this.api_price.Location = new System.Drawing.Point(152, 245);
            this.api_price.Name = "api_price";
            this.api_price.ReadOnly = true;
            this.api_price.Size = new System.Drawing.Size(100, 23);
            this.api_price.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(152, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Market Price";
            // 
            // srch_option
            // 
            this.srch_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.srch_option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.srch_option.FormattingEnabled = true;
            this.srch_option.Items.AddRange(new object[] {
            "Card Name",
            "Card ID",
            "Set Name"});
            this.srch_option.Location = new System.Drawing.Point(180, 31);
            this.srch_option.Name = "srch_option";
            this.srch_option.Size = new System.Drawing.Size(121, 23);
            this.srch_option.TabIndex = 25;
            // 
            // card_gridview
            // 
            this.card_gridview.AllowUserToAddRows = false;
            this.card_gridview.AllowUserToDeleteRows = false;
            this.card_gridview.AllowUserToResizeColumns = false;
            this.card_gridview.AllowUserToResizeRows = false;
            this.card_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.card_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.card_gridview.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.card_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.card_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.card_gridview.EnableHeadersVisualStyles = false;
            this.card_gridview.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.card_gridview.Location = new System.Drawing.Point(135, 306);
            this.card_gridview.MultiSelect = false;
            this.card_gridview.Name = "card_gridview";
            this.card_gridview.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.card_gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.card_gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.card_gridview.RowTemplate.Height = 25;
            this.card_gridview.Size = new System.Drawing.Size(798, 186);
            this.card_gridview.TabIndex = 26;
            this.card_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.card_view_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.label9.Location = new System.Drawing.Point(134, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Card Details:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.label10.Location = new System.Drawing.Point(134, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Product Details:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.label11.Location = new System.Drawing.Point(134, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Card Info:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.label12.Location = new System.Drawing.Point(135, 508);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Card Version:";
            // 
            // AddCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1086, 785);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.card_gridview);
            this.Controls.Add(this.srch_option);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.api_price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.card_qnty);
            this.Controls.Add(this.api_ctype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.api_crace);
            this.Controls.Add(this.rare_label);
            this.Controls.Add(this.api_rare);
            this.Controls.Add(this.set_gridview);
            this.Controls.Add(this.add_bttn);
            this.Controls.Add(this.image_url);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.s_price);
            this.Controls.Add(this.api_setname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.api_setcode);
            this.Controls.Add(this.api_id);
            this.Controls.Add(this.rtv_card);
            this.Controls.Add(this.card_srch);
            this.Controls.Add(this.api_cn);
            this.Controls.Add(this.cn_label);
            this.Name = "AddCardForm";
            this.Text = "AddCardForm";
            this.Load += new System.EventHandler(this.AddCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.set_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cn_label;
        private TextBox api_cn;
        private TextBox card_srch;
        private Button rtv_card;
        private TextBox api_id;
        private TextBox api_setcode;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox api_setname;
        private TextBox s_price;
        private Label label4;
        private TextBox image_url;
        private Button add_bttn;
        private DataGridView set_gridview;
        private TextBox api_rare;
        private Label rare_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox api_crace;
        private Label label5;
        private Label label6;
        private TextBox api_ctype;
        private TextBox card_qnty;
        private Label label7;
        private TextBox api_price;
        private Label label8;
        private ComboBox srch_option;
        private DataGridView card_gridview;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}