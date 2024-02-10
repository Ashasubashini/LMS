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


        public User(string userId, string username, string email, string password)
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

        public async Task<List<BsonDocument>> Register()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("LMSdb");
            IMongoCollection<BsonDocument> _collection = database.GetCollection<BsonDocument>("users");

            MessageBox.Show("MongoDB connection initiated");

            var documents = await _collection.Find(new BsonDocument()).ToListAsync();
            MessageBox.Show("Got the docs");
            return documents;
        }

    }

}
