using Amazon.Runtime.Internal;
using Final;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LMS.GUIForms
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            
        }

        private void InsertUser(User user)
        {
            // Connection string to your SQL Server
            string connectionString = "server=127.0.0.1; user=root; database=lms; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL query to insert user into Users table
                string query = "INSERT INTO users (username, password, email) VALUES (@Username, @Password, @Email)";
                MessageBox.Show("Execute query");


                using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                {
                    // Parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", user.username);
                    command.Parameters.AddWithValue("@Password", user.password);
                    command.Parameters.AddWithValue("@Email", user.email);

                    try
                    {
                        mySqlConnection.Open();

                        command.ExecuteNonQuery();
                        MessageBox.Show("User successfully inserted into database.");
                        mySqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void button1signup_Click(object sender, EventArgs e)
        {
            User u = new User("ranuja", "123", "ranuja@gmail.com", "r1234");
            InsertUser(u);
        }
    }
}
