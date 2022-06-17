using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bookstore
{
    class Patron
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        private int copiesHave = 0;
        public int CopiesHave
        {
            get { return copiesHave; }
            set { copiesHave = value; }
        }
        
        public List<Book> MyBooks = new List<Book>();
        public string MyHistory = "";

        public Patron(string fN, string lN, string a, string t, string s, string z, string p, string e)
        {
            FirstName = fN;
            LastName = lN;
            Address = a;
            Town = t;
            State = s;
            Zip = z;
            Phone = p;
            Email = e;
        }

        public void addBook(Book b)
        {
            MyBooks.Add(b);
        }

        public void removeBook(string s)
        {
            for (int i = 0; i < MyBooks.Count; i++)
            {
                if (s == MyBooks[i].Title)
                    MyBooks.RemoveAt(i);
            }
        }

        public Book getBook(int i)
        {
            return MyBooks[i];
        }

        public void AddCopiesHave()
        {
            copiesHave++;
        }

        public void SubCopiesHave()
        {
            copiesHave--;
        }

        public void SetHistory(string s)
        {
            MyHistory += s;
        }

        public string GetHistory()
        {
            return MyHistory;
        }
    }
}
