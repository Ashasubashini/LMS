using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Classes
{
    internal class Book
    {
        private string title;
        private string author;
        private string isbn;
        public bool checkavailability;
       

        public Book(string title, string author, string isbn, bool checkavailability)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
            this.CheckavAilability = checkavailability;
        }
        private string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string Author
        {
            get { return author; }
            set { author = value; }
        }
        private string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public bool CheckavAilability
        {
            get { return checkavailability; }
            set { checkavailability = value; }
        }
       
    }
}
