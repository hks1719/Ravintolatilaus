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
        }

        // Takaisin päävalikkoon 
        private void Takaisin_Click(object sender, EventArgs e)
        {
            AloitusUI aloitusUI = new AloitusUI();
            Close();
            aloitusUI.Show();      
        }

        // Hae tilaukset
        public void Tilaukset_Click(object sender, EventArgs e)
        {
            TilausLista tilaukset = new TilausLista();
            Close();
            tilaukset.Show();
        }

        // Tarkastele pöytävaraustilannetta
        private void Poydat_Click(object sender, EventArgs e)
        {
            ListanLuku listanLuku = new ListanLuku();
            Close();
            listanLuku.Show();
        }

        // Näytä ruokalista
        private void Ruokalista_Click(object sender, EventArgs e)
        {
            Ruokalista ruokalista = new Ruokalista();
            Close();
            ruokalista.Show();
        }
    }
    }
