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
using System.Drawing.Printing;
using System.IO;


namespace ProdavnicaIgracaka
{
    public partial class Racun : Form
    {
        Baza baza = new Baza();


        public Racun()
        {
            InitializeComponent();

        }

        private void dgvProizvodi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtProizvod.Text = dgvProizvodi.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            try
            {
                baza.otvoriKonekciju();
                string query = "sp_UnosStavkiRacuna";
                SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@nazivPro", txtProizvod.Text);
                com.Parameters.AddWithValue("@kol", numericUpDown1.Value.ToString());
                com.ExecuteNonQuery();

                SqlDataAdapter adpt = new SqlDataAdapter("Select proizvod.idP as 'Šifra artikla',nazivP as 'Naziv proizvoda', kupljenaKol as 'Količina', cenaP as 'Cena' from proizvod, stavke_racuna where proizvod.idP=stavke_racuna.idP and idR=(select max(idR) from racun)", baza.Sqlcon);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dgvStavkeRacuna.DataSource = dt;
                //com.CommandType = CommandType.Text;

                SqlCommand command = new SqlCommand("Select ukupanIznos from racun where idR=(select max(idR) from racun)", baza.Sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtUkupanIznos.Text = reader.GetValue(0).ToString();
                }
                reader.Close();
                command.ExecuteNonQuery();

                baza.zatvoriKonekciju();
            }
            catch
            {
                MessageBox.Show("Nema dovoljno proizvoda na stanju");
                baza.zatvoriKonekciju();
            }
        }


        private void btnSacuvajRacun_Click(object sender, EventArgs e)
        {

            baza.otvoriKonekciju();
            string query = "sp_StornirajStavku";
            SqlCommand com = new SqlCommand(query, baza.Sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@idP", txtStorniranje.Text);
            com.ExecuteNonQuery();

            SqlCommand command = new SqlCommand("Select ukupanIznos from racun where idR=(select max(idR) from racun)", baza.Sqlcon);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtUkupanIznos.Text = reader.GetValue(0).ToString();
            }
            reader.Close();
            command.ExecuteNonQuery();

            SqlDataAdapter adpt = new SqlDataAdapter("Select proizvod.idP as 'Šifra artikla',nazivP as 'Naziv proizvoda', kupljenaKol as 'Količina' from proizvod, stavke_racuna where proizvod.idP=stavke_racuna.idP and idR=(select max(idR) from racun)", baza.Sqlcon);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dgvStavkeRacuna.DataSource = dt;

            baza.zatvoriKonekciju();
        }

        private void dgvStavkeRacuna_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtStorniranje.Text = dgvStavkeRacuna.SelectedRows[0].Cells[0].Value.ToString();
        }


        private void Racun_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                UpdateColorControls(c);
            }

            // TODO: This line of code loads data into the 'kategorija.KATEGORIJA' table. You can move, or remove it, as needed.
            this.kATEGORIJATableAdapter.Fill(this.kategorija.KATEGORIJA);
            // TODO: This line of code loads data into the 'kategorije.KATEGORIJA' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'prodavnicaIgracakaDataSet.KATEGORIJA' table. You can move, or remove it, as needed.

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


        private void cbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            SqlDataAdapter adpt = new SqlDataAdapter("Select idP, nazivP as 'Naziv proizvoda',cenaP as 'Cena' from proizvod, kategorija where proizvod.idKat=kategorija.idKat and nazivKat='" + cbKategorija.Text + "'", baza.Sqlcon);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dgvProizvodi.DataSource = dt;
            baza.zatvoriKonekciju();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            SqlCommand command = new SqlCommand("select IDENT_CURRENT('racun')", baza.Sqlcon);
            SqlDataReader reader = command.ExecuteReader();

            string brRacuna = "";

            while (reader.Read())
            {
                brRacuna = reader.GetValue(0).ToString();
            }
            reader.Close();
            MessageBox.Show("Račun je sačuvan pod brojem: " + brRacuna);
            baza.zatvoriKonekciju();
            this.Close();

        }

        private void btnStampaj_Click(object sender, EventArgs e)
        {
            StampaRacuna frmStampa = new StampaRacuna();
            frmStampa.Show();
            
        }

    }
}
