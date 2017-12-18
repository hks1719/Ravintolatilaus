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
            ruokalistanMuokkaus.Click += RuokalistanMuokkaus_Click;
            paluuEsimiehenNayttoon.Click += PaluuEsimiehenNayttoon_Click;

        }

        private void PaluuEsimiehenNayttoon_Click(object sender, EventArgs e)
        {
            Esimies esimies = new Esimies();
            this.Close();
            esimies.Show();
        }

        private void RuokalistanMuokkaus_Click(object sender, EventArgs e)
        {
            RuokalistaMuokkaus ruokalistaMuokkaus = new RuokalistaMuokkaus();
            this.Close();
            ruokalistaMuokkaus.Show();
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
