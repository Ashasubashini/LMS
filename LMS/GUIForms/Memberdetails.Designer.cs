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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1remove = new Button();
            textBox2Name = new TextBox();
            textBox1ID = new TextBox();
            label2name = new Label();
            label1ID = new Label();
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
            label1close.Location = new Point(2193, 18);
            label1close.Margin = new Padding(6, 0, 6, 0);
            label1close.Name = "label1close";
            label1close.Size = new Size(57, 62);
            label1close.TabIndex = 0;
            label1close.Text = "X";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(616, 117);
            dataGridView1.Margin = new Padding(6, 6, 6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1638, 539);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.group_chat1;
            pictureBox1.Location = new Point(123, 23);
            pictureBox1.Margin = new Padding(6, 6, 6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
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
            panel1.Location = new Point(-2, 2);
            panel1.Margin = new Padding(6, 6, 6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(606, 1019);
            panel1.TabIndex = 3;
            // 
            // button1remove
            // 
            button1remove.BackColor = SystemColors.ActiveCaptionText;
            button1remove.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1remove.ForeColor = SystemColors.Control;
            button1remove.Location = new Point(178, 681);
            button1remove.Margin = new Padding(6, 6, 6, 6);
            button1remove.Name = "button1remove";
            button1remove.Size = new Size(255, 98);
            button1remove.TabIndex = 7;
            button1remove.Text = "Remove";
            button1remove.UseVisualStyleBackColor = false;
            // 
            // textBox2Name
            // 
            textBox2Name.Location = new Point(266, 580);
            textBox2Name.Margin = new Padding(6, 6, 6, 6);
            textBox2Name.Name = "textBox2Name";
            textBox2Name.Size = new Size(308, 47);
            textBox2Name.TabIndex = 6;
            // 
            // textBox1ID
            // 
            textBox1ID.Location = new Point(266, 463);
            textBox1ID.Margin = new Padding(6, 6, 6, 6);
            textBox1ID.Name = "textBox1ID";
            textBox1ID.Size = new Size(308, 47);
            textBox1ID.TabIndex = 5;
            // 
            // label2name
            // 
            label2name.AutoSize = true;
            label2name.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2name.Location = new Point(6, 578);
            label2name.Margin = new Padding(6, 0, 6, 0);
            label2name.Name = "label2name";
            label2name.Size = new Size(119, 48);
            label2name.TabIndex = 4;
            label2name.Text = "Name";
            // 
            // label1ID
            // 
            label1ID.AutoSize = true;
            label1ID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1ID.Location = new Point(6, 467);
            label1ID.Margin = new Padding(6, 0, 6, 0);
            label1ID.Name = "label1ID";
            label1ID.Size = new Size(209, 48);
            label1ID.TabIndex = 3;
            label1ID.Text = "Member ID";
            // 
            // Memberdetails
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources._388371;
            ClientSize = new Size(2280, 1021);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1close);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "Memberdetails";
            Text = "Memberdetails";
            Load += Memberdetails_Load;
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