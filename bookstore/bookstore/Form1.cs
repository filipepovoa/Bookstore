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
    public partial class FormHome : Form
    {
        internal static List<Book> bookInventoryList = new List<Book>();
        internal static List<Patron> patronList = new List<Patron>();

        internal static List<string> overDueBooks = new List<string>();
        internal static List<string> patronsOverDue = new List<string>();

        private int itemC = 0;
        public static int sIndexBook = 0;
        public static int sIndexPatron = 0;
        public static string[] PatronsHistory = new string[5000];
        public static string[] BookHistory = new string[5000];

        public FormHome()
        {
            InitializeComponent();

            timer1.Start(); //STARTS CURRENT TIME IN THE HOME TAB
        }


        ///OPENS NEW FORMS
        private void linkLabelLibraryPolicy_MouseClick(object sender, MouseEventArgs e)
        {
            FormLibraryPolicy fL = new FormLibraryPolicy();
            fL.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBookAdd_Click(object sender, EventArgs e)
        {
            FormBookAdd fAE = new FormBookAdd();
            fAE.ShowDialog();
        }

        private void buttonBookEdit_Click(object sender, EventArgs e)
        {
            sIndexBook = listBoxBookInventory.SelectedIndex;
            FormBookEdit fBE = new FormBookEdit();
            fBE.ShowDialog();
        }

        private void buttonPatronAdd_Click(object sender, EventArgs e)
        {
            FormPatronAdd fAE = new FormPatronAdd();
            fAE.ShowDialog();
        }

        private void buttonPatronEdit_Click(object sender, EventArgs e)
        {
            sIndexPatron = listBoxPatron.SelectedIndex;
            FormPatronEdit fPE = new FormPatronEdit();
            fPE.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBookAdd fAE = new FormBookAdd();
            fAE.ShowDialog();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPatronAdd fAE = new FormPatronAdd();
            fAE.ShowDialog();
        }

        //DISPLAYS MORE IMFORMATION ABOUT THE BOOK, FROM THE BOOK INVENTORY LIST
        private void listBoxBookInventory_Click(object sender, EventArgs e)
        {
            buttonBookDelete.Enabled = true;
            deleteToolStripMenuItem2.Enabled = true;
            buttonBookEdit.Enabled = true;
            editInfoToolStripMenuItem.Enabled = true;
            buttonViewHistoryBook.Enabled = true;

            // additional code
            int i = listBoxBookInventory.SelectedIndex;
            textBoxBookTitle.Text = bookInventoryList[i].Title;
            textBoxBookAuthor.Text = bookInventoryList[i].AuthorLastName + ", " + bookInventoryList[i].AuthorFirstName;
            textBoxBookISBN.Text = bookInventoryList[i].ISBN;
            textBoxBookNumCopies.Text = bookInventoryList[i].NumCopies.ToString();
            textBoxBookNumCopiesAvailable.Text = bookInventoryList[i].NumCopiesAvailable.ToString();

            string b = listBoxBookInventory.SelectedItem.ToString();
            int index = 0;
            foreach (var item in bookInventoryList)
            {
                if (b == item.Title)
                    index = bookInventoryList.IndexOf(item);
            }

            listBoxBookHistory.Items.Clear();
            for (int j = 0; j < bookInventoryList[index].MyPatrons.Count; j++)
                listBoxBookHistory.Items.Add(bookInventoryList[index].getPatron(j).FirstName.ToString() + " " +
                    bookInventoryList[index].getPatron(j).LastName.ToString());
        }

        private void listBoxBookInventory_KeyDown(object sender, KeyEventArgs e)
        {
            buttonBookDelete.Enabled = true;
            deleteToolStripMenuItem2.Enabled = true;
            buttonBookEdit.Enabled = true;
            editInfoToolStripMenuItem.Enabled = true;

            // additional code
            int i = listBoxBookInventory.SelectedIndex;
            textBoxBookTitle.Text = bookInventoryList[i].Title;
            textBoxBookAuthor.Text = bookInventoryList[i].AuthorLastName + ", " + bookInventoryList[i].AuthorFirstName;
            textBoxBookISBN.Text = bookInventoryList[i].ISBN;
            textBoxBookNumCopies.Text = bookInventoryList[i].NumCopies.ToString();
            textBoxBookNumCopiesAvailable.Text = bookInventoryList[i].NumCopiesAvailable.ToString();

            string b = listBoxBookInventory.SelectedItem.ToString();
            int index = 0;
            foreach (var item in bookInventoryList)
            {
                if (b == item.Title)
                    index = bookInventoryList.IndexOf(item);
            }

            listBoxBookHistory.Items.Clear();
            for (int j = 0; j < bookInventoryList[index].MyPatrons.Count; j++)
                listBoxBookHistory.Items.Add(bookInventoryList[index].getPatron(j).FirstName.ToString() + " " +
                    bookInventoryList[index].getPatron(j).LastName.ToString());
        }

        private void listBoxBookInventory_KeyUp(object sender, KeyEventArgs e)
        {
            buttonBookDelete.Enabled = true;
            deleteToolStripMenuItem2.Enabled = true;
            buttonBookEdit.Enabled = true;
            editInfoToolStripMenuItem.Enabled = true;

            // additional code
            int i = listBoxBookInventory.SelectedIndex;
            textBoxBookTitle.Text = bookInventoryList[i].Title;
            textBoxBookAuthor.Text = bookInventoryList[i].AuthorLastName + ", " + bookInventoryList[i].AuthorFirstName;
            textBoxBookISBN.Text = bookInventoryList[i].ISBN;
            textBoxBookNumCopies.Text = bookInventoryList[i].NumCopies.ToString();
            textBoxBookNumCopiesAvailable.Text = bookInventoryList[i].NumCopiesAvailable.ToString();

            string b = listBoxBookInventory.SelectedItem.ToString();
            int index = 0;
            foreach (var item in bookInventoryList)
            {
                if (b == item.Title)
                    index = bookInventoryList.IndexOf(item);
            }

            listBoxBookHistory.Items.Clear();
            for (int j = 0; j < bookInventoryList[index].MyPatrons.Count; j++)
                listBoxBookHistory.Items.Add(bookInventoryList[index].getPatron(j).FirstName.ToString() + " " +
                    bookInventoryList[index].getPatron(j).LastName.ToString());
        }

        private void listBoxPatron_Click(object sender, EventArgs e)
        {
            buttonPatronDelete.Enabled = true;
            deleteToolStripMenuItem3.Enabled = true;
            buttonPatronEdit.Enabled = true;
            editInfoToolStripMenuItem1.Enabled = true;
            buttonViewHistoryPatron.Enabled = true;

            // additional code
            int i = listBoxPatron.SelectedIndex;
            textBoxLastName.Text = patronList[i].LastName;
            textBoxFirstName.Text = patronList[i].FirstName;
            
            textBoxAddress.Text = patronList[i].Address;
            textBoxTown.Text = patronList[i].Town;
            textBoxState.Text = patronList[i].State;
            textBoxZIP.Text = patronList[i].Zip;
            textBoxPhone.Text = patronList[i].Phone;
            textBoxEmail.Text = patronList[i].Email;
            labelMore.Text = (5 - patronList[i].CopiesHave).ToString();

            //string p = listBoxPatron.SelectedItem.ToString();
            //string[] tokens;
            //char[] separator = {',',' '};
            //tokens = p.Split(separator);
            //int index = 0;
            //foreach (var item in patronList)
            //{
            //    if (tokens[0] == item.LastName && tokens[2] == item.FirstName)
            //       index = patronList.IndexOf(item);
            //}

            int index = listBoxPatron.SelectedIndex;

            listBoxPatronHistory.Items.Clear();
            for (int j = 0; j < patronList[index].MyBooks.Count; j++)
                listBoxPatronHistory.Items.Add(patronList[index].getBook(j).Title.ToString());
        }

        private void listBoxPatron_KeyDown(object sender, KeyEventArgs e)
        {
            buttonPatronDelete.Enabled = true;
            deleteToolStripMenuItem3.Enabled = true;
            buttonPatronEdit.Enabled = true;
            editInfoToolStripMenuItem1.Enabled = true;
            buttonViewHistoryPatron.Enabled = true;

            // additional code
            int i = listBoxPatron.SelectedIndex;
            textBoxLastName.Text = patronList[i].LastName;
            textBoxFirstName.Text = patronList[i].FirstName;

            textBoxAddress.Text = patronList[i].Address;
            textBoxTown.Text = patronList[i].Town;
            textBoxState.Text = patronList[i].State;
            textBoxZIP.Text = patronList[i].Zip;
            textBoxPhone.Text = patronList[i].Phone;
            textBoxEmail.Text = patronList[i].Email;
            labelMore.Text = (5 - patronList[i].CopiesHave).ToString();

            string p = listBoxPatron.SelectedItem.ToString();
            string[] tokens;
            char[] separator = { ',', ' ' };
            tokens = p.Split(separator);
            int index = 0;
            foreach (var item in patronList)
            {
                if (tokens[0] == item.LastName && tokens[2] == item.FirstName)
                    index = patronList.IndexOf(item);
            }

            listBoxPatronHistory.Items.Clear();
            for (int j = 0; j < patronList[index].MyBooks.Count; j++)
                listBoxPatronHistory.Items.Add(patronList[index].getBook(j).Title.ToString());
        }

        private void listBoxPatron_KeyUp(object sender, KeyEventArgs e)
        {
            buttonPatronDelete.Enabled = true;
            deleteToolStripMenuItem3.Enabled = true;
            buttonPatronEdit.Enabled = true;
            editInfoToolStripMenuItem1.Enabled = true;
            buttonViewHistoryPatron.Enabled = true;

            // additional code
            int i = listBoxPatron.SelectedIndex;
            textBoxLastName.Text = patronList[i].LastName;
            textBoxFirstName.Text = patronList[i].FirstName;

            textBoxAddress.Text = patronList[i].Address;
            textBoxTown.Text = patronList[i].Town;
            textBoxState.Text = patronList[i].State;
            textBoxZIP.Text = patronList[i].Zip;
            textBoxPhone.Text = patronList[i].Phone;
            textBoxEmail.Text = patronList[i].Email;
            labelMore.Text = (5 - patronList[i].CopiesHave).ToString();

            string p = listBoxPatron.SelectedItem.ToString();
            string[] tokens;
            char[] separator = { ',', ' ' };
            tokens = p.Split(separator);
            int index = 0;
            foreach (var item in patronList)
            {
                if (tokens[0] == item.LastName && tokens[2] == item.FirstName)
                    index = patronList.IndexOf(item);
            }

            listBoxPatronHistory.Items.Clear();
            for (int j = 0; j < patronList[index].MyBooks.Count; j++)
                listBoxPatronHistory.Items.Add(patronList[index].getBook(j).Title.ToString());
        }


        private void tabControlMain_Click(object sender, EventArgs e)
        {
            buttonBookDelete.Enabled = false;
            buttonBookEdit.Enabled = false;
            deleteToolStripMenuItem2.Enabled = false;
            editInfoToolStripMenuItem.Enabled = false;

            buttonPatronEdit.Enabled = false;
            buttonPatronDelete.Enabled = false;
            deleteToolStripMenuItem3.Enabled = false;
            editInfoToolStripMenuItem1.Enabled = false;
        }

        //CODE FOR THE COUNTER IN THE CHECK-OUT TAB
        private void checkedListBoxCheckOut_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
            int count = checkedListBoxCheckOut.CheckedItems.Count;
            if (e.NewValue == CheckState.Checked)
            { 
                ++count;
            }
            if (e.NewValue == CheckState.Unchecked)
            { 
                --count;
            }
            label_counter.Text = Convert.ToString(count);
            
            // additional code to enable the check out button
            if (label_counter.Text == Convert.ToString(0))
            {
                button_checkOut.Enabled = false;
                return;
            }
            if (Convert.ToInt32(label_counter.Text) > 0 && listBoxCheckOut.SelectedItems.Count > 0)
                button_checkOut.Enabled = true;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AboutUs fAUs = new Form_AboutUs();
            fAUs.ShowDialog();
        }

        //SEARCH BOXES
        private void SearchBox_Book_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox_Book.Text == "")
            {
                return;
            }
            else
            {
               // listBoxBookInventory.SelectedItems.Clear();
                for (int i = listBoxBookInventory.Items.Count-1; i >= 0 ; i--)
                {
                    if (listBoxBookInventory.Items[i].ToString().ToLower().Contains(SearchBox_Book.Text.ToLower()))
                    {
                        listBoxBookInventory.SetSelected(i, true);
                    }
                }
            }            
        }

        private void SearchBox_Patron_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox_Patron.Text == "")
            {
                return;
            }
            else
            {
               // listBoxPatron.SelectedItems.Clear();
                for (int i = listBoxPatron.Items.Count - 1; i >= 0; i--)
                {
                    if (listBoxPatron.Items[i].ToString().ToLower().Contains(SearchBox_Patron.Text.ToLower()))
                    {
                        listBoxPatron.SetSelected(i, true);
                    }
                }
            }            
        }

        private void SearchBox_BookCheckOut_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox_BookCheckOut.Text == "")
            {
                return;
            }
            else
            {
               // checkedListBoxCheckOut.SelectedItems.Clear();
                for (int i = checkedListBoxCheckOut.Items.Count - 1; i >= 0; i--)
                {
                    if (checkedListBoxCheckOut.Items[i].ToString().ToLower().Contains(SearchBox_BookCheckOut.Text.ToLower()))
                    {
                        checkedListBoxCheckOut.SetSelected(i, true);
                    }
                }
            }            
        }

        private void textBoxSearchPatronCheckout_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearchPatronCheckout.Text == "")
            {
                return;
            }
            else
            {
                //listBoxCheckOut.SelectedItems.Clear();
                for (int i = listBoxCheckOut.Items.Count - 1; i >= 0; i--)
                {
                    if (listBoxCheckOut.Items[i].ToString().ToLower().Contains(textBoxSearchPatronCheckout.Text.ToLower()))
                    {
                        listBoxCheckOut.SetSelected(i, true);
                    }
                }
            }            
        }

        private void SearchBox_PatronCheckIn_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox_PatronCheckIn.Text == null)
            {
                return;
            }
            else
            {
               // listBoxCheckIn.SelectedItems.Clear();
                for (int i = listBoxCheckIn.Items.Count - 1; i >= 0; i--)
                {
                    if (listBoxCheckIn.Items[i].ToString().ToLower().Contains(SearchBox_PatronCheckIn.Text.ToLower()))
                    {
                        listBoxCheckIn.SetSelected(i, true);
                    }
                }
            }            
        }

        private void editInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sIndexBook = listBoxBookInventory.SelectedIndex;
            FormBookEdit fBE = new FormBookEdit();
            fBE.ShowDialog();
        }

        private void editInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sIndexPatron = listBoxPatron.SelectedIndex;
            FormPatronEdit fPE = new FormPatronEdit();
            fPE.ShowDialog();
        }

        ///focus for book search box ////////
        private void SearchBox_Book_Click(object sender, EventArgs e)
        {
            SearchBox_Book.Text = "";
        }

        private void SearchBox_Book_Leave(object sender, EventArgs e)
        {
            SearchBox_Book.Text = "Search for a book...";
        }

        private void FormHome_Click(object sender, EventArgs e)
        {
            SearchBox_Book.Text = "Search for a book...";
            SearchBox_Patron.Text = "Search for a Patron...";
            SearchBox_BookCheckOut.Text = "Search for a book...";
            SearchBox_PatronCheckIn.Text = "Search for a Patron...";
        }

        private void tabPageBookInventory_Click(object sender, EventArgs e)
        {
            SearchBox_Book.Text = "Search for a book...";
        }

        // focus for patron search box ////////
        private void tabPagePatron_Click(object sender, EventArgs e)
        {
            SearchBox_Patron.Text = "Search for a Patron...";
        }

        private void SearchBox_Patron_Click(object sender, EventArgs e)
        {
            SearchBox_Patron.Text = "";
        }

        private void SearchBox_Patron_Leave(object sender, EventArgs e)
        {
            SearchBox_Patron.Text = "Search for a Patron...";
        }

        // focus for book search in check out //////
        private void SearchBox_BookCheckOut_Click(object sender, EventArgs e)
        {
            SearchBox_BookCheckOut.Text = "";
        }

        private void SearchBox_BookCheckOut_Leave(object sender, EventArgs e)
        {
            SearchBox_BookCheckOut.Text = "Search for a book...";
        }

        private void tabPageCheckout_Click(object sender, EventArgs e)
        {
            SearchBox_BookCheckOut.Text = "Search for a book...";
            textBoxSearchPatronCheckout.Text = "Search for a Patron...";
        }

        // focus for patron search in check out
        private void textBoxSearchPatronCheckout_Click(object sender, EventArgs e)
        {
            textBoxSearchPatronCheckout.Text = "";
        }

        private void textBoxSearchPatronCheckout_Leave(object sender, EventArgs e)
        {
            textBoxSearchPatronCheckout.Text = "Search for a Patron...";
        }

        // focus for patron search in check in
        private void SearchBox_PatronCheckIn_Click(object sender, EventArgs e)
        {
            SearchBox_PatronCheckIn.Text = "";
        }

        private void SearchBox_PatronCheckIn_Leave(object sender, EventArgs e)
        {
            SearchBox_PatronCheckIn.Text = "Search for a Patron...";
        }

        private void tabPageCheckin_Click(object sender, EventArgs e)
        {
            SearchBox_PatronCheckIn.Text = "Search for a Patron...";
        }

        ///uses the cart counter in the check out to enable the check out button
        private void listBoxCheckOut_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label_counter.Text) == 0)
            {
                button_checkOut.Enabled = false;
                return;
            }
            if (Convert.ToInt32(label_counter.Text) > 0 && listBoxCheckOut.SelectedItems.Count > 0)
                button_checkOut.Enabled = true;
        }

        //THE PROGRAM STARTS HERE!!!!!!!!!!
        private void FormHome_Load(object sender, EventArgs e)
        {
            // BOOK INVENTORY
            string[] tokens;
            string line;
            Book b;
            try
            {
                using (StreamReader sr = new StreamReader("..\\..\\Book.txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        line = sr.ReadLine();
                        tokens = line.Split(',');
                        b = new Book(tokens[0], tokens[1], tokens[2], tokens[3]);
                        bookInventoryList.Add(b);
                    }
                    sr.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured");
            }
            
            // logic for duplicated book
            for (int i = 0; i < bookInventoryList.Count - 1; i++)
            {
                for (int j = i + 1; j < bookInventoryList.Count; j++)
                {
                    if (bookInventoryList[i].Title == bookInventoryList[j].Title)
                    {
                        bookInventoryList[i].addNumCopies();
                        bookInventoryList[i].addNumCopiesAvailable();
                        bookInventoryList.RemoveAt(j);
                    }
                }
            }

            for (int i = 0; i < bookInventoryList.Count - 1; i++)
            {
                for (int j = i + 1; j < bookInventoryList.Count; j++)
                {
                    int result = string.Compare(bookInventoryList[i].Title, bookInventoryList[j].Title);

                    if (result > 0)
                    {
                        Book t = bookInventoryList[i];
                        bookInventoryList[i] = bookInventoryList[j];
                        bookInventoryList[j] = t;
                    }
                }
            }

            listBoxBookInventory.Items.Clear();
            checkedListBoxCheckOut.Items.Clear();
            foreach (var item in bookInventoryList)
            {
                listBoxBookInventory.Items.Add(item.Title);
                checkedListBoxCheckOut.Items.Add(item.Title);
            }

            
            // PATRON
            string[] tokensPatron;
            string linePatron;
            Patron p;
            try
            {
                using (StreamReader sr = new StreamReader("..\\..\\Patrons.txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        linePatron = sr.ReadLine();
                        tokensPatron = linePatron.Split(',');
                        p = new Patron(tokensPatron[0], tokensPatron[1], tokensPatron[2], tokensPatron[3],
                            tokensPatron[4], tokensPatron[5], tokensPatron[6], tokensPatron[7]);
                        patronList.Add(p);
                    }
                    sr.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured");
            }

            for (int i = 0; i < patronList.Count - 1; i++)
            {
                for (int j = i + 1; j < patronList.Count; j++)
                {
                    int result = string.Compare(patronList[i].LastName, patronList[j].LastName);

                    if (result > 0)
                    {
                        Patron t = patronList[i];
                        patronList[i] = patronList[j];
                        patronList[j] = t;
                    }
                }
            }

            listBoxPatron.Items.Clear();
            listBoxCheckOut.Items.Clear();
            listBoxCheckIn.Items.Clear();
            foreach (var item in patronList)
            {
                listBoxPatron.Items.Add(item.LastName + ", " + item.FirstName);
                listBoxCheckOut.Items.Add(item.LastName + ", " + item.FirstName);
                listBoxCheckIn.Items.Add(item.LastName + ", " + item.FirstName);
            }

            //Reads the patron's history file
            string[] tokensPatronHistory1;
            string[] tokensPatronHistory2;
            string linePatronsHistory;
            try
            {
                using (StreamReader sr = new StreamReader("..\\..\\PatronHistory.txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        linePatronsHistory = sr.ReadToEnd();
                        tokensPatronHistory1 = linePatronsHistory.Split('*');
                        for (int i = 0; i < tokensPatronHistory1.Length; i++)
                        {
                            PatronsHistory[i] = tokensPatronHistory1[i];
                            tokensPatronHistory2 = tokensPatronHistory1[i].Split('-');
                            for (int j = 0; j < tokensPatronHistory2.Length; j++)
                            {
                                foreach (var item in bookInventoryList)
                                {
                                    if (item.Title == tokensPatronHistory2[j] && tokensPatronHistory2[j + 1] == "checked out")
                                    {
                                        patronList[i].addBook(item);
                                        item.addPatron(patronList[i]);
                                        item.subNumCopiesAvailable();
                                    }
                                    else if (item.Title == tokensPatronHistory2[j] && tokensPatronHistory2[j + 1] == "checked in")
                                    {
                                        patronList[i].removeBook(item.Title);
                                        item.removePatron(patronList[i]);
                                        item.addNumCopiesAvailable();
                                    }
                                }
                            }
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception)
            {
            }

            //for (int i = 0; i < patronList.Count; i++)
            //    PatronsHistory[i] = patronList[i].FirstName + " " + patronList[i].LastName;

            //puts the history data into the patron's text file
            using (StreamWriter sw = new StreamWriter("..\\..\\PatronHistory.txt"))
            {
                foreach (var item in PatronsHistory)
                {
                    sw.Write(item + "*");
                }
                sw.Close();
            }

            //Reads the book's history file
            string[] tokensBookHistory1;
            string[] tokensBookHistory2;
            string lineBookHistory;
            try
            {
                using (StreamReader sr = new StreamReader("..\\..\\BookHistory.txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        lineBookHistory = sr.ReadToEnd();
                        tokensBookHistory1 = lineBookHistory.Split('*');
                        for (int i = 0; i < tokensBookHistory1.Length; i++)
                        {
                            BookHistory[i] = tokensBookHistory1[i];
                            tokensBookHistory2 = tokensBookHistory1[i].Split('-');
                            for (int j = 0; j < tokensBookHistory2.Length; j++)
                            {
                                foreach (var item in patronList)
                                {
                                    if ((item.FirstName + " " + item.LastName) == tokensBookHistory2[j] && tokensBookHistory2[j + 1] == "checked out")
                                    {
                                        bookInventoryList[i].addPatron(item);
                                    }
                                    else if ((item.FirstName + " " + item.LastName) == tokensBookHistory2[j] && tokensBookHistory2[j + 1] == "checked in")
                                    {
                                        bookInventoryList[i].removePatron(item);
                                    }
                                    break;
                                }
                            }
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception)
            {
            }

            //for (int i = 0; i < bookInventoryList.Count; i++)
            //    BookHistory[i] = bookInventoryList[i].Title;

            //puts the history data into the book's text file
            using (StreamWriter sw = new StreamWriter("..\\..\\BookHistory.txt"))
            {
                foreach (var item in BookHistory)
                {
                    sw.Write(item + "*");
                }
                sw.Close();
            }

            string line1;
            string[] tokens1;
            using (StreamReader sr = new StreamReader("..\\..\\OverdueBooks.txt"))
            {                
                while (sr.Peek() >= 0)
                {
                    line1 = sr.ReadToEnd();
                    tokens1 = line1.Split('*');
                    for (int i = 0; i < tokens1.Length; i++)
                    {
                        overDueBooks.Add(tokens1[i]);
                    }
                }                
                sr.Close();
            }

            string line2;
            string[] tokens2;
            using (StreamReader sr = new StreamReader("..\\..\\OverduePatrons.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    line2 = sr.ReadToEnd();
                    tokens2 = line2.Split('*');
                    for (int i = 0; i < tokens2.Length; i++)
                    {
                        patronsOverDue.Add(tokens2[i]);
                    }
                }                
                sr.Close();
            }

            foreach (var item in overDueBooks)
            {
                listBox_OverdueBooks.Items.Add(item);
            }

            foreach (var item in patronsOverDue)
            {
                listBox_patronOverdue.Items.Add(item);
            }
        }

        //check out
        private void button_checkOut_Click(object sender, EventArgs e)
        {
            int x = checkedListBoxCheckOut.CheckedItems.Count;

            button_checkOut.Enabled = false;

            List<string> b = new List<string>();
            string U = "";
            string A = "";
            List<string> booksAvailable = new List<string>();
            List<string> booksUnavailable = new List<string>();

            //overdue books
            string pickedDate = dateTimePicker.Text.ToString();
            DateTime DTinput = DateTime.Parse(pickedDate);
            DateTime DTcurrent = DateTime.Now;

            int result = DateTime.Compare(DTinput, DTcurrent);
            ////////////////////////////////////////////////

            foreach (object itemChecked in checkedListBoxCheckOut.CheckedItems)
            {
                b.Add(itemChecked.ToString());
            }

            string p = listBoxCheckOut.SelectedItem.ToString();
            string[] tokens;
            char[] separator = { ',', ' ' };
            tokens = p.Split(separator);
            int index = 0;
            foreach (var item in patronList)
            {
                if (tokens[0] == item.LastName && tokens[2] == item.FirstName)
                {
                    index = listBoxCheckOut.SelectedIndex;
                }
            }

            if (x + patronList[index].CopiesHave <= 5)
            {
                for (int i = 0; i < b.Count; i++)
                {
                    foreach (Book book in bookInventoryList)
                    {
                        if (book.Title == b[i])
                        {
                            if (book.NumCopiesAvailable > 0)
                            {
                                patronList[index].addBook(book);
                                patronList[index].AddCopiesHave();
                                book.addPatron(patronList[index]);
                                book.subNumCopiesAvailable();
                                booksAvailable.Add(book.Title);
                                book.addDueDates(DTcurrent);
                            }
                            else
                            {
                                booksUnavailable.Add(book.Title);
                            }
                        }
                    }
                }
                for (int i = 0; i < booksAvailable.Count; i++)
                {
                    if (i == 0)
                        A = A + booksAvailable[i];
                    else if (i > 0 && i < booksAvailable.Count - 1)
                        A = A + ", " + booksAvailable[i];
                    else
                        A = A + " and " + booksAvailable[i];
                }
                for (int i = 0; i < booksUnavailable.Count; i++)
                {
                    if (i == 0)
                        U = U + booksUnavailable[i];
                    else if (i > 0 && i < booksUnavailable.Count - 1)
                        U = U + ", " + booksUnavailable[i];
                    else
                        U = U + " and " + booksUnavailable[i];
                }

                if (booksAvailable.Count > 0)
                {
                    if (booksAvailable.Count == 1)
                        MessageBox.Show(A + " was checked out to " + patronList.ElementAt(index).FirstName + " " 
                            + patronList.ElementAt(index).LastName);
                    else
                    {
                        MessageBox.Show(A + " were checked out to " + patronList.ElementAt(index).FirstName + " " 
                            + patronList.ElementAt(index).LastName);
                    }
                }

                if (booksUnavailable.Count > 0)
                {
                    if (booksUnavailable.Count == 1)
                        MessageBox.Show(U + " is not avaiable.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show(U + " are not avaiable.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                /////overdue books/patrons
                /////////////////////////////////////////////////////////////////////////

                if (result < 0 && booksAvailable.Count > 0)
                {
                    foreach (object itemChecked in checkedListBoxCheckOut.CheckedItems)
                        overDueBooks.Add(itemChecked.ToString());
                        //listBox_OverdueBooks.Items.Add(itemChecked.ToString());

                    string[] PatronsOverdue = new string[listBox_patronOverdue.Items.Count];
                    for (int i = 0; i < listBox_patronOverdue.Items.Count; i++)
                    {
                        PatronsOverdue[i] = listBox_patronOverdue.Items[i].ToString();
                    }
                    if (PatronsOverdue.Contains(listBoxCheckOut.SelectedItem.ToString()))
                        return;
                    else
                      patronsOverDue.Add(listBoxCheckOut.SelectedItem.ToString());
                        //listBox_patronOverdue.Items.Add(listBoxCheckOut.SelectedItem.ToString());
                    for (int i = 0; i < overDueBooks.Count; i++)
                    {
                        listBox_OverdueBooks.Items.Add(overDueBooks[i]);
                    }
                    for (int i = 0; i < patronsOverDue.Count; i++)
                    {
                        listBox_patronOverdue.Items.Add(patronsOverDue[i]);
                    }

                    using (StreamWriter sw = new StreamWriter("..\\..\\OverdueBooks.txt"))
                    {
                        foreach (var item in overDueBooks)
                        {
                            sw.Write(item + "*");
                        }
                        sw.Close();
                    }

                    using (StreamWriter sw = new StreamWriter("..\\..\\OverduePatrons.txt"))
                    {
                        foreach (var item in patronsOverDue)
                        {
                            sw.Write(item + "*");
                        }
                        sw.Close();
                    }

                }

                monthCalendar_overdue.AddBoldedDate(DTinput);

            }

            else
            {
                MessageBox.Show("This patron can't borrow any more books. A maximum of 5 books is allowed per patron!", 
                    "Important Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //puts data into the patron's history array
            DateTime dt = DateTime.Now;
            for (int i = 0; i < booksAvailable.Count; i++)
            {
                PatronsHistory[index] += "-" + booksAvailable[i] + "-checked out-" + dt.ToShortDateString();
                patronList[index].SetHistory(PatronsHistory[index]);
            }

            //puts the patron's history data into the text file
            using (StreamWriter sw = new StreamWriter("..\\..\\PatronHistory.txt"))
            {
                foreach (var item in PatronsHistory)
                {
                    sw.Write(item + "*");
                }
                sw.Close();
            }

            //puts data into the book's history array
            for (int i = 0; i < booksAvailable.Count; i++)
            {
                for (int j = 0; j < bookInventoryList.Count; j++)
                {
                    if (bookInventoryList[j].Title == booksAvailable[i])
                    {
                        BookHistory[j] += "-" + patronList[index].FirstName + " " + patronList[index].LastName + "-checked out-" + dt.ToShortDateString();
                        bookInventoryList[j].SetHistory(BookHistory[j]);
                    }
                }
            }

            //puts the book's history data into the text file
            using (StreamWriter sw = new StreamWriter("..\\..\\BookHistory.txt"))
            {
                foreach (var item in BookHistory)
                {
                    sw.Write(item + "*");
                }
                sw.Close();
            }
        }


        //listbox check in
        private void listBoxCheckIn_Click(object sender, EventArgs e)
        {
            checkedListBoxCheckIn.Items.Clear();
            int index = listBoxCheckIn.SelectedIndex;

            for (int i = 0; i < patronList[index].MyBooks.Count; i++)
                checkedListBoxCheckIn.Items.Add(patronList[index].getBook(i).Title.ToString());

            // additional code
            button_CheckIn.Enabled = false;
            button_ReNew.Enabled = false;
        }

        private void listBoxCheckIn_KeyDown(object sender, KeyEventArgs e)
        {
            checkedListBoxCheckIn.Items.Clear();
            int index = listBoxCheckIn.SelectedIndex;

            for (int i = 0; i < patronList[index].MyBooks.Count; i++)
                checkedListBoxCheckIn.Items.Add(patronList[index].getBook(i).Title.ToString());
        }

        private void listBoxCheckIn_KeyUp(object sender, KeyEventArgs e)
        {
            checkedListBoxCheckIn.Items.Clear();
            int index = listBoxCheckIn.SelectedIndex;

            for (int i = 0; i < patronList[index].MyBooks.Count; i++)
                checkedListBoxCheckIn.Items.Add(patronList[index].getBook(i).Title.ToString());
        }

        //Button to delete a book from the inventory
        private void buttonBookDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxBookInventory.SelectedIndex;

            if (bookInventoryList[index].NumCopiesAvailable == 0)
            {
                MessageBox.Show("You cannot delete this book yet. Someone has it!", 
                    "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           DialogResult dialog = MessageBox.Show("Are you sure you want to delete \""+ bookInventoryList[index].Title 
               +"\" ?", "Warning", MessageBoxButtons.YesNo);

           if (dialog == DialogResult.No)
           {
               return;
           }

           else if (dialog == DialogResult.Yes)
           {
               bookInventoryList[index].subNumCopies();
               bookInventoryList[index].subNumCopiesAvailable();

               textBoxBookNumCopies.Text = bookInventoryList[index].NumCopies.ToString();
               textBoxBookNumCopiesAvailable.Text = bookInventoryList[index].NumCopiesAvailable.ToString();

               if (bookInventoryList[index].NumCopies == 0)
               {
                   bookInventoryList.RemoveAt(index);

                   listBoxBookInventory.Items.Clear();
                   checkedListBoxCheckOut.Items.Clear();
                   foreach (var item in bookInventoryList)
                   {
                       listBoxBookInventory.Items.Add(item.Title);
                       checkedListBoxCheckOut.Items.Add(item.Title);
                   }

                   textBoxBookTitle.Text = "";
                   textBoxBookAuthor.Text = "";
                   textBoxBookISBN.Text = "";
                   textBoxBookNumCopies.Text = "";
                   textBoxBookNumCopiesAvailable.Text = "";
               }
           }

           using (StreamWriter sw = new StreamWriter("..\\..\\Book.txt"))
           {
               foreach (var item in bookInventoryList)
               {
                   sw.WriteLine(item.Title + "," + item.AuthorLastName + "," + item.AuthorFirstName + "," + item.ISBN);
               }
               sw.Close();
           }
        }

        //Menu strip to delete a book from the inventory
        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int index = listBoxBookInventory.SelectedIndex;

            if (bookInventoryList[index].NumCopiesAvailable == 0)
            {
                MessageBox.Show("You cannot delete this book yet. Someone has it!",
                    "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialog = MessageBox.Show("Are you sure you want to delete \"" + bookInventoryList[index].Title
                + "\" ?", "Warning", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.No)
            {
                return;
            }

            else if (dialog == DialogResult.Yes)
            {
                bookInventoryList[index].subNumCopies();
                bookInventoryList[index].subNumCopiesAvailable();

                textBoxBookNumCopies.Text = bookInventoryList[index].NumCopies.ToString();
                textBoxBookNumCopiesAvailable.Text = bookInventoryList[index].NumCopiesAvailable.ToString();

                if (bookInventoryList[index].NumCopies == 0)
                {
                    bookInventoryList.RemoveAt(index);

                    listBoxBookInventory.Items.Clear();
                    checkedListBoxCheckOut.Items.Clear();
                    foreach (var item in bookInventoryList)
                    {
                        listBoxBookInventory.Items.Add(item.Title);
                        checkedListBoxCheckOut.Items.Add(item.Title);
                    }

                    textBoxBookTitle.Text = "";
                    textBoxBookAuthor.Text = "";
                    textBoxBookISBN.Text = "";
                    textBoxBookNumCopies.Text = "";
                    textBoxBookNumCopiesAvailable.Text = "";
                }
            }

            using (StreamWriter sw = new StreamWriter("..\\..\\Book.txt"))
            {
                foreach (var item in bookInventoryList)
                {
                    sw.WriteLine(item.Title + "," + item.AuthorLastName + "," + item.AuthorFirstName + "," + item.ISBN);
                }
                sw.Close();
            }
        }

        //adds date and time to the home tab
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            label_time.Text = datetime.ToString("F");
        }

        // pops up the windows asking if you want to close the program
        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
        //    DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
        //    if (dialog == DialogResult.Yes)
        //    {
        //        e.Cancel = false;
        //    }
        //    else if (dialog == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        }

        private void buttonViewHistoryBook_Click(object sender, EventArgs e)
        {
            sIndexBook = listBoxBookInventory.SelectedIndex;

            FormBookHistory fBH = new FormBookHistory();
            fBH.ShowDialog();
        }

        private void buttonViewHistoryPatron_Click(object sender, EventArgs e)
        {
            sIndexPatron = listBoxPatron.SelectedIndex;

            FormPatronHistory fPH = new FormPatronHistory();
            fPH.ShowDialog();
        }

        // Button to delete a patron
        private void buttonPatronDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxPatron.SelectedIndex;

            if (patronList[index].MyBooks.Count > 0)
            {
                MessageBox.Show("You cannot delete this patron yet, " +patronList[index].FirstName + " has " + patronList[index].MyBooks.Count.ToString() +
                    " books.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialog = MessageBox.Show("Are you sure you want to delete \"" + patronList[index].FirstName + " " +
                patronList[index].LastName + "\" ?", "Warning", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.No)
            {
                return;
            }

            else if (dialog == DialogResult.Yes)
            {
                patronList.RemoveAt(index);

                listBoxPatron.Items.Clear();
                listBoxCheckIn.Items.Clear();

                foreach (var item in patronList)
                {
                    listBoxPatron.Items.Add(item.LastName + ", " + item.FirstName);
                    listBoxCheckIn.Items.Add(item.LastName + ", " + item.FirstName);
                }

                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxAddress.Text = "";
                textBoxTown.Text = "";
                textBoxState.Text = "";
                textBoxZIP.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }

            using (StreamWriter sw = new StreamWriter("..\\..\\Patrons.txt"))
            {
                foreach (var item in patronList)
                {
                    sw.WriteLine(item.FirstName + "," + item.LastName + "," + item.Address + "," + item.Town +
                        "," + item.State + "," + item.Zip + "," + item.Phone + "," + item.Email);
                }
                sw.Close();
            }
        }

        // Menu strip to delete a patron
        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
            int index = listBoxPatron.SelectedIndex;

            if (patronList[index].MyBooks.Count > 0)
            {
                MessageBox.Show("You cannot delete this patron yet, " + patronList[index].FirstName + " has " + patronList[index].MyBooks.Count.ToString() +
                    " books.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialog = MessageBox.Show("Are you sure you want to delete \"" + patronList[index].FirstName + " " +
                patronList[index].LastName + "\" ?", "Warning", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.No)
            {
                return;
            }

            else if (dialog == DialogResult.Yes)
            {
                patronList.RemoveAt(index);

                listBoxPatron.Items.Clear();
                listBoxCheckIn.Items.Clear();

                foreach (var item in patronList)
                {
                    listBoxPatron.Items.Add(item.LastName + ", " + item.FirstName);
                    listBoxCheckIn.Items.Add(item.LastName + ", " + item.FirstName);
                }

                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxAddress.Text = "";
                textBoxTown.Text = "";
                textBoxState.Text = "";
                textBoxZIP.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }

            using (StreamWriter sw = new StreamWriter("..\\..\\Patrons.txt"))
            {
                foreach (var item in patronList)
                {
                    sw.WriteLine(item.FirstName + "," + item.LastName + "," + item.Address + "," + item.Town +
                        "," + item.State + "," + item.Zip + "," + item.Phone + "," + item.Email);
                }
                sw.Close();
            }
        }

        private void checkedListBoxCheckIn_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                itemC++;
            }
            if (e.NewValue == CheckState.Unchecked)
            {
                itemC--;
            }

            if (itemC <= 0)
            {
                button_CheckIn.Enabled = false;
                button_ReNew.Enabled = false;
            }
            else
            {
                button_CheckIn.Enabled = true;
                button_ReNew.Enabled = true;
            }
        }

        private void toolStripMenuItemRefresh_Click(object sender, EventArgs e)
        {
            // BOOK INVENTORY
            listBoxBookInventory.Items.Clear();
            checkedListBoxCheckOut.Items.Clear();
            foreach (var item in bookInventoryList)
            {
                listBoxBookInventory.Items.Add(item.Title);
                checkedListBoxCheckOut.Items.Add(item.Title);
            }


            // PATRON
            listBoxPatron.Items.Clear();
            listBoxCheckOut.Items.Clear();
            listBoxCheckIn.Items.Clear();
            foreach (var item in patronList)
            {
                listBoxPatron.Items.Add(item.LastName + ", " + item.FirstName);
                listBoxCheckOut.Items.Add(item.LastName + ", " + item.FirstName);
                listBoxCheckIn.Items.Add(item.LastName + ", " + item.FirstName);
            }
        }

        ///check in
        private void button_CheckIn_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            int index = listBoxCheckIn.SelectedIndex;

            foreach (object itemChecked in checkedListBoxCheckIn.CheckedItems)
            {
                s.Add(itemChecked.ToString());
            }

            for (int i = 0; i < s.Count; i++)
            {
                for (int j = 0; j < bookInventoryList.Count; j++)
                {
                    if (s[i] == bookInventoryList[j].Title)
                    {
                        bookInventoryList[j].addNumCopiesAvailable();
                        bookInventoryList[j].removePatron(patronList[index]);
                        patronList[index].removeBook(bookInventoryList[j].Title);
                        patronList[index].SubCopiesHave();
                        overDueBooks.Remove(bookInventoryList[j].Title);
                        String ss = string.Format(patronList[index].LastName + ", " +  patronList[index].FirstName);
                        patronsOverDue.Remove(ss);
                        break;
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter("..\\..\\OverdueBooks.txt"))
            {
                foreach (var item in overDueBooks)
                {
                    sw.Write(item + "*");
                }
                sw.Close();
            }

            using (StreamWriter sw = new StreamWriter("..\\..\\OverduePatrons.txt"))
            {
                foreach (var item in patronsOverDue)
                {
                    sw.Write(item + "*");
                }
                sw.Close();
            }


            listBoxPatronHistory.Items.Clear();
            for (int i = 0; i < patronList[index].MyBooks.Count; i++)
                listBoxPatronHistory.Items.Add(patronList[index].getBook(i).Title.ToString());
            checkedListBoxCheckIn.Items.Clear();
            for (int i = 0; i < patronList[index].MyBooks.Count; i++)
                checkedListBoxCheckIn.Items.Add(patronList[index].getBook(i).Title.ToString());

            string booksCheckedIn = "";
            for (int i = 0; i < s.Count; i++)
            {
                if (i == 0)
                    booksCheckedIn = booksCheckedIn + s[i];
                else if (i > 0 && i < s.Count - 1)
                    booksCheckedIn = booksCheckedIn + ", " + s[i];
                else
                    booksCheckedIn = booksCheckedIn + " and " + s[i];
            }

            if (s.Count == 1)
            {
                MessageBox.Show(booksCheckedIn + " was checked in by " + patronList[index].FirstName + " " +
                patronList[index].LastName);
                button_ReNew.Enabled = false;
                button_CheckIn.Enabled = false;
            }
            else
            {
                MessageBox.Show(booksCheckedIn + " were checked in by " + patronList[index].FirstName + " " +
                patronList[index].LastName);
                button_ReNew.Enabled = false;
                button_CheckIn.Enabled = false;
            }

        //remove books/patrons from the overdue list
 
            listBox_OverdueBooks.Items.Clear();
            for (int i = 0; i < patronList[index].MyBooks.Count; i++)
            {
                listBox_OverdueBooks.Items.Add(patronList[index].getBook(i).Title.ToString());
            }
            if (patronList[index].MyBooks.Count == 0)
            {
                listBox_patronOverdue.Items.Clear();
                for (int i = 0; i < patronList[index].MyBooks.Count; i++)
                    listBox_patronOverdue.Items.Add(patronList[index].getBook(i).Title.ToString());
            }

            


            //puts data into the patron's history array
            DateTime dt = DateTime.Now;
            for (int i = 0; i < s.Count; i++)
            {
                PatronsHistory[index] += "-" + s[i] + "-checked in-" + dt.ToShortDateString();
                patronList[index].SetHistory(PatronsHistory[index]);
            }

            //puts the patron's history data into the text file
            using (StreamWriter sw = new StreamWriter("..\\..\\PatronHistory.txt"))
            {
                foreach (var item in PatronsHistory)
                {
                    sw.Write(item + "*");
                }
                sw.Close();
            }

            //puts data into the book's history array
            for (int i = 0; i < s.Count; i++)
            {
                for (int j = 0; j < bookInventoryList.Count; j++)
                {
                    if (bookInventoryList[j].Title == s[i])
                    {
                        BookHistory[j] += "-" + patronList[index].FirstName + " " + patronList[index].LastName + "-checked in-" + dt.ToShortDateString();
                        bookInventoryList[j].SetHistory(BookHistory[j]);
                    }
                }
            }

            //puts the book's history data into the text file
            using (StreamWriter sw = new StreamWriter("..\\..\\BookHistory.txt"))
            {
                foreach (var item in BookHistory)
                {
                    sw.Write(item + "*");
                }
                sw.Close();
            }
        }

        //renew
        private void button_ReNew_Click(object sender, EventArgs e)
        {
            List<string> r = new List<string>();
            int index = listBoxCheckIn.SelectedIndex;

            DateTime newtime = DateTime.Parse(dateTimePicker_ReNew.Text.ToString());

           // int result = DateTime.Compare(bookInventoryList[index].DueDates[index], DateTime.Now);

            int result = DateTime.Compare(bookInventoryList[index].DueDates[index], newtime);

            foreach (object itemChecked in checkedListBoxCheckIn.CheckedItems)
            {
                r.Add(itemChecked.ToString());
            }

            for (int i = 0; i < r.Count; i++)
            {
                for (int j = 0; j < bookInventoryList.Count; j++)
                {
                    if (r[i] == bookInventoryList[j].Title)
                    {
                        for (int k = 0; k < bookInventoryList[index].DueDates.Count; k++)
                        {
                            bookInventoryList[index].DueDates.RemoveAt(k);
                            bookInventoryList[index].DueDates.Insert(k, newtime);

                        }
                       // break;
                    }
                }
            }


            if (result < 0)
            {

                try
                {
                    if (result < 0)
                    {
                        
                        foreach (object itemChecked in checkedListBoxCheckIn.CheckedItems)
                            listBox_OverdueBooks.Items.Remove(itemChecked.ToString());
                        

                        //listBox_patronOverdue.Items.Clear();
                        //if (patronList[index].MyBooks.Count == 0)
                        //{
                            
                        //    for (int i = 0; i < patronList[index].MyBooks.Count; i++)
                        //        listBox_patronOverdue.Items.Add(patronList[index].getBook(i).Title.ToString());
                        //}

                        string[] PatronsOverdue = new string[listBox_patronOverdue.Items.Count];

                        for (int i = 0; i < listBox_patronOverdue.Items.Count; i++)
                        {
                            PatronsOverdue[i] = listBox_patronOverdue.Items[i].ToString();

                        }
                        if (PatronsOverdue.Contains(listBoxCheckIn.SelectedItem.ToString()))
                        {
                            listBox_patronOverdue.Items.Remove(listBoxCheckIn.SelectedItem.ToString());
                        }
                        //listBox_OverdueBooks.Update();
                       // listBox_patronOverdue.Update();
                       
                        
                    }   
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured");
                }
            }

                string booksRenewed = "";
                for (int i = 0; i < r.Count; i++)
                {
                    if (i == 0)
                        booksRenewed = booksRenewed + r[i];
                    else if (i > 0 && i < r.Count - 1)
                        booksRenewed = booksRenewed + ", " + r[i];
                    else
                        booksRenewed = booksRenewed + " and " + r[i];
                }

                if (r.Count == 1)
                {
                    MessageBox.Show(booksRenewed + " was renewed by " + patronList[index].FirstName + " " +
                    patronList[index].LastName + " until " + dateTimePicker_ReNew.Text.ToString());
                    button_ReNew.Enabled = false;
                    button_CheckIn.Enabled = false;
                }
                else
                {
                    MessageBox.Show(booksRenewed + " were renewed by " + patronList[index].FirstName + " " +
                    patronList[index].LastName + " until " + dateTimePicker_ReNew.Text.ToString());
                    button_ReNew.Enabled = false;
                    button_CheckIn.Enabled = false;
                }
            }

        ////////displays books that are due at a selected date from the calender
        private void monthCalendar_overdue_DateSelected(object sender, DateRangeEventArgs e)
        {
            
            richTextBox_overdue.Text = "patron 1 and book1 are due";
        }
       
        }
    }



