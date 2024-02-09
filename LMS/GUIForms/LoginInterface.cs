using Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.GUIForms
{
    public partial class LoginInterface : Form
    {
        public LoginInterface()
        {
            InitializeComponent();
        }

        private void label1close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void button1memberlogin_Click(object sender, EventArgs e)
        //{
        //    new memberLogin().Show();
        //    this.Hide();
        //}

        private void button2librarianlogin_Click(object sender, EventArgs e)
        {
            new LibrarianLogin().Show();
            this.Hide();
        }

        private void button3signup_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void button1memberlogin_Click(object sender, EventArgs e)
        {
            new memberLogin().Show();
            this.Hide();
        }
    }
}
