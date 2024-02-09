namespace LMS.GUIForms
{
    partial class Memberdetails
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
            pictureBox1 = new PictureBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label1ID = new Label();
            label2name = new Label();
            textBox1ID = new TextBox();
            textBox2Name = new TextBox();
            button1remove = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1close
            // 
            label1close.AutoSize = true;
            label1close.BackColor = Color.Transparent;
            label1close.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1close.Location = new Point(1032, 9);
            label1close.Name = "label1close";
            label1close.Size = new Size(29, 31);
            label1close.TabIndex = 0;
            label1close.Text = "X";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(290, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(771, 263);
            dataGridView1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.group_chat1;
            pictureBox1.Location = new Point(58, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Member ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 180;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 180;
            // 
            // Column3
            // 
            Column3.HeaderText = "Email";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 180;
            // 
            // Column4
            // 
            Column4.HeaderText = "Contact Number";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 180;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button1remove);
            panel1.Controls.Add(textBox2Name);
            panel1.Controls.Add(textBox1ID);
            panel1.Controls.Add(label2name);
            panel1.Controls.Add(label1ID);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 497);
            panel1.TabIndex = 3;
            // 
            // label1ID
            // 
            label1ID.AutoSize = true;
            label1ID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1ID.Location = new Point(3, 228);
            label1ID.Name = "label1ID";
            label1ID.Size = new Size(107, 25);
            label1ID.TabIndex = 3;
            label1ID.Text = "Member ID";
            // 
            // label2name
            // 
            label2name.AutoSize = true;
            label2name.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2name.Location = new Point(3, 282);
            label2name.Name = "label2name";
            label2name.Size = new Size(62, 25);
            label2name.TabIndex = 4;
            label2name.Text = "Name";
            // 
            // textBox1ID
            // 
            textBox1ID.Location = new Point(125, 226);
            textBox1ID.Name = "textBox1ID";
            textBox1ID.Size = new Size(147, 27);
            textBox1ID.TabIndex = 5;
            // 
            // textBox2Name
            // 
            textBox2Name.Location = new Point(125, 283);
            textBox2Name.Name = "textBox2Name";
            textBox2Name.Size = new Size(147, 27);
            textBox2Name.TabIndex = 6;
            // 
            // button1remove
            // 
            button1remove.BackColor = SystemColors.ActiveCaptionText;
            button1remove.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1remove.ForeColor = SystemColors.Control;
            button1remove.Location = new Point(84, 332);
            button1remove.Name = "button1remove";
            button1remove.Size = new Size(120, 48);
            button1remove.TabIndex = 7;
            button1remove.Text = "Remove";
            button1remove.UseVisualStyleBackColor = false;
            button1remove.Click += button1remove_Click;
            // 
            // Memberdetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources._388371;
            ClientSize = new Size(1073, 498);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Memberdetails";
            Text = "Memberdetails";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1close;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox textBox2Name;
        private TextBox textBox1ID;
        private Label label2name;
        private Label label1ID;
        private Button button1remove;
    }
}