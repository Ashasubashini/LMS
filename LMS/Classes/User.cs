using MongoDB.Driver;
using MongoDB.Bson;

namespace Final
{
    public class User
    {
        public string username;
        public string userId;
        public string email;
        public string password;

        public User(string username, string userId,  string password)
        {
            this.username = username;
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

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public List<User> Register()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("LMSdb");
            var collection = database.GetCollection<User>("users");

            var users = collection.Find(_ =>true).ToList();
            return users;
        }

    }

}