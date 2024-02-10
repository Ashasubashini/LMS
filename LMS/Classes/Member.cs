using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Classes
{
    public class Member
    {
        private string name;
        private string email;
        private string password;


        public Member(string name, string email, string password)
        {
            this.name = name;
            this.email = email;
            this.password = password;
        }

        public string getName()
        {
            return this.name;
        }

        public string getEmail()
        {
            return this.email;
        }

        public string getPassword()
        {
            return this.password;
        }
    }
}
