namespace LMS.GUIForms
{
    partial class Searchbook
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1seachbook = new Button();
            textBox1title = new TextBox();
            author = new TextBox();
            textBox3isbn = new TextBox();
            textBox4availability = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1close
            // 
            label1close.AutoSize = true;
            label1close.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1close.Location = new Point(379, 21);
            label1close.Name = "label1close";
            label1close.Size = new Size(29, 31);
            label1close.TabIndex = 0;
            label1close.Text = "X";
            label1close.Click += label1close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.magnifier;
            pictureBox1.Location = new Point(154, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 206);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 2;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 243);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 3;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 283);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 4;
            label4.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 317);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 5;
            label5.Text = "Availability";
            // 
            // button1seachbook
            // 
            button1seachbook.BackColor = SystemColors.ActiveCaptionText;
            button1seachbook.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1seachbook.ForeColor = SystemColors.Control;
            button1seachbook.Location = new Point(134, 410);
            button1seachbook.Name = "button1seachbook";
            button1seachbook.Size = new Size(145, 43);
            button1seachbook.TabIndex = 6;
            button1seachbook.Text = "Search Book";
            button1seachbook.UseVisualStyleBackColor = false;
            // 
            // textBox1title
            // 
            textBox1title.Location = new Point(171, 204);
            textBox1title.Name = "textBox1title";
            textBox1title.Size = new Size(183, 27);
            textBox1title.TabIndex = 7;
            // 
            // author
            // 
            author.Location = new Point(171, 244);
            author.Name = "author";
            author.Size = new Size(183, 27);
            author.TabIndex = 8;
            // 
            // textBox3isbn
            // 
            textBox3isbn.Location = new Point(171, 284);
            textBox3isbn.Name = "textBox3isbn";
            textBox3isbn.Size = new Size(183, 27);
            textBox3isbn.TabIndex = 9;
            // 
            // textBox4availability
            // 
            textBox4availability.Location = new Point(171, 328);
            textBox4availability.Name = "textBox4availability";
            textBox4availability.Size = new Size(183, 27);
            textBox4availability.TabIndex = 10;
            // 
            // Searchbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(420, 490);
            Controls.Add(textBox4availability);
            Controls.Add(textBox3isbn);
            Controls.Add(author);
            Controls.Add(textBox1title);
            Controls.Add(button1seachbook);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Searchbook";
            Text = "Searchbook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1close;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1seachbook;
        private TextBox textBox1title;
        private TextBox author;
        private TextBox textBox3isbn;
        private TextBox textBox4availability;
    }
}