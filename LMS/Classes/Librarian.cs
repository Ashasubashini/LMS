using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class Librarian : User
    {
        public Librarian(string userName, string userID, string Email, string Password) : base(userName, userID, Email, Password)
        { }
    }
}
