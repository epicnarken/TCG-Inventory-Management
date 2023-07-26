﻿namespace InventoryApp
{
    partial class Login
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
            name_label = new Label();
            incorrect_prompt = new Label();
            login_button = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pw_input = new MaskedTextBox();
            user_input = new TextBox();
            google_logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)google_logo).BeginInit();
            SuspendLayout();
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.BackColor = Color.Transparent;
            name_label.Font = new Font("Sylfaen", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            name_label.ForeColor = Color.LightCoral;
            name_label.Location = new Point(117, 31);
            name_label.Name = "name_label";
            name_label.Size = new Size(421, 48);
            name_label.TabIndex = 0;
            name_label.Text = "TCG Inventory Manager";
            // 
            // incorrect_prompt
            // 
            incorrect_prompt.AutoSize = true;
            incorrect_prompt.BackColor = Color.Transparent;
            incorrect_prompt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            incorrect_prompt.ForeColor = Color.Red;
            incorrect_prompt.Location = new Point(194, 437);
            incorrect_prompt.Name = "incorrect_prompt";
            incorrect_prompt.Size = new Size(247, 21);
            incorrect_prompt.TabIndex = 6;
            incorrect_prompt.Text = "Incorrect Username or Password";
            incorrect_prompt.Visible = false;
            // 
            // login_button
            // 
            login_button.FlatStyle = FlatStyle.System;
            login_button.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            login_button.Location = new Point(232, 350);
            login_button.Name = "login_button";
            login_button.Size = new Size(187, 38);
            login_button.TabIndex = 5;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(252, 93);
            label4.Name = "label4";
            label4.Size = new Size(143, 65);
            label4.TabIndex = 4;
            label4.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 266);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 193);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // pw_input
            // 
            pw_input.BackColor = Color.White;
            pw_input.BorderStyle = BorderStyle.None;
            pw_input.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            pw_input.Location = new Point(138, 266);
            pw_input.Name = "pw_input";
            pw_input.PasswordChar = '*';
            pw_input.Size = new Size(451, 26);
            pw_input.TabIndex = 1;
            // 
            // user_input
            // 
            user_input.BackColor = Color.White;
            user_input.BorderStyle = BorderStyle.None;
            user_input.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            user_input.ForeColor = Color.Yellow;
            user_input.Location = new Point(138, 193);
            user_input.Name = "user_input";
            user_input.PlaceholderText = "User Name";
            user_input.Size = new Size(451, 26);
            user_input.TabIndex = 0;
            // 
            // google_logo
            // 
            google_logo.Image = Properties.Resources.google_logo;
            google_logo.Location = new Point(41, 398);
            google_logo.Name = "google_logo";
            google_logo.Size = new Size(58, 60);
            google_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            google_logo.TabIndex = 7;
            google_logo.TabStop = false;
            google_logo.Click += google_logo_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 498);
            Controls.Add(google_logo);
            Controls.Add(incorrect_prompt);
            Controls.Add(name_label);
            Controls.Add(login_button);
            Controls.Add(user_input);
            Controls.Add(label4);
            Controls.Add(pw_input);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)google_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label name_label;
        private Label label1;
        private MaskedTextBox pw_input;
        private TextBox user_input;
        private Label label2;
        private Label label4;
        private Button login_button;
        private Label incorrect_prompt;
        private PictureBox google_logo;
    }
}