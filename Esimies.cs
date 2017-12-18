using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ravintolatilaus
{
    public partial class Esimies : Form
    {
        public Esimies()
        {
            InitializeComponent();
            Takaisin.Click += Takaisin_Click;
            Tilaukset.Click += Tilaukset_Click;
            Poydat.Click += Poydat_Click;
            Ruokalista.Click += Ruokalista_Click;
        }

        // Takaisin päävalikkoon 
        private void Takaisin_Click(object sender, EventArgs e)
        {
            AloitusUI aloitusUI = new AloitusUI();
            this.Close();
            aloitusUI.Show();
            
        }

        // Hae tilaukset
        private void Tilaukset_Click(object sender, EventArgs e)
        {
          
        }

        // Tarkastele pöytävaraustilannetta
        public void Poydat_Click(object sender, EventArgs e)
        {
            ListanLuku listanLuku = new ListanLuku();
            this.Close();
            listanLuku.Show();
        }

        // Näytä ruokalista
        private void Ruokalista_Click(object sender, EventArgs e)
        {
            Ruokalista ruokalista = new Ruokalista();
            this.Close();
            ruokalista.Show();
        }
    }
    }
