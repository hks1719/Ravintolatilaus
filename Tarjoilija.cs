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
    public partial class Tarjoilija : Form
    {
        public Tarjoilija tarjoilija;

        public Tarjoilija()
        {
            InitializeComponent();
            //lasku painike
            lasku.Click += Lasku_Click;
        }

        //lasku painike
        private void Lasku_Click(object sender, EventArgs e)
        {
            lasku lasku = new lasku();
            lasku.Show();
        }

        public Tarjoilija(Tarjoilija tarjoilija)
        {
            InitializeComponent();
            this.tarjoilija = tarjoilija;
        }

        private void uusiTilaus_Click(object sender, EventArgs e)
        {
            TilausSyotto f2 = new TilausSyotto();
            f2.ShowDialog();
        }
    }
}
