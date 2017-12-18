using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Ravintolatilaus
{
    public partial class Kokki : Form
    {
        public SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Ravintola.mdf;Integrated Security=True;Connect Timeout=30");

        public Kokki()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AloitusUI aloitusUI = new AloitusUI();
            this.Close();
            aloitusUI.Show();
        }

        private void kokki_Shown(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void tilausBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tilausBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ravintolaDataSet1);

        }

        private void tilausBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tilausBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ravintolaDataSet1);

        }

        private void tilausBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.tilausBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ravintolaDataSet1);

        }

        private void Kokki_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ravintolaDataSet1.tilaus' table. You can move, or remove it, as needed.
            this.tilausTableAdapter.Fill(this.ravintolaDataSet1.tilaus);

        }

        private void tilausListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();

            SqlCommand cm = new SqlCommand("SELECT * FROM dbo.tilaus ORDER BY TilausId ASC", cn);

            try
            {
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["TilausID"].ToString());
                    item.SubItems.Add(dr["kommentti"].ToString());
                    item.SubItems.Add(dr["poyta_poytaID"].ToString());
                    item.SubItems.Add(dr["ruokalista_annos"].ToString());
                    item.SubItems.Add(dr["henkilokunta_id"].ToString());
                    item.SubItems.Add(dr["auki"].ToString());

                    listView1.Items.Add(item);
                }
            }
            catch(Exception ex)
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
