using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Classes
{
    internal class Member
    {
        private string name;
        private string email;
        private string password;
        public bool checkavailability;


        public Member(string title, string author, string isbn, bool checkavailability)
        {
            //this.Title = title;
            //this.Author = author;
            //this.ISBN = isbn;
            this.CheckavAilability = checkavailability;
        }
        //private string Title
        //{
        //    get { return title; }
        //    set { title = value; }
        //}
        //private string Author
        //{
        //    get { return author; }
        //    set { author = value; }
        //}
        //private string ISBN
        //{
        //    get { return isbn; }
        //    set { isbn = value; }
        //}
        public bool CheckavAilability
        {
            get { return checkavailability; }
            set { checkavailability = value; }
        }
    }
}
