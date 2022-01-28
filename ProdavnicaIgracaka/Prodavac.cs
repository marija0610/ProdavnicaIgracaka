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
using Microsoft.QualityTools.Testing.Fakes;

namespace ProdavnicaIgracaka
{
    public partial class Prodavac : Form
    {
        Baza baza = new Baza();
        Logovanje frmLog;
       public string idZ;
        public Prodavac(Logovanje frmLogovanje)
        {
            InitializeComponent();
            this.frmLog = frmLogovanje;
            prilagodiDizajn();
        }


        private void prilagodiDizajn()
        {
            podmeniReklamacija.Visible = false;
            podmeniKupac.Visible = false;
            podmeniIzvestaji.Visible = false;
            podmeniOdjaviMe.Visible = false;
        }

        private void sakrijPodmeni()
        {
            if (podmeniReklamacija.Visible == true)
                podmeniReklamacija.Visible = false;
            if (podmeniKupac.Visible == true)
                podmeniKupac.Visible = false;
            if (podmeniIzvestaji.Visible == true)
                podmeniIzvestaji.Visible = false;
        }

        private void prikaziPodmeni(Panel podmeni)
        {
            if (podmeni.Visible == false)
            {
                sakrijPodmeni();
                podmeni.Visible = true;
            }
            else
                podmeni.Visible = false;
        }

        private void Prodavac_Load(object sender, EventArgs e)
        {         
            // TODO: This line of code loads data into the 'zavrseneReklamacije.view_ZavrseneReklamacije' table. You can move, or remove it, as needed.
            this.view_ZavrseneReklamacijeTableAdapter.Fill(this.zavrseneReklamacije.view_ZavrseneReklamacije);
            // TODO: This line of code loads data into the 'nezavrseneReklamacije.view_NezavrseneReklamacije' table. You can move, or remove it, as needed.
            this.view_NezavrseneReklamacijeTableAdapter.Fill(this.nezavrseneReklamacije.view_NezavrseneReklamacije);
            // TODO: This line of code loads data into the 'prodavnicaIgracakaDataSet5.view_Otpusteni' table. You can move, or remove it, as needed.
            this.view_OtpusteniTableAdapter.Fill(this.prodavnicaIgracakaDataSet5.view_Otpusteni);
            // TODO: This line of code loads data into the 'prodavnicaIgracakaDataSet2.RESENJE_REKLAMACIJE' table. You can move, or remove it, as needed.
            this.rESENJE_REKLAMACIJETableAdapter.Fill(this.prodavnicaIgracakaDataSet2.RESENJE_REKLAMACIJE);
            // TODO: This line of code loads data into the 'prodavnicaIgracakaDataSet2.STAVKE_RACUNA' table. You can move, or remove it, as needed.
            timer1.Start();
            //frmLog.Close();
            baza.otvoriKonekciju();
            SqlCommand command = new SqlCommand("Select idZ, ime, prezime from zaposleni where korIme='" + frmLog.txtKorIme.Text + "' and lozinka='" + frmLog.txtLozinka.Text + "'", baza.Sqlcon);
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                idZ = reader.GetValue(0).ToString();
                lblImePro.Text =reader.GetValue(1).ToString() +" "+ reader.GetValue(2).ToString();
                lblImePrezime.Text= reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString();
            }
            reader.Close();
            command.ExecuteNonQuery();

            baza.zatvoriKonekciju();

            dtpRokIzvrsenja.Value = dtpDatum.Value.AddDays(7);
            this.dtpRokIzvrsenja.Enabled = false;
            prikazRacuna();

        }

