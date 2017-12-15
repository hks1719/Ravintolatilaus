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

        // SQL - yhteyden avaus funktio 
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

        // Hae tilaukset joiden tila on avoinna
        private void Avoimet_Click(object sender, EventArgs e)
        {
          
        }

        // Hae tilaukset joiden tila on valmis
        private void Valmiit_Click(object sender, EventArgs e)
        {
         
        }

        // Tarkastele pöytävaraustilannetta
        public void Poydat_Click(object sender, EventArgs e)
        {
           
            // Tilapäinen säilytyspaikka 
            List<string> tempList = new List<string>();
            // Nollataan lukija
            SqlDataReader reader = null;
            // Nollataan käsky
            SqlCommand cmd = null;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Ravintola.mdf;Integrated Security=True;Connect Timeout=30";
            con.Open();

            // SQL-käsky muuttujaan 
            string CmdText = "SELECT * FROM poyta";

            // SQL-käsky ja yhteys auki
            cmd = new SqlCommand(CmdText, con);

            // Luetaan tietokantataulun tiedot
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    tempList.Add(reader[0].ToString() + " " + reader[1].ToString());
                }
            }
            reader.Close();
            con.Close();
            // Sijoitetaan String-tyyppiseksi muunnetut tietokantahaun tulokset taulukkoon 
            string[] poytatilanne = tempList.ToArray();

            // Jatkuu tästä siten että taulukon sisältö saadaan ListanLuku-ikkunaan auki
        }
    }
    }
