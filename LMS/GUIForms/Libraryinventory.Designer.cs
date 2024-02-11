namespace LMS.GUIForms
{
    partial class Libraryinventory
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label4title = new Label();
            textBox3isbn = new TextBox();
            textBox2Author = new TextBox();
            textBox1title = new TextBox();
            button1remove = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1close
            // 
            label1close.AutoSize = true;
            label1close.BackColor = Color.Transparent;
            label1close.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1close.ForeColor = SystemColors.ActiveCaptionText;
            label1close.Location = new Point(898, 9);
            label1close.Name = "label1close";
            label1close.Size = new Size(29, 31);
            label1close.TabIndex = 0;
            label1close.Text = "X";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, column2, Column3 });
            dataGridView1.Location = new Point(336, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(591, 188);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Title";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 180;
            // 
            // column2
            // 
            column2.HeaderText = "Author";
            column2.MinimumWidth = 6;
            column2.Name = "column2";
            column2.Width = 180;
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
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label4title);
            panel1.Controls.Add(textBox3isbn);
            panel1.Controls.Add(textBox2Author);
            panel1.Controls.Add(textBox1title);
            panel1.Controls.Add(button1remove);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 501);
            panel1.TabIndex = 2;
            // 
            // label4title
            // 
            label4title.AutoSize = true;
            label4title.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4title.Location = new Point(32, 216);
            label4title.Name = "label4title";
            label4title.Size = new Size(50, 25);
            label4title.TabIndex = 8;
            label4title.Text = "Title";
            // 
            // textBox3isbn
            // 
            textBox3isbn.Location = new Point(111, 322);
            textBox3isbn.Name = "textBox3isbn";
            textBox3isbn.Size = new Size(190, 27);
            textBox3isbn.TabIndex = 7;
            // 
            // textBox2Author
            // 
            textBox2Author.Location = new Point(111, 268);
            textBox2Author.Name = "textBox2Author";
            textBox2Author.Size = new Size(190, 27);
            textBox2Author.TabIndex = 6;
            // 
            // textBox1title
            // 
            textBox1title.Location = new Point(111, 218);
            textBox1title.Name = "textBox1title";
            textBox1title.Size = new Size(190, 27);
            textBox1title.TabIndex = 5;
            // 
            // button1remove
            // 
            button1remove.BackColor = SystemColors.ActiveCaptionText;
            button1remove.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1remove.ForeColor = SystemColors.Control;
            button1remove.Location = new Point(90, 384);
            button1remove.Name = "button1remove";
            button1remove.Size = new Size(125, 40);
            button1remove.TabIndex = 4;
            button1remove.Text = "Remove";
            button1remove.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 322);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 3;
            label3.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 268);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 2;
            label2.Text = "Author";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 212);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.study;
            pictureBox1.Location = new Point(90, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1back
            // 
            button1back.Location = new Point(812, 441);
            button1back.Name = "button1back";
            button1back.Size = new Size(94, 29);
            button1back.TabIndex = 3;
            button1back.Text = "Back";
            button1back.UseVisualStyleBackColor = true;
            // 
            // Libraryinventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._388371;
            ClientSize = new Size(939, 501);
            Controls.Add(button1back);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Libraryinventory";
            Text = "Libraryinventory";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1close;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox3isbn;
        private TextBox textBox2Author;
        private TextBox textBox1title;
        private Button button1remove;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4title;
        private Button button1back;
    }
}