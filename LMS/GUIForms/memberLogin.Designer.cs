namespace Final
{
    partial class memberLogin
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
            loginmember = new Button();
            username = new Label();
            textBox2username = new TextBox();
            label3close = new Label();
            label1password = new Label();
            textBox3password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1memberID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = LMS.Properties.Resources.user1;
            pictureBox1.Location = new Point(119, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // loginmember
            // 
            loginmember.BackColor = SystemColors.ActiveCaptionText;
            loginmember.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginmember.ForeColor = SystemColors.Control;
            loginmember.Location = new Point(119, 352);
            loginmember.Name = "loginmember";
            loginmember.Size = new Size(125, 48);
            loginmember.TabIndex = 1;
            loginmember.Text = "Log In";
            loginmember.UseVisualStyleBackColor = false;
            loginmember.Click += button1_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username.Location = new Point(22, 187);
            username.Name = "username";
            username.Size = new Size(105, 25);
            username.TabIndex = 2;
            username.Text = "User Name";
            // 
            // textBox2username
            // 
            textBox2username.Location = new Point(145, 188);
            textBox2username.Name = "textBox2username";
            textBox2username.Size = new Size(190, 27);
            textBox2username.TabIndex = 5;
            // 
            // label3close
            // 
            label3close.Location = new Point(0, 0);
            label3close.Name = "label3close";
            label3close.Size = new Size(100, 23);
            label3close.TabIndex = 9;
            // 
            // label1password
            // 
            label1password.AutoSize = true;
            label1password.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1password.Location = new Point(22, 287);
            label1password.Name = "label1password";
            label1password.Size = new Size(92, 25);
            label1password.TabIndex = 7;
            label1password.Text = "Password";
            // 
            // textBox3password
            // 
            textBox3password.Location = new Point(145, 288);
            textBox3password.Name = "textBox3password";
            textBox3password.Size = new Size(190, 27);
            textBox3password.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 12);
            label1.Name = "label1";
            label1.Size = new Size(35, 38);
            label1.TabIndex = 10;
            label1.Text = "X";
            label1.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 236);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 11;
            label2.Text = "Member ID";
            // 
            // textBox1memberID
            // 
            textBox1memberID.Location = new Point(145, 237);
            textBox1memberID.Name = "textBox1memberID";
            textBox1memberID.Size = new Size(190, 27);
            textBox1memberID.TabIndex = 12;
            // 
            // memberLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(386, 450);
            Controls.Add(textBox1memberID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3password);
            Controls.Add(label1password);
            Controls.Add(label3close);
            Controls.Add(textBox2username);
            Controls.Add(username);
            Controls.Add(loginmember);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "memberLogin";
            Text = "memberLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button loginmember;
        private Label username;
        private TextBox textBox2username;
        private Label label3close;
        private Label label1password;
        private TextBox textBox3password;
        private Label label1;
        private Label label2;
        private TextBox textBox1memberID;
    }
}