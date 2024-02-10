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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1signup_Click(object sender, EventArgs e)
        {
            //User u = new User("asha", "DS213", "fdf@ew", "rewr23");

            //List<User> users = u.Register();
            //string message = "Users:\n";
            //foreach (var user in users)
            //{
            //    message += $"Username: {user.username}, Email: {user.email}, Password: {user.password}\n";
            //}
            //MessageBox.Show(message);
        }

        private void checkBox1showpwd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1showpwd.Checked == true)
            {
                textBox3password.PasswordChar = '\0';
                textBox4conpassword.PasswordChar = '\0';
            }
            else
            {
                textBox3password.PasswordChar = '*';
                textBox4conpassword.PasswordChar = '*';
            }
        }

        private void button2login_Click(object sender, EventArgs e)
        {
            //new memberLogin().Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
