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
    public partial class AloitusUI : Form
    {
        Esimies esimies = new Esimies();

        

        public AloitusUI()
        {
            InitializeComponent();

            //tarjoilijapainike
            tarjoilija.Click += Tarjoilija_Click;
   
        }

        //tarjoilijapainike
        private void Tarjoilija_Click(object sender, EventArgs e)
        {
            Tarjoilija tarjoilija = new Tarjoilija();
            tarjoilija.Show();
        }

        public void Sulje_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pomo_Click(object sender, EventArgs e)
        {
            esimies.Show();
        }
    }
}
