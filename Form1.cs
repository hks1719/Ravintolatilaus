﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ravintolatilaus
{
    public partial class Form1 : Form
    {
        Esimies esimies = new Esimies();

        public Form1()
        {
            InitializeComponent();
   
        }

        public void Sulje_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pomo_Click(object sender, EventArgs e)
        {
            esimies.Show();
        }
    }
}
