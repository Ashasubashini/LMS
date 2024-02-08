namespace Final
{
    public class User
    {
        private string username;
        private string userId;
        private string email;
        private string password;

        public User(string username, string userId, string email, string password)
        {
            this.username = username;
            this.email = email;
            this.userId = userId;
            this.password = password;
        }

        public string userName
        {
            get { return username; }
            set { username = value; }
        }

        public string userID
        {
            get { return userId; }
            set { userId = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


    }

}
