namespace Final
{
    partial class SignUp
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
            pictureBox1 = new PictureBox();
            button1signup = new Button();
            label1 = new Label();
            textBox2username = new TextBox();
            label3close = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox3password = new TextBox();
            textBox4conpassword = new TextBox();
            checkBox1showpwd = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = LMS.Properties.Resources.contact1;
            pictureBox1.Location = new Point(151, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1signup
            // 
            button1signup.BackColor = SystemColors.ActiveCaptionText;
            button1signup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1signup.ForeColor = SystemColors.Control;
            button1signup.Location = new Point(151, 415);
            button1signup.Name = "button1signup";
            button1signup.Size = new Size(125, 42);
            button1signup.TabIndex = 1;
            button1signup.Text = "Sing Up";
            button1signup.UseVisualStyleBackColor = false;
            button1signup.Click += button1signup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 198);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // textBox2username
            // 
            textBox2username.Location = new Point(191, 196);
            textBox2username.Name = "textBox2username";
            textBox2username.Size = new Size(209, 27);
            textBox2username.TabIndex = 5;
            // 
            // label3close
            // 
            label3close.AutoSize = true;
            label3close.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3close.Location = new Point(391, 9);
            label3close.Name = "label3close";
            label3close.Size = new Size(35, 38);
            label3close.TabIndex = 6;
            label3close.Text = "X";
            label3close.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 249);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 288);
            label5.Name = "label5";
            label5.Size = new Size(163, 25);
            label5.TabIndex = 8;
            label5.Text = "confirm Password";
            // 
            // textBox3password
            // 
            textBox3password.Location = new Point(191, 249);
            textBox3password.Name = "textBox3password";
            textBox3password.PasswordChar = '*';
            textBox3password.Size = new Size(209, 27);
            textBox3password.TabIndex = 9;
            // 
            // textBox4conpassword
            // 
            textBox4conpassword.Location = new Point(191, 304);
            textBox4conpassword.Name = "textBox4conpassword";
            textBox4conpassword.PasswordChar = '*';
            textBox4conpassword.Size = new Size(209, 27);
            textBox4conpassword.TabIndex = 10;
            // 
            // checkBox1showpwd
            // 
            checkBox1showpwd.AutoSize = true;
            checkBox1showpwd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1showpwd.Location = new Point(286, 356);
            checkBox1showpwd.Name = "checkBox1showpwd";
            checkBox1showpwd.Size = new Size(140, 24);
            checkBox1showpwd.TabIndex = 12;
            checkBox1showpwd.Text = "Show password";
            checkBox1showpwd.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(438, 528);
            Controls.Add(checkBox1showpwd);
            Controls.Add(textBox4conpassword);
            Controls.Add(textBox3password);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3close);
            Controls.Add(textBox2username);
            Controls.Add(label1);
            Controls.Add(button1signup);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1signup;
        private Label label1;
        private TextBox textBox2username;
        private Label label3close;
        private Label label4;
        private Label label5;
        private TextBox textBox3password;
        private TextBox textBox4conpassword;
        private CheckBox checkBox1showpwd;
    }
}