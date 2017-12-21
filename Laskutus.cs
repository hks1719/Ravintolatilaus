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
    public partial class Laskutus : Form

    {
        public SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Ravintola.mdf;Integrated Security=True;Connect Timeout=30");


        public Laskutus()
        {
            InitializeComponent();
        }

        private void tilausBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tilausBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ravintolaDataSet1);

        }

        private void Laskutus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ravintolaDataSet1.tilaus' table. You can move, or remove it, as needed.
            this.tilausTableAdapter.Fill(this.ravintolaDataSet1.tilaus);

        }

        public void button1_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();


            int.TryParse(comboBox1.SelectedItem.ToString(), out int poyta);
            SqlCommand cm = new SqlCommand("SELECT tilausID, poyta_poytaID, ruokalista_annos, hinta FROM tilaus JOIN ruokalista ON tilaus.ruokalista_annos = ruokalista.annos WHERE poyta_poytaID = " + poyta + " ORDER BY tilausID", cn);

            try
            {
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["tilausID"].ToString());
                    
                    item.SubItems.Add(dr["poyta_poytaID"].ToString());
                    item.SubItems.Add(dr["ruokalista_annos"].ToString());
                    item.SubItems.Add(dr["hinta"].ToString());



                    listView1.Items.Add(item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tarjoilija tarjoilija = new Tarjoilija();
            this.Close();
            tarjoilija.Show();
        }
    }
}
