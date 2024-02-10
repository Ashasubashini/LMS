namespace LMS.GUIForms
{
    partial class Issuedbook
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2author = new Label();
            label3isbn = new Label();
            label4availavility = new Label();
            textBox1title = new TextBox();
            textBox2author = new TextBox();
            textBox3isbn = new TextBox();
            textBox4availability = new TextBox();
            button1issuebook = new Button();
            button1back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1close
            // 
            label1close.AutoSize = true;
            label1close.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1close.Location = new Point(414, 9);
            label1close.Name = "label1close";
            label1close.Size = new Size(29, 31);
            label1close.TabIndex = 0;
            label1close.Text = "X";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.reading_book;
            pictureBox1.Location = new Point(135, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 252);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // label2author
            // 
            label2author.AutoSize = true;
            label2author.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2author.Location = new Point(56, 300);
            label2author.Name = "label2author";
            label2author.Size = new Size(72, 25);
            label2author.TabIndex = 3;
            label2author.Text = "Author";
            // 
            // label3isbn
            // 
            label3isbn.AutoSize = true;
            label3isbn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3isbn.Location = new Point(56, 353);
            label3isbn.Name = "label3isbn";
            label3isbn.Size = new Size(54, 25);
            label3isbn.TabIndex = 4;
            label3isbn.Text = "ISBN";
            // 
            // label4availavility
            // 
            label4availavility.AutoSize = true;
            label4availavility.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4availavility.Location = new Point(56, 397);
            label4availavility.Name = "label4availavility";
            label4availavility.Size = new Size(108, 25);
            label4availavility.TabIndex = 5;
            label4availavility.Text = "Availability";
            // 
            // textBox1title
            // 
            textBox1title.Location = new Point(194, 250);
            textBox1title.Name = "textBox1title";
            textBox1title.Size = new Size(210, 27);
            textBox1title.TabIndex = 6;
            // 
            // textBox2author
            // 
            textBox2author.Location = new Point(194, 301);
            textBox2author.Name = "textBox2author";
            textBox2author.Size = new Size(210, 27);
            textBox2author.TabIndex = 7;
            // 
            // textBox3isbn
            // 
            textBox3isbn.Location = new Point(194, 351);
            textBox3isbn.Name = "textBox3isbn";
            textBox3isbn.Size = new Size(210, 27);
            textBox3isbn.TabIndex = 8;
            // 
            // textBox4availability
            // 
            textBox4availability.Location = new Point(194, 398);
            textBox4availability.Name = "textBox4availability";
            textBox4availability.Size = new Size(210, 27);
            textBox4availability.TabIndex = 9;
            // 
            // button1issuebook
            // 
            button1issuebook.BackColor = SystemColors.ActiveCaptionText;
            button1issuebook.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1issuebook.ForeColor = SystemColors.Control;
            button1issuebook.Location = new Point(135, 456);
            button1issuebook.Name = "button1issuebook";
            button1issuebook.Size = new Size(147, 44);
            button1issuebook.TabIndex = 10;
            button1issuebook.Text = "Issue Book";
            button1issuebook.UseVisualStyleBackColor = false;
            // 
            // button1back
            // 
            button1back.BackColor = SystemColors.ActiveCaptionText;
            button1back.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1back.ForeColor = SystemColors.Control;
            button1back.Location = new Point(353, 493);
            button1back.Name = "button1back";
            button1back.Size = new Size(94, 35);
            button1back.TabIndex = 11;
            button1back.Text = "Back";
            button1back.UseVisualStyleBackColor = false;
            // 
            // Issuedbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(459, 540);
            Controls.Add(button1back);
            Controls.Add(button1issuebook);
            Controls.Add(textBox4availability);
            Controls.Add(textBox3isbn);
            Controls.Add(textBox2author);
            Controls.Add(textBox1title);
            Controls.Add(label4availavility);
            Controls.Add(label3isbn);
            Controls.Add(label2author);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label1close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Issuedbook";
            Text = "Issuedbook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1close;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2author;
        private Label label3isbn;
        private Label label4availavility;
        private TextBox textBox1title;
        private TextBox textBox2author;
        private TextBox textBox3isbn;
        private TextBox textBox4availability;
        private Button button1issuebook;
        private Button button1back;
    }
}