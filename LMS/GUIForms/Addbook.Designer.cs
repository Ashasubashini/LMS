namespace LMS.GUIForms
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1title = new TextBox();
            textBox2author = new TextBox();
            textBox3isbn = new TextBox();
            button1addbook = new Button();
            button1back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(341, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(541, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Title";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 180;
            // 
            // Column2
            // 
            Column2.HeaderText = "Author";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 180;
            // 
            // Column3
            // 
            Column3.HeaderText = "ISBN";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 180;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1addbook);
            panel1.Controls.Add(textBox3isbn);
            panel1.Controls.Add(textBox2author);
            panel1.Controls.Add(textBox1title);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 454);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 200);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 245);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 290);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "ISBN";
            // 
            // textBox1title
            // 
            textBox1title.Location = new Point(81, 197);
            textBox1title.Name = "textBox1title";
            textBox1title.Size = new Size(173, 27);
            textBox1title.TabIndex = 3;
            // 
            // textBox2author
            // 
            textBox2author.Location = new Point(81, 238);
            textBox2author.Name = "textBox2author";
            textBox2author.Size = new Size(173, 27);
            textBox2author.TabIndex = 4;
            // 
            // textBox3isbn
            // 
            textBox3isbn.Location = new Point(81, 287);
            textBox3isbn.Name = "textBox3isbn";
            textBox3isbn.Size = new Size(170, 27);
            textBox3isbn.TabIndex = 5;
            // 
            // button1addbook
            // 
            button1addbook.Location = new Point(112, 384);
            button1addbook.Name = "button1addbook";
            button1addbook.Size = new Size(94, 29);
            button1addbook.TabIndex = 6;
            button1addbook.Text = "Add book";
            button1addbook.UseVisualStyleBackColor = true;
            // 
            // button1back
            // 
            button1back.Location = new Point(889, 409);
            button1back.Name = "button1back";
            button1back.Size = new Size(94, 29);
            button1back.TabIndex = 2;
            button1back.Text = "back";
            button1back.UseVisualStyleBackColor = true;
            // 
            // Addbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 450);
            Controls.Add(button1back);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Addbook";
            Text = "Addbook";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel1;
        private Button button1addbook;
        private TextBox textBox3isbn;
        private TextBox textBox2author;
        private TextBox textBox1title;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1back;
    }
}