        private void Prodavac_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.label2.Text = dateTime.ToString();
        }

        public void prikazRacuna()
        {

            baza.otvoriKonekciju();
            string query = "sp_PrikazRacuna";
            SqlCommand com = new SqlCommand(query, baza.Sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@idZ", lblImePrezime.Text.Split(' ')[0]);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvRacuniIzv.DataSource = dt;
            baza.zatvoriKonekciju();
        }

        private void btnNapraviRacun_Click(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            string query = "sp_NapraviRacun";
            SqlCommand com = new SqlCommand(query, baza.Sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@idZ", idZ);
            com.ExecuteNonQuery();
            baza.zatvoriKonekciju();

            Racun frmRacun = new Racun();
            frmRacun.Show();
        }

        private void računToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlRacun.Visible = true;
            pnlKupac.Visible = false;
            pnlReklamacija.Visible = false;
            pnlIzmeniReklamaciju.Visible = false;
            pnlRacuniIzv.Visible = false;
            pnlReklamacijeIzv.Visible = false;
            pnlIzmeniKup.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(String.IsNullOrEmpty(txtIme.Text) || String.IsNullOrEmpty(txtPrezime.Text) || String.IsNullOrEmpty(txtAdresa.Text) || String.IsNullOrEmpty(txtTelefon.Text)))
                {
                    baza.otvoriKonekciju();
                    string query = "sp_DodajKupca";
                    SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@ime", txtIme.Text.ToString());
                    com.Parameters.AddWithValue("@prezime", txtPrezime.Text.ToString());
                    com.Parameters.AddWithValue("@adresa", txtAdresa.Text.ToString());
                    com.Parameters.AddWithValue("@email", txtEmail.Text.ToString());
                    com.Parameters.AddWithValue("@telefon", txtTelefon.Text.ToString());
                    com.ExecuteNonQuery();
                    baza.zatvoriKonekciju();
                    MessageBox.Show("Podaci su uspešno uneti!");

                    txtIme.Text="";
                    txtPrezime.Text = "";
                    txtAdresa.Text = "";
                    txtTelefon.Text = "";
                    txtEmail.Text = "";

                }
                else
                {
                    MessageBox.Show("Neophodno je uneti sve tražene podatke!");
                }
            }
            catch
            {
                MessageBox.Show("Neuspešan unos!");
            }
        }

        private void btnKupac_Click(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            String query = "SELECT * FROM KUPAC WHERE imeKup=N'"+txtKupac.Text.Split(',')[0].Trim()+"'and prezimeKup=N'"+txtKupac.Text.Split(',')[1].Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baza.Sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            dgvKupac.DataSource = dtb;

            baza.zatvoriKonekciju();
        }

        private void dgvKupac_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtIdKupca.Text = dgvKupac.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnBrRacuna_Click(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            String query = "SELECT nazivP,cenaP, kupljenaKol FROM proizvod,stavke_racuna WHERE proizvod.idP = stavke_racuna.idP and idR='"+txtBrRacuna.Text+ "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baza.Sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            dgvRacun.DataSource = dtb;

            baza.zatvoriKonekciju();
        }

        private void dgvRacun_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtProizvod.Text = dgvRacun.SelectedRows[0].Cells[0].Value.ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtpRokIzvrsenja.Value = dtpDatum.Value.AddDays(7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baza.otvoriKonekciju();
                string query = "sp_UnesiReklamaciju";
                SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@idR", txtBrRacuna.Text);
                com.Parameters.AddWithValue("@idK", txtIdKupca.Text);
                com.Parameters.AddWithValue("@nazivP", txtProizvod.Text);
                com.Parameters.AddWithValue("@datum", dtpDatum.Value.Date);
                com.Parameters.AddWithValue("@rok", dtpRokIzvrsenja.Value.Date);
                com.Parameters.AddWithValue("@resenje", cbResenje.Text);

                if (rbDa.Checked)
                    com.Parameters.AddWithValue("@zavrseno", 1);
                if (rbNe.Checked)
                    com.Parameters.AddWithValue("@zavrseno", 0);

                com.ExecuteNonQuery();

                SqlCommand command = new SqlCommand("select IDENT_CURRENT('REKLAMACIJA')", baza.Sqlcon);
                SqlDataReader reader = command.ExecuteReader();

                string brReklamacije="";

                while (reader.Read())
                {
                    brReklamacije = reader.GetValue(0).ToString();
                }
                reader.Close();

                MessageBox.Show("Reklamacija je uspesno uneta pod brojem: " + brReklamacije);
                baza.zatvoriKonekciju();

                txtKupac.Text = "";
                txtBrRacuna.Text = "";
                txtProizvod.Text = "";
                this.dgvKupac.DataSource = null;
                this.dgvKupac.Rows.Clear();
                this.dgvRacun.DataSource = null;
                this.dgvRacun.Rows.Clear();

            }
            catch
            {
                MessageBox.Show("Neuspešan unos!");
            }
        }

        private void dodajReklamacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlRacun.Visible = false;
            pnlKupac.Visible = false;
            pnlReklamacija.Visible = true;
            pnlIzmeniReklamaciju.Visible = false;
            pnlRacuniIzv.Visible = false;
            pnlReklamacijeIzv.Visible = false;
            pnlIzmeniKup.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baza.otvoriKonekciju();
                string query = "sp_IzmeniReklamaciju";
                SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@idReklamacije", txtIdReklamacije.Text.ToString());
                if (cbDa.Checked)
                    com.Parameters.AddWithValue("@prihvacena", 1);
                if (cbNe.Checked)
                    com.Parameters.AddWithValue("@prihvacena", 0);

                if (rbZav.Checked)
                    com.Parameters.AddWithValue("@zavrsena", 1);
                if (rbNZav.Checked)
                    com.Parameters.AddWithValue("@zavrsena", 0);

                com.ExecuteNonQuery();
                baza.zatvoriKonekciju();
                MessageBox.Show("Podaci su uspešno izmenjeni.");
                txtIdReklamacije.Text = "";
            }
            catch
            {
                MessageBox.Show("Izmena podataka nije uspela.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            String query = "SELECT * FROM reklamacija WHERE idReklamacije='" + txtIdReklamacije.Text + "' and zavrseno=0";
            SqlDataAdapter sda = new SqlDataAdapter(query, baza.Sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            dgvReklamacija.DataSource = dtb;

            baza.zatvoriKonekciju();
        }

        private void reklamacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlRacun.Visible = false;
            pnlKupac.Visible = false;
            pnlReklamacija.Visible = false;
            pnlIzmeniReklamaciju.Visible = false;
            pnlRacuniIzv.Visible = false;
            pnlReklamacijeIzv.Visible = true;
            pnlIzmeniKup.Visible = false;


            this.view_ZavrseneReklamacijeTableAdapter.Fill(this.zavrseneReklamacije.view_ZavrseneReklamacije);
            this.view_NezavrseneReklamacijeTableAdapter.Fill(this.nezavrseneReklamacije.view_NezavrseneReklamacije);

        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlRacun.Visible = false;
            pnlKupac.Visible = false;
            pnlReklamacija.Visible = false;
            pnlIzmeniReklamaciju.Visible = true;
            pnlRacuniIzv.Visible = false;
            pnlReklamacijeIzv.Visible = false;
            pnlIzmeniKup.Visible = false;

        }

        private void računiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlRacun.Visible = false;
            pnlKupac.Visible = false;
            pnlReklamacija.Visible = false;
            pnlIzmeniReklamaciju.Visible = false; ;
            pnlRacuniIzv.Visible = true;
            pnlReklamacijeIzv.Visible = false;
            pnlIzmeniKup.Visible = false;

            prikazRacuna();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            string query = "sp_RacuniPoDatumu";
            SqlCommand com = new SqlCommand(query, baza.Sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@idZ", lblImePrezime.Text.Split(' ')[0]);
            com.Parameters.AddWithValue("@datum",dateTimePicker1.Value);

            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvRacuniPoDatumima.DataSource = dt;
            baza.zatvoriKonekciju();
        }

        private void kupciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlRacun.Visible = false;
            pnlKupac.Visible = false;
            pnlReklamacija.Visible = false;
            pnlIzmeniReklamaciju.Visible = true;
            pnlRacuniIzv.Visible = false;
            pnlReklamacijeIzv.Visible = false;
            pnlIzmeniKup.Visible = false;

        }

        private void odjaviMeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Logovanje frmLog = new Logovanje();

            this.FormClosed += new FormClosedEventHandler(Prodavac_FormClosed);
            frmLog.Show();
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            String query = "SELECT * FROM kupac WHERE imeKup='" + txtImeKup.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baza.Sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            dgvKupci.DataSource = dtb;

            baza.zatvoriKonekciju();
        }

        public string idK;
        private void dgvKupci_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idK= dgvKupci.SelectedRows[0].Cells[0].Value.ToString();
            txtImeK.Text= dgvKupci.SelectedRows[0].Cells[1].Value.ToString();
            txtPrezimeK.Text = dgvKupci.SelectedRows[0].Cells[2].Value.ToString();
            txtAdresaK.Text = dgvKupci.SelectedRows[0].Cells[3].Value.ToString();
            txtTelefonK.Text = dgvKupci.SelectedRows[0].Cells[4].Value.ToString();
            txtEmailK.Text = dgvKupci.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnIzmenaKupca_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(String.IsNullOrEmpty(txtImeK.Text) || String.IsNullOrEmpty(txtPrezimeK.Text) || String.IsNullOrEmpty(txtAdresaK.Text) || String.IsNullOrEmpty(txtTelefonK.Text)))
                {
                    baza.otvoriKonekciju();
                    string query = "sp_IzmeniKupca";
                    SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@idK", idK);
                    com.Parameters.AddWithValue("@imeK", txtImeK.Text.ToString());
                    com.Parameters.AddWithValue("@prezimeK", txtPrezimeK.Text.ToString());
                    com.Parameters.AddWithValue("@adresa", txtAdresaK.Text.ToString());
                    com.Parameters.AddWithValue("@email", txtEmailK.Text.ToString());
                    com.Parameters.AddWithValue("@telefon", txtTelefonK.Text.ToString());
                    com.ExecuteNonQuery();
                    baza.zatvoriKonekciju();
                    MessageBox.Show("Podaci su uspešno izmenjeni!");

                    txtImeKup.Text = "";
                    txtImeK.Text = "";
                    txtPrezimeK.Text = "";
                    txtAdresaK.Text = "";
                    txtTelefonK.Text = "";
                    txtEmailK.Text = "";
                    this.dgvKupci.DataSource = null;
                    this.dgvKupci.Rows.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Neophodno je uneti sve tražene podatke!");
                }
            }
            catch
            {
                MessageBox.Show("Neuspešana izmena!");
            }
        }

        private void izmenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlRacun.Visible = false;
            pnlKupac.Visible = false;
            pnlReklamacija.Visible = false;
            pnlIzmeniReklamaciju.Visible = false;
            pnlRacuniIzv.Visible = false;
            pnlReklamacijeIzv.Visible = false;
            pnlIzmeniKup.Visible = true;
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlRacun.Visible = false;
            pnlKupac.Visible = true;
            pnlReklamacija.Visible = false;
            pnlIzmeniReklamaciju.Visible = false;
            pnlRacuniIzv.Visible = false;
            pnlReklamacijeIzv.Visible = false;
            pnlIzmeniKup.Visible = false;

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            String query = "SELECT * FROM kupac WHERE imeKup='" + txtKup.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baza.Sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            dgvKup.DataSource = dtb;

            baza.zatvoriKonekciju();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            string query = "sp_PrikazReklamacijaZaKupca";
            SqlCommand com = new SqlCommand(query, baza.Sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@idKupca", txtKupId.Text);
            com.ExecuteNonQuery();
            

            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvReklKup.DataSource = dt;

            baza.zatvoriKonekciju();
        }

        private void dataGridView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtKupId.Text= dgvKup.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            string query = "sp_PrikazReklamacijaZaKupca";
            SqlCommand com = new SqlCommand(query, baza.Sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@idKupca", txtKupId.Text);
            com.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(query, baza.Sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            dgvReklKup.DataSource = dtb;

            baza.zatvoriKonekciju();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pnlRacun.Visible = false;
            pnlKupac.Visible = false;
            pnlReklamacija.Visible = false;
            pnlIzmeniReklamaciju.Visible = true;
            pnlRacuniIzv.Visible = false;
            pnlReklamacijeIzv.Visible = false;
            pnlIzmeniKup.Visible = false;
            pnlKupciIzv.Visible = false;

            sakrijPodmeni();
        }

        private void btnReklamacijaMeni_Click(object sender, EventArgs e)
        {
            prikaziPodmeni(podmeniReklamacija);
        }

        private void podmeniDodajRekl_Click(object sender, EventArgs e)
        {
            pnlRacun.Visible = false;
            pnlKupac.Visible = false;
            pnlReklamacija.Visible = true;
            pnlIzmeniReklamaciju.Visible = false;
            pnlRacuniIzv.Visible = false;
            pnlReklamacijeIzv.Visible = false;
            pnlIzmeniKup.Visible = false;
            pnlKupciIzv.Visible = false;


            sakrijPodmeni();
        }

        private void podmeniUnosKup_Click(object sender, EventArgs e)
        {
            pnlRacun.Visible = false;
            pnlKupac.Visible = true;
            pnlReklamacija.Visible = false;
            pnlIzmeniReklamaciju.Visible = false;
            pnlRacuniIzv.Visible = false;
            pnlReklamacijeIzv.Visible = false;
            pnlIzmeniKup.Visible = false;
            pnlKupciIzv.Visible = false;

            sakrijPodmeni();
        }

        private void podmeniIzmenaKup_Click(object sender, EventArgs e)
        {
            pnlRacun.Visible = false;
            pnlKupac.Visible = false;
            pnlReklamacija.Visible = false;
            pnlIzmeniReklamaciju.Visible = false;
            pnlRacuniIzv.Visible = false;
            pnlReklamacijeIzv.Visible = false;
            pnlIzmeniKup.Visible = true;
            pnlKupciIzv.Visible = false;

            sakrijPodmeni();
        }

        private void podmeniIzvRac_Click(object sender, EventArgs e)
        {
            pnlRacun.Visible = false;
            pnlKupac.Visible = false;
            pnlReklamacija.Visible = false;
            pnlIzmeniReklamaciju.Visible = false; ;
            pnlRacuniIzv.Visible = true;
            pnlReklamacijeIzv.Visible = false;
            pnlIzmeniKup.Visible = false;
            pnlKupciIzv.Visible = false;

            prikazRacuna();
            sakrijPodmeni();
        }

        private void podmeniIzvRekl_Click(object sender, EventArgs e)
        {
            pnlRacun.Visible = false;
            pnlKupac.Visible = false;
            pnlReklamacija.Visible = false;
            pnlIzmeniReklamaciju.Visible = false;
            pnlRacuniIzv.Visible = false;
            pnlReklamacijeIzv.Visible = true;
            pnlIzmeniKup.Visible = false;
            pnlKupciIzv.Visible = false;



            this.view_ZavrseneReklamacijeTableAdapter.Fill(this.zavrseneReklamacije.view_ZavrseneReklamacije);
            this.view_NezavrseneReklamacijeTableAdapter.Fill(this.nezavrseneReklamacije.view_NezavrseneReklamacije);

            sakrijPodmeni();
        }

        private void podmeniIzvKup_Click(object sender, EventArgs e)
        {
            pnlKupciIzv.Visible = true;
            pnlRacun.Visible = false;
            pnlKupac.Visible = false;
            pnlReklamacija.Visible = false;
            pnlIzmeniReklamaciju.Visible = false;
            pnlRacuniIzv.Visible = false;
            pnlReklamacijeIzv.Visible = false;
            pnlIzmeniKup.Visible = false;
            sakrijPodmeni();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Logovanje frmLog = new Logovanje();

            // creating event handler to catch the main form closed event
            // this will fire when mainForm closed
            this.FormClosed += new FormClosedEventHandler(Prodavac_FormClosed);
            //showing the main form
            frmLog.Show();
            //hiding the current form
            this.Hide();
            sakrijPodmeni();
        }

        private void KupacMeni_Click(object sender, EventArgs e)
        {
            prikaziPodmeni(podmeniKupac);
        }

        private void IzveštajiMeni_Click(object sender, EventArgs e)
        {
            prikaziPodmeni(podmeniIzvestaji);
        }

        private void MeniOdjava_Click(object sender, EventArgs e)
        {
            prikaziPodmeni(podmeniOdjaviMe);
        }

        private void btnRacunMeni_Click(object sender, EventArgs e)
        {
            pnlRacun.Visible = true;
            pnlKupac.Visible = false;
            pnlReklamacija.Visible = false;
            pnlIzmeniReklamaciju.Visible = false;
            pnlRacuniIzv.Visible = false;
            pnlReklamacijeIzv.Visible = false;
            pnlIzmeniKup.Visible = false;
            pnlKupciIzv.Visible = false;

        }

        private void kupciToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pnlKupciIzv.Visible = true;
            pnlRacun.Visible = false;
            pnlKupac.Visible = false;
            pnlReklamacija.Visible = false;
            pnlIzmeniReklamaciju.Visible = false;
            pnlRacuniIzv.Visible = false;
            pnlReklamacijeIzv.Visible = false;
            pnlIzmeniKup.Visible = false;
        }

    }
}
