namespace LMS.GUIForms
{
    partial class Librarianlogoin
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
            label1close = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1username = new TextBox();
            textBox2userid = new TextBox();
            textBox3password = new TextBox();
            button1login = new Button();
            SuspendLayout();
            // 
            // label1close
            // 
            label1close.AutoSize = true;
            label1close.Location = new Point(399, 20);
            label1close.Name = "label1close";
            label1close.Size = new Size(18, 20);
            label1close.TabIndex = 0;
            label1close.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 155);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "user name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 220);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "user id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 267);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 3;
            label3.Text = "password";
            // 
            // textBox1username
            // 
            textBox1username.Location = new Point(190, 155);
            textBox1username.Name = "textBox1username";
            textBox1username.Size = new Size(125, 27);
            textBox1username.TabIndex = 4;
            // 
            // textBox2userid
            // 
            textBox2userid.Location = new Point(190, 213);
            textBox2userid.Name = "textBox2userid";
            textBox2userid.Size = new Size(125, 27);
            textBox2userid.TabIndex = 5;
            // 
            // textBox3password
            // 
            textBox3password.Location = new Point(190, 260);
            textBox3password.Name = "textBox3password";
            textBox3password.Size = new Size(125, 27);
            textBox3password.TabIndex = 6;
            // 
            // button1login
            // 
            button1login.Location = new Point(181, 372);
            button1login.Name = "button1login";
            button1login.Size = new Size(94, 29);
            button1login.TabIndex = 7;
            button1login.Text = "LogIn";
            button1login.UseVisualStyleBackColor = true;
            // 
            // Librarianlogoin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 450);
            Controls.Add(button1login);
            Controls.Add(textBox3password);
            Controls.Add(textBox2userid);
            Controls.Add(textBox1username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label1close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Librarianlogoin";
            Text = "Librarianlogoin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1close;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1username;
        private TextBox textBox2userid;
        private TextBox textBox3password;
        private Button button1login;
    }
}