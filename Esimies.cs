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

        lluku lluku = new lluku();

        // SQL - yhteyden avaus funktio - ei toiminut tällä??
        //public void Avaayhteys()
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Ravintola.mdf;Integrated Security=True;Connect Timeout=30";
        //    con.Open();
        //}    

        // Takaisin päävalikkoon 
        private void Takaisin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Hae tilaukset
        private void Tilaukset_Click(object sender, EventArgs e)
        {
          
        }

        // Tarkastele pöytävaraustilannetta
        public void Poydat_Click(object sender, EventArgs e)
        {
            lluku.Show();   
        }
    }
    }
