using MySql.Data.MySqlClient;

namespace Final
{

    // Refactored memberLogin class
    public partial class memberLogin : Form
    {
        private readonly MemberLoginOperations _loginOperations;

        public memberLogin()
        {
            InitializeComponent();
            string connectionString = "server=127.0.0.1; user=root; database=LMS; password=";
            _loginOperations = new MemberLoginOperations(connectionString);
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox2username.Text;
            string password = textBox3password.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Empty fields are not allowed.");
                return;
            }

            bool isValidLogin = _loginOperations.ValidateMemberCredentials(username, password);
            if (isValidLogin)
            {
                string sql = $"SELECT * FROM memberdetails WHERE username='{username}' AND password='{password}'";
                try
                {
                    MySqlDataReader userData = _loginOperations.ExecuteSQL(sql);
                    userData.Read();
                    Member user = new Member(userData.GetString("username"), userData.GetString("email"), userData.GetString("password"));
                    new memberinterface(user).Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid login.");
            }
        }
    }

}
