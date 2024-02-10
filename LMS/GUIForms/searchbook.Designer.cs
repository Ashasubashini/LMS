namespace Final
{
    partial class searchbook
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
            label1 = new Label();
            panel1 = new Panel();
            button1borrow = new Button();
            textBox4availability = new TextBox();
            textBox3Author = new TextBox();
            textBox2ISBN = new TextBox();
            textBox1Title = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1back = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(407, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 38);
            label1.TabIndex = 0;
            label1.Text = "X";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button1back);
            panel1.Controls.Add(button1borrow);
            panel1.Controls.Add(textBox4availability);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox3Author);
            panel1.Controls.Add(textBox2ISBN);
            panel1.Controls.Add(textBox1Title);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 506);
            panel1.TabIndex = 1;
            // 
            // button1borrow
            // 
            button1borrow.BackColor = SystemColors.ActiveCaptionText;
            button1borrow.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1borrow.ForeColor = SystemColors.Control;
            button1borrow.Location = new Point(128, 365);
            button1borrow.Name = "button1borrow";
            button1borrow.Size = new Size(152, 43);
            button1borrow.TabIndex = 10;
            button1borrow.Text = "Search Book";
            button1borrow.UseVisualStyleBackColor = false;
            button1borrow.Click += button1borrow_Click;
            // 
            // textBox4availability
            // 
            textBox4availability.Location = new Point(176, 314);
            textBox4availability.Name = "textBox4availability";
            textBox4availability.Size = new Size(223, 27);
            textBox4availability.TabIndex = 9;
            // 
            // textBox3Author
            // 
            textBox3Author.Location = new Point(176, 267);
            textBox3Author.Name = "textBox3Author";
            textBox3Author.Size = new Size(223, 27);
            textBox3Author.TabIndex = 8;
            // 
            // textBox2ISBN
            // 
            textBox2ISBN.Location = new Point(176, 225);
            textBox2ISBN.Name = "textBox2ISBN";
            textBox2ISBN.Size = new Size(223, 27);
            textBox2ISBN.TabIndex = 7;
            // 
            // textBox1Title
            // 
            textBox1Title.Location = new Point(176, 185);
            textBox1Title.Name = "textBox1Title";
            textBox1Title.Size = new Size(223, 27);
            textBox1Title.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 229);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 5;
            label3.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 314);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 4;
            label5.Text = "Availability";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 271);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 3;
            label4.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 185);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = LMS.Properties.Resources.magnifier1;
            pictureBox1.Location = new Point(155, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1back
            // 
            button1back.BackColor = SystemColors.ActiveCaptionText;
            button1back.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1back.ForeColor = SystemColors.Control;
            button1back.Location = new Point(342, 458);
            button1back.Name = "button1back";
            button1back.Size = new Size(94, 39);
            button1back.TabIndex = 11;
            button1back.Text = "Back";
            button1back.UseVisualStyleBackColor = false;
            // 
            // searchbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 509);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "searchbook";
            Text = "searchbook";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox textBox4availability;
        private TextBox textBox3Author;
        private TextBox textBox2ISBN;
        private TextBox textBox1Title;
        private Button button1borrow;
        private Button button1back;
    }
}