﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AboutUsers : Form
    {
        public AboutUsers()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            UserHomePage hp2 = new UserHomePage();
            this.Hide();
            hp2.Show();
        }
    }
}
