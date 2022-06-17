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
    public partial class FormPatronEdit : Form
    {
        public FormPatronEdit()
        {
            InitializeComponent();
        }

        private void buttonPatronCancelEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPatronEdit_Click(object sender, EventArgs e)
        {
            FormHome.patronList.RemoveAt(FormHome.sIndexPatron);

            string fN = textBoxPatronFNameEdit.Text;
            string lN = textBoxPatronLNameEdit.Text;
            string addre = textBoxPatronAddressEdit.Text;
            string town = textBoxPatronTownEdit.Text;
            string state = textBoxPatronStateEdit.Text;
            string zip = textBoxPatronZipEdit.Text;
            string phone = textBoxPatronPhoneEdit.Text;
            string email = textBoxPatronEmailEdit.Text;

            Patron p = new Patron(fN, lN, addre, town, state, zip, phone, email);
            FormHome.patronList.Add(p);

            MessageBox.Show("This patron has been edited!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            for (int i = 0; i < FormHome.patronList.Count - 1; i++)
            {
                for (int j = i + 1; j < FormHome.patronList.Count; j++)
                {
                    int result = string.Compare(FormHome.patronList[i].LastName, FormHome.patronList[j].LastName);

                    if (result > 0)
                    {
                        Patron t = FormHome.patronList[i];
                        FormHome.patronList[i] = FormHome.patronList[j];
                        FormHome.patronList[j] = t;
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter("..\\..\\Patrons.txt"))
            {
                foreach (var item in FormHome.patronList)
                {
                    sw.WriteLine(item.FirstName + "," + item.LastName + "," + item.Address + "," +
                        item.Town + "," + item.State + "," + item.Zip + "," + item.Phone + "," + item.Email);
                }
                sw.Close();
            }
        }

        private void FormPatronEdit_Load(object sender, EventArgs e)
        {
            textBoxPatronFNameEdit.Text = FormHome.patronList[FormHome.sIndexPatron].FirstName;
            textBoxPatronLNameEdit.Text = FormHome.patronList[FormHome.sIndexPatron].LastName;
            textBoxPatronAddressEdit.Text = FormHome.patronList[FormHome.sIndexPatron].Address;
            textBoxPatronTownEdit.Text = FormHome.patronList[FormHome.sIndexPatron].Town;
            textBoxPatronStateEdit.Text = FormHome.patronList[FormHome.sIndexPatron].State;
            textBoxPatronZipEdit.Text = FormHome.patronList[FormHome.sIndexPatron].Zip;
            textBoxPatronPhoneEdit.Text = FormHome.patronList[FormHome.sIndexPatron].Phone;
            textBoxPatronEmailEdit.Text = FormHome.patronList[FormHome.sIndexPatron].Email;
        }
    }
}
