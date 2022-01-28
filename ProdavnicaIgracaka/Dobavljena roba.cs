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
namespace ProdavnicaIgracaka
{
    public partial class DobavljenaRoba : Form
    {
        Baza baza = new Baza();
        public DobavljenaRoba()
        {
            InitializeComponent();
            prikazProizvoda();
        }

        private void btnZavrsiNabavku_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DobavljenaRoba_Load(object sender, EventArgs e)
        {

            foreach (Control c in this.Controls)
            {
                UpdateColorControls(c);
            }

            // TODO: This line of code loads data into the 'prikazProizvoda1.prikazProizvoda' table. You can move, or remove it, as needed.
            //this.prikazProizvodaTableAdapter.Fill(this.prikazProizvoda1.prikazProizvoda);
            prikazProizvoda();


        }

        public void UpdateColorControls(Control dugme)
        {
            if (dugme is Button)
            {
                dugme.BackColor = Color.LightBlue;
            }

            foreach (Control subC in dugme.Controls)
            {
                UpdateColorControls(subC);
            }
        }

        public void prikazProizvoda()
        {
            baza.otvoriKonekciju();
            SqlDataAdapter adpt = new SqlDataAdapter("Select idP as 'Šifra artikla',nazivP as 'Naziv proizvoda',cenaP as 'Cena',ukupnaKol as 'Kolicina', nazivKat as 'Kategorija',nazivB as 'Brend' from proizvod, kategorija, brend where kategorija.idKat=proizvod.idKat and brend.idB=proizvod.idB", baza.Sqlcon);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dgvProizvodi.DataSource = dt;
            string query = "prikazProizvoda";
            SqlCommand com = new SqlCommand(query, baza.Sqlcon);
            com.CommandType = CommandType.Text;
            baza.zatvoriKonekciju();

        }

        private void btnStavkeNabavke_Click(object sender, EventArgs e)
        {
            try
            {
                baza.otvoriKonekciju();
                string query = "sp_UnosDobavljeneRobe";
                SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@nazivPro", textBox1.Text.Split(',')[0]);
                com.Parameters.AddWithValue("@kol", numericUpDown1.Value.ToString());
                com.ExecuteNonQuery();

                SqlDataAdapter adpt = new SqlDataAdapter("Select proizvod.idP as 'Šifra artikla',nazivP as 'Naziv proizvoda', Nkolicina as 'Količina' from proizvod, stavke_nabavke where proizvod.idP=stavke_nabavke.idP and idN=(select max(idN) from nabavka)", baza.Sqlcon);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dgvStavkeNabavke.DataSource = dt;
                com.CommandType = CommandType.Text;

                baza.zatvoriKonekciju();

                prikazProizvoda();
            }
            catch
            {
                MessageBox.Show("Nije moguće napraviti još jednu stavku nabavke za isti proizvod.");
            }
        }

        private void dgvProizvodi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dgvProizvodi.SelectedRows[0].Cells[1].Value.ToString() +","+ dgvProizvodi.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void dgvStavkeNabavke_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtStavka.Text = dgvStavkeNabavke.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                baza.otvoriKonekciju();
                string query = "sp_UkloniStavkuNabavke";
                SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@nazivPro", txtStavka.Text);
                com.ExecuteNonQuery();

                SqlDataAdapter adpt = new SqlDataAdapter("Select proizvod.idP as 'Šifra artikla',nazivP as 'Naziv proizvoda', Nkolicina as 'Količina' from proizvod, stavke_nabavke where proizvod.idP=stavke_nabavke.idP and idN=(select max(idN) from nabavka)", baza.Sqlcon);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dgvStavkeNabavke.DataSource = dt;
                com.CommandType = CommandType.Text;

                baza.zatvoriKonekciju();
                prikazProizvoda();
                MessageBox.Show("Stavka nabavke je uspešno uklonjena.");
                
            }
            catch
            {
                MessageBox.Show("Uklanjanje stavke nabavke nije uspelo.");
            }
        }
    }
}
