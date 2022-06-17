using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bookstore
{
    class Book
    {
        public string Title { get; set; } 
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string ISBN { get; set; }

        public List<Patron> MyPatrons = new List<Patron>();
        public List<DateTime> DueDates = new List<DateTime>();
        public string MyHistory = "";

        private int numCopies = 1;
        private int numCopiesAvailable = 1;

        public int NumCopiesAvailable
        {
            get { return numCopiesAvailable; }
            set { numCopiesAvailable = value; }
        }

        public int NumCopies
        {
            get { return numCopies; }
            set { numCopies = value; }
        }
        
        public Book(string t, string al, string af, string isbn)
        {
            Title = t;
            AuthorLastName = al;
            AuthorFirstName = af;
            ISBN = isbn;
        }

        public void addNumCopies()
        {
            numCopies++;
        }

        public void subNumCopies()
        {
            numCopies--;
        }

        public void addNumCopiesAvailable()
        {
            numCopiesAvailable++;
        }

        public void subNumCopiesAvailable()
        {
            numCopiesAvailable--;
        }

        public void addPatron(Patron p)
        {
            MyPatrons.Add(p);
        }

        public void addPatrons(List<Patron> p)
        {
            MyPatrons.AddRange(p);
        }

        public Patron getPatron(int i)
        {
            return MyPatrons[i];
        }

        public List<Patron> getPatrons()
        {
            return MyPatrons;
        }

        public DateTime getDueDates(int j)
        {
            return DueDates[j];
        }

        public List<DateTime> getDueDates()
        {
            return DueDates;
        }

        public void addDueDates(DateTime d)
        {
            DueDates.Add(d);
        }

        public void removePatron(Patron p)
        {
            for (int i = 0; i < MyPatrons.Count; i++)
            {
                if (p.FirstName == MyPatrons[i].FirstName && p.LastName == MyPatrons[i].LastName)
                    MyPatrons.RemoveAt(i);
            }
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
