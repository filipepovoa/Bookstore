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
    public partial class FormPatronHistory : Form
    {
        public FormPatronHistory()
        {
            InitializeComponent();
        }

        private void buttonHistoryOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPatronHistory_Load(object sender, EventArgs e)
        {
            richTextBoxPatronHistory.Text = FormHome.PatronsHistory[FormHome.sIndexPatron];
        }
    }
}
