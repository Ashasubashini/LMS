namespace LMS.GUIForms
{
    partial class Librarianlogedinterface
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            button1searchbook = new Button();
            button2addmember = new Button();
            button3addbooks = new Button();
            button4issuebook = new Button();
            button5memberrecord = new Button();
            button6libraryinventory = new Button();
            button7transaction = new Button();
            label2close = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-5, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 449);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profile_user1;
            pictureBox1.Location = new Point(89, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 154);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.power_button2;
            pictureBox2.Location = new Point(112, 363);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button1searchbook
            // 
            button1searchbook.Location = new Point(343, 94);
            button1searchbook.Name = "button1searchbook";
            button1searchbook.Size = new Size(150, 29);
            button1searchbook.TabIndex = 1;
            button1searchbook.Text = "Search Book";
            button1searchbook.UseVisualStyleBackColor = true;
            // 
            // button2addmember
            // 
            button2addmember.Location = new Point(514, 94);
            button2addmember.Name = "button2addmember";
            button2addmember.Size = new Size(136, 29);
            button2addmember.TabIndex = 2;
            button2addmember.Text = "Add Member";
            button2addmember.UseVisualStyleBackColor = true;
            // 
            // button3addbooks
            // 
            button3addbooks.Location = new Point(674, 94);
            button3addbooks.Name = "button3addbooks";
            button3addbooks.Size = new Size(94, 29);
            button3addbooks.TabIndex = 3;
            button3addbooks.Text = "Add Books";
            button3addbooks.UseVisualStyleBackColor = true;
            // 
            // button4issuebook
            // 
            button4issuebook.Location = new Point(311, 277);
            button4issuebook.Name = "button4issuebook";
            button4issuebook.Size = new Size(94, 29);
            button4issuebook.TabIndex = 4;
            button4issuebook.Text = "Issue Book";
            button4issuebook.UseVisualStyleBackColor = true;
            // 
            // button5memberrecord
            // 
            button5memberrecord.Location = new Point(491, 289);
            button5memberrecord.Name = "button5memberrecord";
            button5memberrecord.Size = new Size(132, 29);
            button5memberrecord.TabIndex = 5;
            button5memberrecord.Text = "Member Record";
            button5memberrecord.UseVisualStyleBackColor = true;
            // 
            // button6libraryinventory
            // 
            button6libraryinventory.Location = new Point(674, 281);
            button6libraryinventory.Name = "button6libraryinventory";
            button6libraryinventory.Size = new Size(94, 29);
            button6libraryinventory.TabIndex = 6;
            button6libraryinventory.Text = "Library inventory";
            button6libraryinventory.UseVisualStyleBackColor = true;
            // 
            // button7transaction
            // 
            button7transaction.Location = new Point(529, 383);
            button7transaction.Name = "button7transaction";
            button7transaction.Size = new Size(94, 29);
            button7transaction.TabIndex = 7;
            button7transaction.Text = "transaction";
            button7transaction.UseVisualStyleBackColor = true;
            // 
            // label2close
            // 
            label2close.AutoSize = true;
            label2close.Location = new Point(749, 16);
            label2close.Name = "label2close";
            label2close.Size = new Size(18, 20);
            label2close.TabIndex = 8;
            label2close.Text = "X";
            // 
            // Librarianlogedinterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._38828;
            ClientSize = new Size(800, 450);
            Controls.Add(label2close);
            Controls.Add(button7transaction);
            Controls.Add(button6libraryinventory);
            Controls.Add(button5memberrecord);
            Controls.Add(button4issuebook);
            Controls.Add(button3addbooks);
            Controls.Add(button2addmember);
            Controls.Add(button1searchbook);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Librarianlogedinterface";
            Text = "Librarianlogedinterface";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1searchbook;
        private Button button2addmember;
        private Button button3addbooks;
        private Button button4issuebook;
        private Button button5memberrecord;
        private Button button6libraryinventory;
        private Button button7transaction;
        private Label label2close;
    }
}