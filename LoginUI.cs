using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Ravintolatilaus
{
    public partial class LoginUI : Form
    {
        ////MSSQL Tietokanta koodi
        //SqlConnection con = new SqlConnection();
        public LoginUI()
        {
            ////MSSQL Tietokanta koodi
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=PETTERIS-PC2\\SQLEXPRESSKOULU;Initial Catalog=Ravintola;Integrated Security=True";
            InitializeComponent();
            PassText1.PasswordChar = '•';
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ////MSSQL Tietokanta koodi
            //// TODO: This line of code loads data into the 'sTUDENTDataSet.login' table. You can move, or remove it, as needed.  
            ////this.loginTableAdapter.Fill(this.sTUDENTDataSet.login);  
            //SqlConnection con = new SqlConnection("Data Source=PETTERIS-PC2\\SQLEXPRESSKOULU;Initial Catalog=Ravintola;Integrated Security=True");
            //con.Open();

            //{
            //}
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            //Kirjautumis koodi Formssissa määritellyillä tunnuksilla


            string user = "testi.tauno";
            int pass = 12345;
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

            ////MSSQL Tietokanta koodi
            ////Kirjautuminen SQL kannasta katsoen
            ////
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=PETTERIS-PC2\\SQLEXPRESSKOULU;Initial Catalog=Ravintola;Integrated Security=True";
            //con.Open();
            //string userid = UserText1.Text;
            //string password = PassText1.Text;
            //SqlCommand cmd = new SqlCommand("select userid,password from login where userid='" + UserText1.Text + "'and password='" + PassText1.Text + "'", con);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    MessageBox.Show("Käyttäjätunnus ja salasana Täsmää");
            //    this.Hide();
            //    AloitusUI f2 = new AloitusUI();
            //    f2.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Väärä käyttäjätunnus tai salasana. Saatanan aasi! Kirjoita tarkemmin!");
            //}
            //con.Close();

        }

        private void Exit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
