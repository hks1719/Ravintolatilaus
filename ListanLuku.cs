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
    public partial class ListanLuku : Form
    {

        public ListanLuku()
        {
            InitializeComponent();

        }

        public void ListanLuku_load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ravintolaDataSet1.poyta' table. You can move, or remove it, as needed.
            this.poytaTableAdapter.Fill(this.ravintolaDataSet1.poyta);

        }


        public void MuokkaaListaa_Click(object sender, EventArgs e)
        {

        }

        public void Sulje_Click(object sender, EventArgs e)
        {
            Esimies esimies = new Esimies();
            Close();
            esimies.Show();
        }
    }
}