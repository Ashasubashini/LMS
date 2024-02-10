namespace Final
{
    partial class Addbook
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
            label2author = new Label();
            label3isbn = new Label();
            label1title = new Label();
            textBox1Title = new TextBox();
            textBox2author = new TextBox();
            textBox3isbn = new TextBox();
            button1addbook = new Button();
            Availability = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1Close = new Label();
            ((System.ComponentModel.ISupportInitialize)Availability).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2author
            // 
            label2author.AutoSize = true;
            label2author.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2author.Location = new Point(26, 529);
            label2author.Margin = new Padding(6, 0, 6, 0);
            label2author.Name = "label2author";
            label2author.Size = new Size(139, 48);
            label2author.TabIndex = 1;
            label2author.Text = "Author";
            // 
            // label3isbn
            // 
            label3isbn.AutoSize = true;
            label3isbn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3isbn.Location = new Point(26, 652);
            label3isbn.Margin = new Padding(6, 0, 6, 0);
            label3isbn.Name = "label3isbn";
            label3isbn.Size = new Size(102, 48);
            label3isbn.TabIndex = 2;
            label3isbn.Text = "ISBN";
            label3isbn.Click += label3isbn_Click;
            // 
            // label1title
            // 
            label1title.AutoSize = true;
            label1title.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1title.Location = new Point(26, 408);
            label1title.Margin = new Padding(6, 0, 6, 0);
            label1title.Name = "label1title";
            label1title.Size = new Size(94, 48);
            label1title.TabIndex = 3;
            label1title.Text = "Title";
            // 
            // textBox1Title
            // 
            textBox1Title.Location = new Point(227, 404);
            textBox1Title.Margin = new Padding(6, 6, 6, 6);
            textBox1Title.Name = "textBox1Title";
            textBox1Title.Size = new Size(416, 47);
            textBox1Title.TabIndex = 4;
            textBox1Title.TextChanged += textBox1Title_TextChanged;
            // 
            // textBox2author
            // 
            textBox2author.Location = new Point(230, 525);
            textBox2author.Margin = new Padding(6, 6, 6, 6);
            textBox2author.Name = "textBox2author";
            textBox2author.Size = new Size(414, 47);
            textBox2author.TabIndex = 5;
            // 
            // textBox3isbn
            // 
            textBox3isbn.Location = new Point(230, 648);
            textBox3isbn.Margin = new Padding(6, 6, 6, 6);
            textBox3isbn.Name = "textBox3isbn";
            textBox3isbn.Size = new Size(414, 47);
            textBox3isbn.TabIndex = 6;
            // 
            // button1addbook
            // 
            button1addbook.BackColor = SystemColors.ActiveCaptionText;
            button1addbook.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1addbook.ForeColor = SystemColors.Control;
            button1addbook.Location = new Point(202, 758);
            button1addbook.Margin = new Padding(6, 6, 6, 6);
            button1addbook.Name = "button1addbook";
            button1addbook.Size = new Size(289, 90);
            button1addbook.TabIndex = 7;
            button1addbook.Text = "Add Book";
            button1addbook.UseVisualStyleBackColor = false;
            button1addbook.Click += button1addbook_Click;
            // 
            // Availability
            // 
            Availability.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Availability.Columns.AddRange(new DataGridViewColumn[] { Title, Author, Column1 });
            Availability.Location = new Point(795, 146);
            Availability.Margin = new Padding(6, 6, 6, 6);
            Availability.Name = "Availability";
            Availability.RowHeadersWidth = 51;
            Availability.Size = new Size(1186, 248);
            Availability.TabIndex = 8;
            // 
            // Title
            // 
            Title.HeaderText = "Titel";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.Width = 175;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.Width = 175;
            // 
            // Column1
            // 
            Column1.HeaderText = "ISBN";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 175;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2author);
            panel1.Controls.Add(button1addbook);
            panel1.Controls.Add(textBox2author);
            panel1.Controls.Add(textBox3isbn);
            panel1.Controls.Add(label1title);
            panel1.Controls.Add(label3isbn);
            panel1.Controls.Add(textBox1Title);
            panel1.Location = new Point(0, -2);
            panel1.Margin = new Padding(6, 6, 6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 931);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = LMS.Properties.Resources.add__1_;
            pictureBox1.Location = new Point(181, 53);
            pictureBox1.Margin = new Padding(6, 6, 6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1Close
            // 
            label1Close.AutoSize = true;
            label1Close.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1Close.Location = new Point(1964, 18);
            label1Close.Margin = new Padding(6, 0, 6, 0);
            label1Close.Name = "label1Close";
            label1Close.Size = new Size(68, 74);
            label1Close.TabIndex = 10;
            label1Close.Text = "X";
            // 
            // Addbook
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = LMS.Properties.Resources._388371;
            ClientSize = new Size(2063, 922);
            Controls.Add(label1Close);
            Controls.Add(panel1);
            Controls.Add(Availability);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "Addbook";
            Text = "Addbook";
            Load += Addbook_Load;
            ((System.ComponentModel.ISupportInitialize)Availability).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2author;
        private Label label3isbn;
        private Label label1title;
        private TextBox textBox1Title;
        private TextBox textBox2author;
        private TextBox textBox3isbn;
        private Button button1addbook;
        private DataGridView Availability;
        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Column1;
        private Label label1Close;
    }
}