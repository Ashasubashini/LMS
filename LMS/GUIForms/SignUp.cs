using MongoDB.Bson;
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

        private async void button1signup_ClickAsync(object sender, EventArgs e)
        {
            MessageBox.Show("Executing SignUp");

            User u = new User("DS213", "asha", "fdf@ew", "rewr23");

            List<BsonDocument> documents = await u.Register();

            StringBuilder message = new StringBuilder();
            foreach (var doc in documents)
            {
                message.AppendLine(doc.ToJson()); // Convert each document to JSON and append it to the StringBuilder
            }

            // Display the concatenated string in a MessageBox
            MessageBox.Show(message.ToString(), "User Documents", MessageBoxButtons.OK);
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
