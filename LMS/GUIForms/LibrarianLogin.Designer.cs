﻿namespace Final
{
    partial class LibrarianLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            button1login = new Button();
            username = new Label();
            textBox1username = new TextBox();
            label3close = new Label();
            password = new Label();
            textBox3password = new TextBox();
            label1 = new Label();
            textBox1userID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = LMS.Properties.Resources.user;
            pictureBox1.Location = new Point(238, 45);
            pictureBox1.Margin = new Padding(6, 6, 6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 273);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1login
            // 
            button1login.BackColor = SystemColors.ActiveCaptionText;
            button1login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1login.ForeColor = SystemColors.Control;
            button1login.Location = new Point(212, 722);
            button1login.Margin = new Padding(6, 6, 6, 6);
            button1login.Name = "button1login";
            button1login.Size = new Size(238, 92);
            button1login.TabIndex = 1;
            button1login.Text = "Log In";
            button1login.UseVisualStyleBackColor = false;
            button1login.Click += button1login_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username.Location = new Point(40, 371);
            username.Margin = new Padding(6, 0, 6, 0);
            username.Name = "username";
            username.Size = new Size(204, 48);
            username.TabIndex = 2;
            username.Text = "User Name";
            // 
            // textBox1username
            // 
            textBox1username.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1username.Location = new Point(308, 373);
            textBox1username.Margin = new Padding(6, 6, 6, 6);
            textBox1username.Name = "textBox1username";
            textBox1username.Size = new Size(376, 47);
            textBox1username.TabIndex = 4;
            // 
            // label3close
            // 
            label3close.AutoSize = true;
            label3close.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3close.Location = new Point(703, 18);
            label3close.Margin = new Padding(6, 0, 6, 0);
            label3close.Name = "label3close";
            label3close.Size = new Size(68, 74);
            label3close.TabIndex = 6;
            label3close.Text = "X";
            label3close.Click += label3close_Click;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password.Location = new Point(40, 594);
            password.Margin = new Padding(6, 0, 6, 0);
            password.Name = "password";
            password.Size = new Size(179, 48);
            password.TabIndex = 7;
            password.Text = "Password";
            // 
            // textBox3password
            // 
            textBox3password.Location = new Point(308, 590);
            textBox3password.Margin = new Padding(6, 6, 6, 6);
            textBox3password.Name = "textBox3password";
            textBox3password.Size = new Size(376, 47);
            textBox3password.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 492);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 48);
            label1.TabIndex = 9;
            label1.Text = "User ID";
            // 
            // textBox1userID
            // 
            textBox1userID.Location = new Point(308, 488);
            textBox1userID.Margin = new Padding(6, 6, 6, 6);
            textBox1userID.Name = "textBox1userID";
            textBox1userID.Size = new Size(376, 47);
            textBox1userID.TabIndex = 10;
            // 
            // LibrarianLogin
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(774, 922);
            Controls.Add(textBox1userID);
            Controls.Add(label1);
            Controls.Add(textBox3password);
            Controls.Add(password);
            Controls.Add(label3close);
            Controls.Add(textBox1username);
            Controls.Add(username);
            Controls.Add(button1login);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "LibrarianLogin";
            Text = "LibrarianLogin";
            Load += LibrarianLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1login;
        private Label username;
        private TextBox textBox1username;
        private Label label3close;
        private Label password;
        private TextBox textBox3password;
        private Label label1;
        private TextBox textBox1userID;
    }
}