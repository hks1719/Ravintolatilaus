using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Ravintolatilaus
{
    public partial class TilausSyotto : Form
    {
        public TilausSyotto()
        {
            InitializeComponent();
            palaaTarjoilijaNayttoon.Click += PalaaTarjoilijaNayttoon_Click;
        }

        //palaa tarjoilijanäyttöön painike
        private void PalaaTarjoilijaNayttoon_Click(object sender, EventArgs e)
        {
            Tarjoilija tarjoilija = new Tarjoilija();

            this.Close();
            tarjoilija.Show();


        }



        private void TilausSyottoTallenna_Click(object sender, EventArgs e)
        {
            if (poytanrotext.Text == "")
            {
                MessageBox.Show("Ole hyvä ja syötä pöytänumero");
            }
            else if (poytapaikkaNrotext.Text == "")
            {
                MessageBox.Show("Ole hyvä ja syötä asiakasnumero");
            }
            else if (alkuruokanrotext.Text == "")
            {
                MessageBox.Show("Ole hyvä ja syötä alkuruoka");
            }

            else
            {
                //tallentaa syötetyt tiedot
                string poytaNro = poytanrotext.Text;
                string asiakasNro = poytapaikkaNrotext.Text;
                string alkuruokaNro = alkuruokanrotext.Text;

                string query = "INSERT INTO poyta(poytaID) " + "Values('" + poytaNro + "')";

                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Ravintola.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }

            ////avaa tietokanta yhteyden HUOM! tee tästä funktio!!!!!!! = laskee vee käyrää merkittävästi!
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Ravintola.mdf;Integrated Security=True;Connect Timeout=30";
            //con.Open();

        }

        private void tilausBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tilausBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ravintolaDataSet1);

        }

        private void TilausSyotto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ravintolaDataSet1.tilaus' table. You can move, or remove it, as needed.
            this.tilausTableAdapter.Fill(this.ravintolaDataSet1.tilaus);
            // TODO: This line of code loads data into the 'ravintolaDataSet1.tilaus' table. You can move, or remove it, as needed.
            this.tilausTableAdapter.Fill(this.ravintolaDataSet1.tilaus);

        }

        private void tilausBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tilausBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ravintolaDataSet1);

        }
    }
}
