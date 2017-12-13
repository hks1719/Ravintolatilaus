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
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
            PassText1.PasswordChar = '•';
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string user = "testi.tauno";
            int pass = 1234;
            if (user == this.UserText1.Text && pass == Convert.ToInt32(this.PassText1.Text))
            {
                MessageBox.Show("Käyttäjätunnus ja salasana Täsmää");
                this.Hide();
                AloitusUI f2 = new AloitusUI();
                f2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Väärä käyttäjätunnus tai salasana. Saatanan aasi! Kirjoita tarkemmin!");
            }
        }

        private void Exit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
