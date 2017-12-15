using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ravintolatilaus
{
    public partial class lasku : Form
    {
        public lasku()
        {
            InitializeComponent();

            paluuTarjoilijaNayttoon.Click += PaluuTarjoilijaNayttoon_Click;
        }

        //paluu tarjoilijanäyttöö painike
        private void PaluuTarjoilijaNayttoon_Click(object sender, EventArgs e)
        {
            Tarjoilija tarjoilija = new Tarjoilija();
            this.Close();
            tarjoilija.Show();
        }
    }
}
