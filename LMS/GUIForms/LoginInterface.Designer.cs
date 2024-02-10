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
            button1memberlogin.Location = new Point(593, 404);
            button1memberlogin.Margin = new Padding(6, 6, 6, 6);
            button1memberlogin.Name = "button1memberlogin";
            button1memberlogin.Size = new Size(414, 88);
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
            button2librarianlogin.Location = new Point(593, 527);
            button2librarianlogin.Margin = new Padding(6, 6, 6, 6);
            button2librarianlogin.Name = "button2librarianlogin";
            button2librarianlogin.Size = new Size(414, 82);
            button2librarianlogin.TabIndex = 1;
            button2librarianlogin.Text = "Librarian login";
            button2librarianlogin.UseVisualStyleBackColor = false;
            button2librarianlogin.Click += button2librarianlogin_Click;
            // 
            // button3signup
            // 
            button3signup.BackColor = Color.Lavender;
            button3signup.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3signup.Location = new Point(975, 623);
            button3signup.Margin = new Padding(6, 6, 6, 6);
            button3signup.Name = "button3signup";
            button3signup.Size = new Size(215, 78);
            button3signup.TabIndex = 2;
            button3signup.Text = "Sign up";
            button3signup.UseVisualStyleBackColor = false;
            button3signup.Click += button3signup_Click;
            // 
            // label1close
            // 
            label1close.AutoSize = true;
            label1close.Location = new Point(1636, 18);
            label1close.Margin = new Padding(6, 0, 6, 0);
            label1close.Name = "label1close";
            label1close.Size = new Size(36, 41);
            label1close.TabIndex = 3;
            label1close.Text = "X";
            label1close.Click += label1close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.old_library_building__1_;
            pictureBox1.Location = new Point(642, 18);
            pictureBox1.Margin = new Padding(6, 6, 6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(436, 281);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(701, 54);
            label1.TabIndex = 5;
            label1.Text = "WELCOME TO THE LIBRARY SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(514, 654);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(394, 46);
            label2.TabIndex = 6;
            label2.Text = "Don't have an Account?";
            // 
            // LoginInterface
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._38828;
            ClientSize = new Size(1700, 922);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label1close);
            Controls.Add(button3signup);
            Controls.Add(button2librarianlogin);
            Controls.Add(button1memberlogin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "LoginInterface";
            Text = "LoginInterface";
            Load += LoginInterface_Load;
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