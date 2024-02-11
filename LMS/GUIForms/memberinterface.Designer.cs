namespace LMS.GUIForms
{
    partial class MemberInterface
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2logout = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            button1searchbook = new Button();
            button2borrownbook = new Button();
            button3returnbook = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2logout);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 453);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profile_user;
            pictureBox1.Location = new Point(85, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 163);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 1;
            label1.Text = "WELCOME USER!";
            // 
            // pictureBox2logout
            // 
            pictureBox2logout.Image = Properties.Resources.power_button;
            pictureBox2logout.Location = new Point(125, 347);
            pictureBox2logout.Name = "pictureBox2logout";
            pictureBox2logout.Size = new Size(43, 62);
            pictureBox2logout.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2logout.TabIndex = 2;
            pictureBox2logout.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(125, 416);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "logout";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.book__1_;
            pictureBox2.Location = new Point(349, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(138, 111);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.open_book2;
            pictureBox3.Location = new Point(581, 46);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(153, 111);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.return1;
            pictureBox4.Location = new Point(475, 248);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(140, 107);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // button1searchbook
            // 
            button1searchbook.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1searchbook.Location = new Point(369, 159);
            button1searchbook.Name = "button1searchbook";
            button1searchbook.Size = new Size(94, 29);
            button1searchbook.TabIndex = 4;
            button1searchbook.Text = "Search book";
            button1searchbook.UseVisualStyleBackColor = true;
            // 
            // button2borrownbook
            // 
            button2borrownbook.Location = new Point(604, 159);
            button2borrownbook.Name = "button2borrownbook";
            button2borrownbook.Size = new Size(94, 29);
            button2borrownbook.TabIndex = 5;
            button2borrownbook.Text = "Borrow Book";
            button2borrownbook.UseVisualStyleBackColor = true;
            // 
            // button3returnbook
            // 
            button3returnbook.Location = new Point(496, 361);
            button3returnbook.Name = "button3returnbook";
            button3returnbook.Size = new Size(119, 29);
            button3returnbook.TabIndex = 6;
            button3returnbook.Text = "Return Book";
            button3returnbook.UseVisualStyleBackColor = true;
            // 
            // MemberInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._38828;
            ClientSize = new Size(800, 450);
            Controls.Add(button3returnbook);
            Controls.Add(button2borrownbook);
            Controls.Add(button1searchbook);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MemberInterface";
            Text = "MemberInterface";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2logout;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button button1searchbook;
        private Button button2borrownbook;
        private Button button3returnbook;
    }
}