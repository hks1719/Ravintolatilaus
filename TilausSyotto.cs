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
        public SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Ravintola.mdf;Integrated Security=True;Connect Timeout=30");
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
            if (tilausIDTextBox.Text == "")
            {
                MessageBox.Show("Ole hyvä ja syötä Tilaus");
            }
            else if (kommenttiTextBox.Text == "")
            {
                MessageBox.Show("Ole hyvä ja syötä Kommentti");
            }

            else
            {
                //tallentaa syötetyt tiedot
                string tilausIds = tilausIDTextBox.Text;
                string kommenntis = kommenttiTextBox.Text;
                string poyta_Ids = poyta_poytaIDTextBox.Text;
                string ruokalistas = ruokalista_annosTextBox.Text;
                string henkilokunta_ids = henkilokunta_idTextBox.Text;

                string query;
                SqlCommand cmd;

                //using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Ravintola.mdf;Integrated Security=True;Connect Timeout=30"))
                try
                {
                    query = "INSERT INTO[dbo].[tilaus]([tilausID], [kommentti], [poyta_poytaID], [ruokalista_annos], [henkilokunta_id], [auki])";
                    query += String.Format("VALUES (@tilausIds, @kommenntis, @poyta_Ids, @ruokalistas, @henkilokunta_ids, NULL)");

                    cmd = new SqlCommand(query, cn);
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@tilausIds", tilausIDTextBox.Text);
                    cmd.Parameters.AddWithValue("@kommenntis", kommenttiTextBox.Text);
                    cmd.Parameters.AddWithValue("@poyta_Ids", poyta_poytaIDTextBox.Text);
                    cmd.Parameters.AddWithValue("@ruokalistas", ruokalista_annosTextBox.Text);
                    cmd.Parameters.AddWithValue("@henkilokunta_ids", henkilokunta_idTextBox.Text);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successful!!");

                }
                catch (SqlException ex)
                {
                    throw new Exception("Error Inserting", ex);
                }
                finally
                {
                    cn.Close();
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

        private void palaaTarjoilijaNayttoon_Click_1(object sender, EventArgs e)
        {

        }
    }
}
