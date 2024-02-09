namespace LMS.GUIForms
{
    partial class LoginInterface
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
            button1memberlogin = new Button();
            button2librarianlogin = new Button();
            button3signup = new Button();
            label1close = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1memberlogin
            // 
            button1memberlogin.BackColor = SystemColors.ActiveCaptionText;
            button1memberlogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1memberlogin.ForeColor = SystemColors.Control;
            button1memberlogin.Location = new Point(279, 197);
            button1memberlogin.Name = "button1memberlogin";
            button1memberlogin.Size = new Size(195, 43);
            button1memberlogin.TabIndex = 0;
            button1memberlogin.Text = "Member login";
            button1memberlogin.UseVisualStyleBackColor = false;
            button1memberlogin.Click += button1memberlogin_Click;
            // 
            // button2librarianlogin
            // 
            button2librarianlogin.BackColor = SystemColors.ActiveCaptionText;
            button2librarianlogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2librarianlogin.ForeColor = SystemColors.Control;
            button2librarianlogin.Location = new Point(279, 257);
            button2librarianlogin.Name = "button2librarianlogin";
            button2librarianlogin.Size = new Size(195, 40);
            button2librarianlogin.TabIndex = 1;
            button2librarianlogin.Text = "Librarian login";
            button2librarianlogin.UseVisualStyleBackColor = false;
            button2librarianlogin.Click += button2librarianlogin_Click;
            // 
            // button3signup
            // 
            button3signup.BackColor = Color.Lavender;
            button3signup.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3signup.Location = new Point(459, 304);
            button3signup.Name = "button3signup";
            button3signup.Size = new Size(101, 38);
            button3signup.TabIndex = 2;
            button3signup.Text = "Sign up";
            button3signup.UseVisualStyleBackColor = false;
            button3signup.Click += button3signup_Click;
            // 
            // label1close
            // 
            label1close.AutoSize = true;
            label1close.BackColor = Color.Transparent;
            label1close.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1close.Location = new Point(759, 9);
            label1close.Name = "label1close";
            label1close.Size = new Size(29, 31);
            label1close.TabIndex = 3;
            label1close.Text = "X";
            label1close.Click += label1close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.old_library_building__1_;
            pictureBox1.Location = new Point(302, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 137);
            label1.Name = "label1";
            label1.Size = new Size(355, 28);
            label1.TabIndex = 5;
            label1.Text = "WELCOME TO THE LIBRARY SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(242, 319);
            label2.Name = "label2";
            label2.Size = new Size(196, 23);
            label2.TabIndex = 6;
            label2.Text = "Don't have an Account?";
            // 
            // LoginInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._38828;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label1close);
            Controls.Add(button3signup);
            Controls.Add(button2librarianlogin);
            Controls.Add(button1memberlogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginInterface";
            Text = "LoginInterface";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1memberlogin;
        private Button button2librarianlogin;
        private Button button3signup;
        private Label label1close;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}