﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bookstore
{
    public partial class Form_AboutUs : Form
    {
        public Form_AboutUs()
        {
            InitializeComponent();
        }

        private void buttonAboutOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}