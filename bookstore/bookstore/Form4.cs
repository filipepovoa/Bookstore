using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace bookstore
{
    public partial class FormBookAdd : Form
    {
        public FormBookAdd()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddBook_Click_1(object sender, EventArgs e)
        {
            string t = textBoxBookTitle.Text;
            string lN = textBoxBookLN.Text;
            string fN = textBoxBookFN.Text;
            string iS = textBoxBookISBN.Text;

            Book b = new Book(t, lN, fN, iS);
            FormHome.bookInventoryList.Add(b);

            MessageBox.Show("This book has been added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            for (int i = 0; i < FormHome.bookInventoryList.Count - 1; i++)
            {
                for (int j = i + 1; j < FormHome.bookInventoryList.Count; j++)
                {
                    if (FormHome.bookInventoryList[i].ISBN == FormHome.bookInventoryList[j].ISBN)
                    {
                        FormHome.bookInventoryList[i].addNumCopies();
                        FormHome.bookInventoryList[i].addNumCopiesAvailable();
                        FormHome.bookInventoryList.RemoveAt(j);
                    }
                }
            }

            for (int i = 0; i < FormHome.bookInventoryList.Count - 1; i++)
            {
                for (int j = i + 1; j < FormHome.bookInventoryList.Count; j++)
                {
                    int result = string.Compare(FormHome.bookInventoryList[i].Title,
                        FormHome.bookInventoryList[j].Title);

                    if (result > 0)
                    {
                        Book tt = FormHome.bookInventoryList[i];
                        FormHome.bookInventoryList[i] = FormHome.bookInventoryList[j];
                        FormHome.bookInventoryList[j] = tt;
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter("..\\..\\Book.txt"))
            {
                foreach (var item in FormHome.bookInventoryList)
                {
                    sw.WriteLine(item.Title + "," + item.AuthorLastName + "," + item.AuthorFirstName + "," + item.ISBN);
                }
                sw.Close();
            }
        }
    }
}
