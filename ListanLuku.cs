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
    public partial class lluku : Form
    {
        public void ListanLuku_load(object sender, EventArgs e)
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

            // SQL-käsky ja yhteys auki (parametreina)
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
            // Suljetaan lukija
            reader.Close();
            // Suljetaan tietokantayhteys
            con.Close();
            // Sijoitetaan String-tyyppiseksi muunnetut tietokantahaun tulokset taulukkoon 
            string[] poytatilanne = tempList.ToArray();

            // Jatkuu tästä siten että taulukon sisältö saadaan ListanLuku-ikkunaan auki

            // Luodaan tulostusta varten meny-muuttuja, johon sijoitetaan funktion avulla tiedot
            String meny = "";
            printPreviewControl1.Text = meny = ListaLuku(poytatilanne);
    
        }

        // Sijoitetaan poytatilanne taulukon tiedot joinilla string-tyyppiseen muuttujaan, jonka arvo palautetaan 
        public string ListaLuku(string[] poytatilanne)
        {
            return String.Join("", poytatilanne);
        }


        public void MuokkaaListaa_Click(object sender, EventArgs e)
        {

        }

        public void Sulje_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}