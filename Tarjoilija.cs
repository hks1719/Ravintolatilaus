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
            tilaus.Click += tilaus_Click;
            paluuAloitusnayttoon.Click += PaluuAloitusnayttoon_Click;
            ruokalista.Click += Ruokalista_Click;
            lasku.Click += lasku_Click;

        
        }

        private void Ruokalista_Click(object sender, EventArgs e)
        {
            Ruokalista ruokalista = new Ruokalista();
            this.Close();
            ruokalista.Show();

        }

        //Paluu Aloitusnäyttöön painike
        private void PaluuAloitusnayttoon_Click(object sender, EventArgs e)
        {
            AloitusUI aloitusUI = new AloitusUI();
            this.Close();
            aloitusUI.Show();
        }

        //tilaus painike
        private void tilaus_Click(object sender, EventArgs e)
        {
            tilaus tilaus = new tilaus();
            this.Close();
            tilaus.Show();
        }

        public Tarjoilija(Tarjoilija tarjoilija)
        {
            InitializeComponent();
            this.tarjoilija = tarjoilija;
        }

        //private void uusiTilaus_Click(object sender, EventArgs e)
        //{
        //    TilausSyotto f2 = new TilausSyotto();
        //    this.Close();
        //    f2.ShowDialog();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            TilausSyotto f2 = new TilausSyotto();
            this.Close();
            f2.ShowDialog();
        }

        private void lasku_Click(object sender, EventArgs e)
        {
            Lasku lasku = new Lasku();
            this.Close();
            lasku.Show();
        }
    }
}
