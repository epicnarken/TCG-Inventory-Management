﻿namespace InventoryApp
{
    partial class home_page
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            rate_label = new Label();
            date_label = new Label();
            chart2 = new ScottPlot.FormsPlot();
            chart = new ScottPlot.FormsPlot();
            increaseTable = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            separator = new Label();
            logged_user = new Label();
            user_label = new Label();
            top_back_panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)increaseTable).BeginInit();
            top_back_panel.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(422, 521);
            label2.Name = "label2";
            label2.Size = new Size(66, 24);
            label2.TabIndex = 15;
            label2.Text = "Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(186, 521);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 14;
            label1.Text = "Date: ";
            // 
            // rate_label
            // 
            rate_label.AutoSize = true;
            rate_label.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rate_label.ForeColor = Color.Black;
            rate_label.Location = new Point(482, 521);
            rate_label.Name = "rate_label";
            rate_label.Size = new Size(0, 24);
            rate_label.TabIndex = 13;
            // 
            // date_label
            // 
            date_label.AutoSize = true;
            date_label.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            date_label.ForeColor = Color.Black;
            date_label.Location = new Point(246, 521);
            date_label.Name = "date_label";
            date_label.Size = new Size(0, 24);
            date_label.TabIndex = 12;
            // 
            // chart2
            // 
            chart2.ForeColor = SystemColors.Control;
            chart2.Location = new Point(889, 551);
            chart2.Margin = new Padding(5, 4, 5, 4);
            chart2.Name = "chart2";
            chart2.Size = new Size(720, 433);
            chart2.TabIndex = 11;
            // 
            // chart
            // 
            chart.ForeColor = SystemColors.Control;
            chart.Location = new Point(19, 551);
            chart.Margin = new Padding(5, 4, 5, 4);
            chart.Name = "chart";
            chart.Size = new Size(698, 433);
            chart.TabIndex = 10;
            // 
            // increaseTable
            // 
            increaseTable.AllowUserToAddRows = false;
            increaseTable.AllowUserToDeleteRows = false;
            increaseTable.AllowUserToResizeColumns = false;
            increaseTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(239, 239, 249);
            increaseTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            increaseTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            increaseTable.BorderStyle = BorderStyle.None;
            increaseTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(47, 76, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            increaseTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            increaseTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            increaseTable.DefaultCellStyle = dataGridViewCellStyle3;
            increaseTable.Location = new Point(69, 153);
            increaseTable.Margin = new Padding(3, 4, 3, 4);
            increaseTable.Name = "increaseTable";
            increaseTable.ReadOnly = true;
            increaseTable.RowHeadersVisible = false;
            increaseTable.RowHeadersWidth = 51;
            increaseTable.RowTemplate.Height = 25;
            increaseTable.Size = new Size(1023, 287);
            increaseTable.TabIndex = 16;
            increaseTable.CellContentClick += increaseTable_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(69, 101);
            label3.Name = "label3";
            label3.Size = new Size(273, 29);
            label3.TabIndex = 17;
            label3.Text = "Notable Price Changes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1139, 493);
            label4.Name = "label4";
            label4.Size = new Size(265, 29);
            label4.TabIndex = 18;
            label4.Text = "Exchange Rate History";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(278, 477);
            label5.Name = "label5";
            label5.Size = new Size(214, 29);
            label5.TabIndex = 19;
            label5.Text = "Card Rate History";
            // 
            // separator
            // 
            separator.BorderStyle = BorderStyle.Fixed3D;
            separator.Location = new Point(806, 560);
            separator.Name = "separator";
            separator.Size = new Size(2, 400);
            separator.TabIndex = 20;
            // 
            // logged_user
            // 
            logged_user.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logged_user.AutoSize = true;
            logged_user.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            logged_user.Location = new Point(198, 29);
            logged_user.Name = "logged_user";
            logged_user.Size = new Size(79, 31);
            logged_user.TabIndex = 2;
            logged_user.Text = "label1";
            // 
            // user_label
            // 
            user_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            user_label.AutoSize = true;
            user_label.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            user_label.Location = new Point(19, 29);
            user_label.Name = "user_label";
            user_label.Size = new Size(183, 31);
            user_label.TabIndex = 1;
            user_label.Text = "Welcome back,";
            // 
            // top_back_panel
            // 
            top_back_panel.BackColor = SystemColors.ControlDark;
            top_back_panel.Controls.Add(logged_user);
            top_back_panel.Location = new Point(0, 0);
            top_back_panel.Margin = new Padding(3, 4, 3, 4);
            top_back_panel.Name = "top_back_panel";
            top_back_panel.Size = new Size(1711, 84);
            top_back_panel.TabIndex = 21;
            // 
            // home_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(user_label);
            Controls.Add(separator);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(increaseTable);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rate_label);
            Controls.Add(date_label);
            Controls.Add(chart2);
            Controls.Add(chart);
            Controls.Add(top_back_panel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "home_page";
            Size = new Size(1714, 1000);
            ((System.ComponentModel.ISupportInitialize)increaseTable).EndInit();
            top_back_panel.ResumeLayout(false);
            top_back_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label rate_label;
        private Label date_label;
        private ScottPlot.FormsPlot chart2;
        private ScottPlot.FormsPlot chart;
        private DataGridView increaseTable;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label separator;
        private Label logged_user;
        private Label user_label;
        private Panel top_back_panel;
    }
}
