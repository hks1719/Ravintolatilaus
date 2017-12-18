using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ravintolatilaus
{
    public partial class TilausLista : Form
    {
        public TilausLista()
        {
            InitializeComponent();
        }

        public void TilausLista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ravintolaDataSet2.tilaus' table. You can move, or remove it, as needed.
            this.tilausTableAdapter.Fill(this.ravintolaDataSet2.tilaus);

        }

        public void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tilausTableAdapter.FillBy(this.ravintolaDataSet2.tilaus);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        public void TakaisinEsimies_Click(object sender, EventArgs e)
        {
            Esimies esimies = new Esimies();
            Close();
            esimies.Show();
        }
    }
}
