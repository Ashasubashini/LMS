using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            string mysqlCon = "server=127.0.0.1; user=root; database=LMS; password=";
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
                //MySqlCommand mySqlCommand = new MySqlCommand();

                string username = textBox2username.Text.ToString();
                string email = textBox1email.Text.ToString();
                string password = textBox3password.Text.ToString();
                string conpassword = textBox4conpassword.Text.ToString();
                if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(conpassword))
                {
                    MessageBox.Show("empty files are not allowed");
                }
                else if (password == conpassword)
                {

                    mySqlConnection.Open();
                    string signUp = "INSERT INTO memberdetails  (username, email, password) VALUES (@username, @email, @password)";

                    using (MySqlCommand command = new MySqlCommand(signUp, mySqlConnection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                    //string signUp = "insert into memberdetails values ('" + username + "','" + email + "','" + password + "')";
                    //MySqlCommand mySqlCommand = new MySqlCommand(signUp, mySqlConnection);
                    //mySqlCommand.ExecuteNonQuery();
                    mySqlConnection.Close();

                    username = "";
                    email = "";
                    password = "";
                    conpassword = "";


                    MessageBox.Show("Account successfully created!");
                }
                else
                {
                    MessageBox.Show("Password does not match, please re enter!");
                    password = "";
                    conpassword = "";
                    textBox3password.Focus();

                }

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Username already in use");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }


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
            new memberLogin().Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
