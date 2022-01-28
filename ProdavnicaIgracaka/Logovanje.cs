using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace ProdavnicaIgracaka
{
    public partial class Logovanje : Form
    {
        Baza baza = new Baza();
        public Logovanje()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            String query = "SELECT * FROM ZAPOSLENI WHERE korIme='"+txtKorIme.Text+"' and lozinka ='"+txtLozinka.Text+"' and aktivan=1";
            SqlDataAdapter sda = new SqlDataAdapter(query, baza.Sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);            

            if (dtb.Rows.Count==1)
            {
                switch (dtb.Rows[0]["idPosla"])
                {
                    case 1:
                        baza.zatvoriKonekciju();
                        this.Hide();
                        Rukovodilac ruk = new Rukovodilac();
                        ruk.Show();
                        break;
                        
                    case 2:
                        this.Hide();
                        baza.zatvoriKonekciju();
                        Prodavac pro = new Prodavac(this);
                        pro.Show();
                        break;

                }

            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka");
            }

            baza.zatvoriKonekciju();
            txtKorIme.Text = "";
            txtLozinka.Text = "";
            
        }

        private void Logovanje_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
