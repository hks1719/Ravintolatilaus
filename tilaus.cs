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
    public partial class tilaus : Form
    {
        public tilaus()
        {
            InitializeComponent();

            paluuTarjoilijaNayttoon.Click += PaluuTarjoilijaNayttoon_Click;
        }

        //paluu tarjoilijanäyttöö painike
        private void PaluuTarjoilijaNayttoon_Click(object sender, EventArgs e)
        {
            Tarjoilija tarjoilija = new Tarjoilija();
            this.Close();
            tarjoilija.Show();
        }

        private void tilausBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tilausBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ravintolaDataSet1);

        }

        private void lasku_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ravintolaDataSet1.tilaus' table. You can move, or remove it, as needed.
            this.tilausTableAdapter.Fill(this.ravintolaDataSet1.tilaus);

        }
    }
}
