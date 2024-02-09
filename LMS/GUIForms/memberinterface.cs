using LMS.GUIForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{

    public partial class memberinterface : Form
    {
        public memberinterface()
        {
            InitializeComponent();


        }



        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new searchbook().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Borrowbok().Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Returnbook().Show();
            this.Hide();
        }
    }
}
