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
    public partial class Lasku : Form
    {
        public SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Ravintola.mdf;Integrated Security=True;Connect Timeout=30");

        public Lasku()
        {
            InitializeComponent();

        }

        private void HaeTilaus_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

                        
            int.TryParse(comboBox1.SelectedItem.ToString(), out int poyta);
            SqlCommand cm = new SqlCommand("SELECT tilausID, poyta_poytaID, ruokalista_annos, hinta FROM dbo.tilaus JOIN dbo.ruokalista ON tilaus.ruokalista_annos = ruokalista.annos WHERE poyta_poytaID = " + poyta + " ORDER BY tilausID", cn);

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
    }
}
