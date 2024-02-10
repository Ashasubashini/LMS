namespace LMS.GUIForms
{
    partial class Addmember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addmember));
            label1close = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button1addmember = new Button();
            textBox4contactnumber = new TextBox();
            textBox3email = new TextBox();
            textBox2name = new TextBox();
            textBox1memberid = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
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
            label1close.Location = new Point(1932, 18);
            label1close.Margin = new Padding(6, 0, 6, 0);
            label1close.Name = "label1close";
            label1close.Size = new Size(57, 62);
            label1close.TabIndex = 0;
            label1close.Text = "X";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(740, 164);
            dataGridView1.Margin = new Padding(6, 6, 6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1254, 150);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 180;
            // 
            // Column2
            // 
            Column2.HeaderText = "Email";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 180;
            // 
            // Column3
            // 
            Column3.HeaderText = "Contact number";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 180;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button1addmember);
            panel1.Controls.Add(textBox4contactnumber);
            panel1.Controls.Add(textBox3email);
            panel1.Controls.Add(textBox2name);
            panel1.Controls.Add(textBox1memberid);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(4, -2);
            panel1.Margin = new Padding(6, 6, 6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 1023);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // button1addmember
            // 
            button1addmember.BackColor = SystemColors.ActiveCaptionText;
            button1addmember.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1addmember.ForeColor = SystemColors.Control;
            button1addmember.Location = new Point(196, 783);
            button1addmember.Margin = new Padding(6, 6, 6, 6);
            button1addmember.Name = "button1addmember";
            button1addmember.Size = new Size(314, 92);
            button1addmember.TabIndex = 9;
            button1addmember.Text = "Add Member";
            button1addmember.UseVisualStyleBackColor = false;
            // 
            // textBox4contactnumber
            // 
            textBox4contactnumber.Location = new Point(342, 672);
            textBox4contactnumber.Margin = new Padding(6, 6, 6, 6);
            textBox4contactnumber.Name = "textBox4contactnumber";
            textBox4contactnumber.Size = new Size(363, 47);
            textBox4contactnumber.TabIndex = 8;
            // 
            // textBox3email
            // 
            textBox3email.Location = new Point(342, 582);
            textBox3email.Margin = new Padding(6, 6, 6, 6);
            textBox3email.Name = "textBox3email";
            textBox3email.Size = new Size(363, 47);
            textBox3email.TabIndex = 7;
            // 
            // textBox2name
            // 
            textBox2name.Location = new Point(342, 484);
            textBox2name.Margin = new Padding(6, 6, 6, 6);
            textBox2name.Name = "textBox2name";
            textBox2name.Size = new Size(363, 47);
            textBox2name.TabIndex = 6;
            // 
            // textBox1memberid
            // 
            textBox1memberid.Location = new Point(342, 394);
            textBox1memberid.Margin = new Padding(6, 6, 6, 6);
            textBox1memberid.Name = "textBox1memberid";
            textBox1memberid.Size = new Size(363, 47);
            textBox1memberid.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 398);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(209, 48);
            label4.TabIndex = 4;
            label4.Text = "Member ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 670);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(298, 48);
            label3.TabIndex = 3;
            label3.Text = "Contact Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 580);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 48);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 482);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 48);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.contact2;
            pictureBox1.Location = new Point(223, 59);
            pictureBox1.Margin = new Padding(6, 6, 6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Addmember
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(2019, 1011);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1close);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "Addmember";
            Text = "Addmember";
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
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1addmember;
        private TextBox textBox4contactnumber;
        private TextBox textBox3email;
        private TextBox textBox2name;
        private TextBox textBox1memberid;
    }
}