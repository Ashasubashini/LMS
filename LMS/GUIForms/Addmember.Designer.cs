﻿namespace LMS.GUIForms
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
            panel1 = new Panel();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1memberid = new TextBox();
            textBox2name = new TextBox();
            textBox3email = new TextBox();
            textBox4contactnumber = new TextBox();
            button1addmember = new Button();
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
            label1close.Location = new Point(909, 9);
            label1close.Name = "label1close";
            label1close.Size = new Size(29, 31);
            label1close.TabIndex = 0;
            label1close.Text = "X";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(348, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(590, 73);
            dataGridView1.TabIndex = 1;
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
            panel1.Location = new Point(2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 499);
            panel1.TabIndex = 2;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.contact2;
            pictureBox1.Location = new Point(105, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 235);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 283);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 327);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 3;
            label3.Text = "Contact Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 194);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 4;
            label4.Text = "Member ID";
            // 
            // textBox1memberid
            // 
            textBox1memberid.Location = new Point(161, 192);
            textBox1memberid.Name = "textBox1memberid";
            textBox1memberid.Size = new Size(173, 27);
            textBox1memberid.TabIndex = 5;
            // 
            // textBox2name
            // 
            textBox2name.Location = new Point(161, 236);
            textBox2name.Name = "textBox2name";
            textBox2name.Size = new Size(173, 27);
            textBox2name.TabIndex = 6;
            // 
            // textBox3email
            // 
            textBox3email.Location = new Point(161, 284);
            textBox3email.Name = "textBox3email";
            textBox3email.Size = new Size(173, 27);
            textBox3email.TabIndex = 7;
            // 
            // textBox4contactnumber
            // 
            textBox4contactnumber.Location = new Point(161, 328);
            textBox4contactnumber.Name = "textBox4contactnumber";
            textBox4contactnumber.Size = new Size(173, 27);
            textBox4contactnumber.TabIndex = 8;
            // 
            // button1addmember
            // 
            button1addmember.BackColor = SystemColors.ActiveCaptionText;
            button1addmember.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1addmember.ForeColor = SystemColors.Control;
            button1addmember.Location = new Point(92, 382);
            button1addmember.Name = "button1addmember";
            button1addmember.Size = new Size(148, 45);
            button1addmember.TabIndex = 9;
            button1addmember.Text = "Add Member";
            button1addmember.UseVisualStyleBackColor = false;
            // 
            // Addmember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(950, 493);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1close);
            FormBorderStyle = FormBorderStyle.None;
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