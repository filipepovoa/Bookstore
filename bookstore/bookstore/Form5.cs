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
    public partial class FormPatronAdd : Form
    {
        public FormPatronAdd()
        {
            InitializeComponent();
        }

        private void buttonPatronCancelEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPatronAdd_Click(object sender, EventArgs e)
        {
            string fN = textBoxPatronFNameAdd.Text;
            string lN = textBoxPatronLNameAdd.Text;
            string addre = textBoxPatronAddressAdd.Text;
            string town = textBoxPatronTownAdd.Text;
            string state = textBoxPatronStateAdd.Text;
            string zip = textBoxPatronZipAdd.Text;
            string phone = textBoxPatronPhoneAdd.Text;
            string email = textBoxPatronEmailAdd.Text;

            Patron p = new Patron(fN, lN, addre, town, state, zip, phone, email);
            FormHome.patronList.Add(p);

            MessageBox.Show("This patron has been added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
