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
    public partial class FormBookHistory : Form
    {
        public FormBookHistory()
        {
            InitializeComponent();
        }

        private void buttonHistoryOK2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBookHistory_Load(object sender, EventArgs e)
        {
            richTextBoxBookHistory.Text = FormHome.BookHistory[FormHome.sIndexBook];
        }
    }
}
