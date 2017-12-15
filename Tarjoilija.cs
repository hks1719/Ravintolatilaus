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
            //painikkeet
            lasku.Click += Lasku_Click;
            paluuAloitusnayttoon.Click += PaluuAloitusnayttoon_Click;

        
        }
        
        //Paluu Aloitusnäyttöön painike
        private void PaluuAloitusnayttoon_Click(object sender, EventArgs e)
        {
            AloitusUI aloitusUI = new AloitusUI();
            this.Close();
            aloitusUI.Show();
        }

        //lasku painike
        private void Lasku_Click(object sender, EventArgs e)
        {
            lasku lasku = new lasku();
            this.Close();
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
            this.Close();
            f2.ShowDialog();
        }
    }
}
