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
    public partial class Ruokalista : Form
    {
        public Ruokalista()
        {
            InitializeComponent();

            paluuTarjoilijaNayttoon.Click += PaluuTarjoilijaNayttoon_Click;
        }

        private void PaluuTarjoilijaNayttoon_Click(object sender, EventArgs e)
        {
            Tarjoilija tarjoilija = new Tarjoilija();
            this.Close();
            tarjoilija.Show();
        }

        private void ruokalistaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ruokalistaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ravintolaDataSet1);

        }

        private void Ruokalista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ravintolaDataSet1.ruokalista' table. You can move, or remove it, as needed.
            this.ruokalistaTableAdapter.Fill(this.ravintolaDataSet1.ruokalista);

        }
    }
}
