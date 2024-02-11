namespace LMS.GUIForms
{
    partial class Signup
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1username = new TextBox();
            textBox2password = new TextBox();
            textBox3conpassword = new TextBox();
            button1signup = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user2;
            pictureBox1.Location = new Point(314, 72);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(831, 45);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 62);
            label1.TabIndex = 1;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 447);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(204, 48);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 533);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(179, 48);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 605);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(345, 48);
            label4.TabIndex = 4;
            label4.Text = "Confirme Password";
            // 
            // textBox1username
            // 
            textBox1username.Location = new Point(410, 449);
            textBox1username.Margin = new Padding(6);
            textBox1username.Name = "textBox1username";
            textBox1username.Size = new Size(438, 47);
            textBox1username.TabIndex = 5;
            // 
            // textBox2password
            // 
            textBox2password.Location = new Point(410, 529);
            textBox2password.Margin = new Padding(6);
            textBox2password.Name = "textBox2password";
            textBox2password.Size = new Size(438, 47);
            textBox2password.TabIndex = 6;
            // 
            // textBox3conpassword
            // 
            textBox3conpassword.Location = new Point(410, 625);
            textBox3conpassword.Margin = new Padding(6);
            textBox3conpassword.Name = "textBox3conpassword";
            textBox3conpassword.Size = new Size(438, 47);
            textBox3conpassword.TabIndex = 7;
            // 
            // button1signup
            // 
            button1signup.BackColor = SystemColors.ActiveCaptionText;
            button1signup.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1signup.ForeColor = SystemColors.Control;
            button1signup.Location = new Point(325, 761);
            button1signup.Margin = new Padding(6);
            button1signup.Name = "button1signup";
            button1signup.Size = new Size(255, 100);
            button1signup.TabIndex = 8;
            button1signup.Text = "SignUp";
            button1signup.UseVisualStyleBackColor = false;
            button1signup.Click += button1signup_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(918, 1017);
            Controls.Add(button1signup);
            Controls.Add(textBox3conpassword);
            Controls.Add(textBox2password);
            Controls.Add(textBox1username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "Signup";
            Text = "Signup";
            Load += Signup_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1username;
        private TextBox textBox2password;
        private TextBox textBox3conpassword;
        private Button button1signup;
    }
}