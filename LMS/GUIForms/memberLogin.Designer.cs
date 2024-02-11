namespace LMS.GUIForms
{
    partial class MemberLogin
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
            button1login = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1username = new TextBox();
            textBox2userid = new TextBox();
            textBox3password = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1close
            // 
            label1close.AutoSize = true;
            label1close.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1close.Location = new Point(358, 9);
            label1close.Name = "label1close";
            label1close.Size = new Size(29, 31);
            label1close.TabIndex = 0;
            label1close.Text = "X";
            label1close.Click += label1close_Click;
            // 
            // button1login
            // 
            button1login.BackColor = SystemColors.ActiveCaptionText;
            button1login.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1login.ForeColor = SystemColors.Control;
            button1login.Location = new Point(152, 320);
            button1login.Name = "button1login";
            button1login.Size = new Size(94, 50);
            button1login.TabIndex = 1;
            button1login.Text = "Log In";
            button1login.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user3;
            pictureBox1.Location = new Point(139, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 190);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 3;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 228);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 4;
            label3.Text = "User ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 269);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // textBox1username
            // 
            textBox1username.Location = new Point(181, 188);
            textBox1username.Name = "textBox1username";
            textBox1username.Size = new Size(169, 27);
            textBox1username.TabIndex = 6;
            // 
            // textBox2userid
            // 
            textBox2userid.Location = new Point(181, 229);
            textBox2userid.Name = "textBox2userid";
            textBox2userid.Size = new Size(169, 27);
            textBox2userid.TabIndex = 7;
            // 
            // textBox3password
            // 
            textBox3password.Location = new Point(181, 270);
            textBox3password.Name = "textBox3password";
            textBox3password.Size = new Size(169, 27);
            textBox3password.TabIndex = 8;
            // 
            // MemberLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(399, 450);
            Controls.Add(textBox3password);
            Controls.Add(textBox2userid);
            Controls.Add(textBox1username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button1login);
            Controls.Add(label1close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MemberLogin";
            Text = "MemberLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1close;
        private Button button1login;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1username;
        private TextBox textBox2userid;
        private TextBox textBox3password;
    }
}