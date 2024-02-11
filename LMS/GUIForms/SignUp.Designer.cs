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
            pictureBox1.Location = new Point(148, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(391, 22);
            label1.Name = "label1";
            label1.Size = new Size(29, 31);
            label1.TabIndex = 1;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 218);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 260);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 295);
            label4.Name = "label4";
            label4.Size = new Size(175, 25);
            label4.TabIndex = 4;
            label4.Text = "Confirme Password";
            // 
            // textBox1username
            // 
            textBox1username.Location = new Point(193, 219);
            textBox1username.Name = "textBox1username";
            textBox1username.Size = new Size(208, 27);
            textBox1username.TabIndex = 5;
            // 
            // textBox2password
            // 
            textBox2password.Location = new Point(193, 258);
            textBox2password.Name = "textBox2password";
            textBox2password.Size = new Size(208, 27);
            textBox2password.TabIndex = 6;
            // 
            // textBox3conpassword
            // 
            textBox3conpassword.Location = new Point(193, 305);
            textBox3conpassword.Name = "textBox3conpassword";
            textBox3conpassword.Size = new Size(208, 27);
            textBox3conpassword.TabIndex = 7;
            // 
            // button1signup
            // 
            button1signup.BackColor = SystemColors.ActiveCaptionText;
            button1signup.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1signup.ForeColor = SystemColors.Control;
            button1signup.Location = new Point(153, 371);
            button1signup.Name = "button1signup";
            button1signup.Size = new Size(120, 49);
            button1signup.TabIndex = 8;
            button1signup.Text = "SignUp";
            button1signup.UseVisualStyleBackColor = false;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(432, 496);
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
            Name = "Signup";
            Text = "Signup";
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