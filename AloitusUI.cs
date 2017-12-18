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

        public AloitusUI()
        {
            InitializeComponent();

            //tarjoilijapainike
            tarjoilija.Click += Tarjoilija_Click;

            //esimiespainike
            pomo.Click += pomo_Click;
   
        }

        //tarjoilijapainike
        private void Tarjoilija_Click(object sender, EventArgs e)
        {
            Tarjoilija tarjoilija = new Tarjoilija();
            this.Close();
            tarjoilija.Show();
        }

        public void Sulje_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pomo_Click(object sender, EventArgs e)
        {
            Esimies esimies = new Esimies();
            this.Close();
            esimies.Show();
        }

        private void tarjoilija_Click_1(object sender, EventArgs e)
        {
            //Jos nämä koodit ovat aktiiviset, tulee tarjoilijanäyttö kahteen kertaan esille, kokonaan tätä ei voi poistaa kun tulee error ilmoitusta.
            //Tarjoilija tarjoilija = new Tarjoilija();
            //this.Close();
            //tarjoilija.Show();
        }
    }
}
