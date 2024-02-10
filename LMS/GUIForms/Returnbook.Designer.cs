namespace LMS.GUIForms
{
    partial class Returnbook
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
            label1title = new Label();
            label2author = new Label();
            label3isbn = new Label();
            textBox1title = new TextBox();
            textBox2 = new TextBox();
            textBox3isbn = new TextBox();
            button1return = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1close
            // 
            label1close.AutoSize = true;
            label1close.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1close.Location = new Point(907, 18);
            label1close.Margin = new Padding(6, 0, 6, 0);
            label1close.Name = "label1close";
            label1close.Size = new Size(57, 62);
            label1close.TabIndex = 0;
            label1close.Text = "X";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._return;
            pictureBox1.Location = new Point(312, 68);
            pictureBox1.Margin = new Padding(6, 6, 6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1title
            // 
            label1title.AutoSize = true;
            label1title.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1title.Location = new Point(144, 480);
            label1title.Margin = new Padding(6, 0, 6, 0);
            label1title.Name = "label1title";
            label1title.Size = new Size(94, 48);
            label1title.TabIndex = 2;
            label1title.Text = "Title";
            // 
            // label2author
            // 
            label2author.AutoSize = true;
            label2author.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2author.Location = new Point(142, 590);
            label2author.Margin = new Padding(6, 0, 6, 0);
            label2author.Name = "label2author";
            label2author.Size = new Size(139, 48);
            label2author.TabIndex = 3;
            label2author.Text = "Author";
            // 
            // label3isbn
            // 
            label3isbn.AutoSize = true;
            label3isbn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3isbn.Location = new Point(149, 693);
            label3isbn.Margin = new Padding(6, 0, 6, 0);
            label3isbn.Name = "label3isbn";
            label3isbn.Size = new Size(102, 48);
            label3isbn.TabIndex = 4;
            label3isbn.Text = "ISBN";
            // 
            // textBox1title
            // 
            textBox1title.Location = new Point(391, 482);
            textBox1title.Margin = new Padding(6, 6, 6, 6);
            textBox1title.Name = "textBox1title";
            textBox1title.Size = new Size(506, 47);
            textBox1title.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(391, 586);
            textBox2.Margin = new Padding(6, 6, 6, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(506, 47);
            textBox2.TabIndex = 6;
            // 
            // textBox3isbn
            // 
            textBox3isbn.Location = new Point(391, 689);
            textBox3isbn.Margin = new Padding(6, 6, 6, 6);
            textBox3isbn.Name = "textBox3isbn";
            textBox3isbn.Size = new Size(506, 47);
            textBox3isbn.TabIndex = 7;
            // 
            // button1return
            // 
            button1return.BackColor = SystemColors.ActiveCaptionText;
            button1return.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1return.ForeColor = SystemColors.Control;
            button1return.Location = new Point(312, 824);
            button1return.Margin = new Padding(6, 6, 6, 6);
            button1return.Name = "button1return";
            button1return.Size = new Size(357, 92);
            button1return.TabIndex = 8;
            button1return.Text = "Reteun Book";
            button1return.UseVisualStyleBackColor = false;
            // 
            // Returnbook
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(982, 1052);
            Controls.Add(button1return);
            Controls.Add(textBox3isbn);
            Controls.Add(textBox2);
            Controls.Add(textBox1title);
            Controls.Add(label3isbn);
            Controls.Add(label2author);
            Controls.Add(label1title);
            Controls.Add(pictureBox1);
            Controls.Add(label1close);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "Returnbook";
            Text = "Returnbook";
            Load += Returnbook_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1close;
        private PictureBox pictureBox1;
        private Label label1title;
        private Label label2author;
        private Label label3isbn;
        private TextBox textBox1title;
        private TextBox textBox2;
        private TextBox textBox3isbn;
        private Button button1return;
    }
}