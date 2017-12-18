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
    public partial class RuokalistaMuokkaus : Form
    {
        public RuokalistaMuokkaus()
        {
            InitializeComponent();
        }

        private void ruokalistaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ruokalistaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ravintolaDataSet1);

        }

        private void RuokalistaMuokkaus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ravintolaDataSet1.ruokalista' table. You can move, or remove it, as needed.
            this.ruokalistaTableAdapter.Fill(this.ravintolaDataSet1.ruokalista);

        }
    }
}
