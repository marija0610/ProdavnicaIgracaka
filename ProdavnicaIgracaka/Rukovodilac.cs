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
using System.Reflection;
using System.Drawing.Text;

namespace ProdavnicaIgracaka
{

    public partial class Rukovodilac : Form
    {
        Baza baza = new Baza();
        public Rukovodilac()
        {
            InitializeComponent();
            prilagodiDizajn();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        }

        private void prilagodiDizajn()
        {
            podmeniZaposljavanje.Visible = false;
            podmeniIzvestaji.Visible = false;
            podmeniOdjava.Visible = false;
        }

        private void sakrijPodmeni()
        {
            if (podmeniZaposljavanje.Visible == true)
                podmeniZaposljavanje.Visible = false;
            if (podmeniIzvestaji.Visible == true)
                podmeniIzvestaji.Visible = false;
            if (podmeniOdjava.Visible == true)
                podmeniOdjava.Visible = false;
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

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'magacin.MAGACIN' table. You can move, or remove it, as needed.
            this.mAGACINTableAdapter.Fill(this.magacin.MAGACIN);
            // TODO: This line of code loads data into the 'dobavljac.DOBAVLJAC' table. You can move, or remove it, as needed.
            this.dOBAVLJACTableAdapter.Fill(this.dobavljac.DOBAVLJAC);
            // TODO: This line of code loads data into the 'posao.POSAO' table. You can move, or remove it, as needed.
            this.pOSAOTableAdapter.Fill(this.posao.POSAO);
            // TODO: This line of code loads data into the 'brend.BREND' table. You can move, or remove it, as needed.
            this.bRENDTableAdapter.Fill(this.brend.BREND);
            // TODO: This line of code loads data into the 'kategorija.KATEGORIJA' table. You can move, or remove it, as needed.
            this.kATEGORIJATableAdapter.Fill(this.kategorija.KATEGORIJA);
            // TODO: This line of code loads data into the 'prodavnicaIgracakaDataSet5.view_Otpusteni' table. You can move, or remove it, as needed.
            this.view_OtpusteniTableAdapter.Fill(this.prodavnicaIgracakaDataSet5.view_Otpusteni);
            // TODO: This line of code loads data into the 'prodavnicaIgracakaDataSet4.view_Zaposleni' table. You can move, or remove it, as needed.
            this.view_ZaposleniTableAdapter.Fill(this.prodavnicaIgracakaDataSet4.view_Zaposleni);
            // TODO: This line of code loads data into the 'prodavnicaIgracakaDataSet4.view_Nabavke' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'prodavnicaIgracakaDataSet3.poredjajOdNajprodavanijeg' table. You can move, or remove it, as needed.
            this.poredjajOdNajprodavanijegTableAdapter.Fill(this.prodavnicaIgracakaDataSet3.poredjajOdNajprodavanijeg);
            // TODO: This line of code loads data into the 'prodavnicaIgracakaDataSet3.poredjajOdNajprodavanijeg' table. You can move, or remove it, as needed.
            this.poredjajOdNajprodavanijegTableAdapter.Fill(this.prodavnicaIgracakaDataSet3.poredjajOdNajprodavanijeg);
        
            Logovanje frmLog = new Logovanje();
            frmLog.Close();
            prikazProizvoda();
            prikazDobavljaca();
            prikazKategorija();
            prikazBrenda();
            prikazNabavki();
            dateTimePicker1.Value = DateTime.Now.Date;
            dateTimePicker1.MaxDate = DateTime.Now.Date;
                prikazNajprodavanijeg();
        }

        public void prikaziZap()
        {
            baza.otvoriKonekciju();
            SqlDataAdapter adpt = new SqlDataAdapter("select * fom zaposleni where aktivan=1", baza.Sqlcon);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            baza.zatvoriKonekciju();
        }

        public void prikazOtpustenih()
        {
            baza.otvoriKonekciju();
            SqlDataAdapter adpt = new SqlDataAdapter("select * fom zaposleni where aktiva=1", baza.Sqlcon);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            baza.zatvoriKonekciju();
        }
        public void prikazNajprodavanijeg()
        {

            baza.otvoriKonekciju();
            SqlDataAdapter adpt = new SqlDataAdapter("select distinct top 100 percent proizvod.idP, nazivP as 'Naziv proizvoda' , Prodata_kolicina=SUM(kupljenaKol) over (partition by proizvod.idP) from stavke_racuna, proizvod where stavke_racuna.idP = PROIZVOD.idP order by Prodata_kolicina desc", baza.Sqlcon);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            baza.zatvoriKonekciju();
        }


        private void unosProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //prikazProizvoda();
            pnlUnosProizvoda.Visible = true;
            pnlDobavljac.Visible = false;
            pnlNabavke.Visible = false;
            pnlZaposljavanje.Visible = false;
            pnlProizvodIzv.Visible = false;
            pnlOtpustiRadnika.Visible = false;
            pnlKategorija.Visible = false;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = false;
            panel1.Visible = false;
            this.kATEGORIJATableAdapter.Fill(this.kategorija.KATEGORIJA);
            this.bRENDTableAdapter.Fill(this.brend.BREND);

        }

        public void prikazProizvoda()
        {
            baza.otvoriKonekciju();
            SqlDataAdapter adpt = new SqlDataAdapter("Select idP as 'Šifra artikla',nazivP as 'Naziv proizvoda',cenaP as 'Cena', nazivKat as 'Kategorija',nazivB as 'Brend' from proizvod, kategorija, brend where kategorija.idKat=proizvod.idKat and brend.idB=proizvod.idB", baza.Sqlcon);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dgvProizvod.DataSource = dt;
            baza.zatvoriKonekciju();
        }


        private void nabavkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlUnosProizvoda.Visible = false;
            pnlDobavljac.Visible = false;
            pnlNabavke.Visible = true;
            pnlZaposljavanje.Visible = false;
            pnlProizvodIzv.Visible = false;
            pnlOtpustiRadnika.Visible = false;
            pnlKategorija.Visible = false;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = false;
            panel1.Visible = false;

        }


        private void zapošljavanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* pnlUnosProizvoda.Visible = false;
            pnlDobavljac.Visible = false;
            pnlNabavke.Visible = false;
            pnlZaposljavanje.Visible = true;*/
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlUnosProizvoda.Visible = false;
            pnlDobavljac.Visible = true;
            pnlNabavke.Visible = false;
            pnlZaposljavanje.Visible = false;
            pnlProizvodIzv.Visible = false;
            pnlOtpustiRadnika.Visible = false;
            pnlKategorija.Visible = false;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = false;
            panel1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            string query = "sp_UnosNabavke";
            SqlCommand com = new SqlCommand(query, baza.Sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nazivDob", cbDobavljac.Text.ToString());
            com.Parameters.AddWithValue("@nazivMag", cbMagacin.Text.ToString());
            com.Parameters.AddWithValue("@datum",  dateTimePicker1.Value.Date);
            com.ExecuteNonQuery();
            baza.zatvoriKonekciju();
            DobavljenaRoba frmDobavljenaRoba = new DobavljenaRoba();
            frmDobavljenaRoba.Show();
            baza.zatvoriKonekciju();
        }

        private void btnUnesiPro_Click(object sender, EventArgs e)
        {   if (!(String.IsNullOrEmpty(txtNazivPro.Text) || String.IsNullOrEmpty(txtCenaPro.Text)))
            {
                try
                {
                    baza.otvoriKonekciju();
                    string query = "sp_UnesiProizvod";
                    SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@nazivP", txtNazivPro.Text.ToString());
                    com.Parameters.AddWithValue("@cenaP", txtCenaPro.Text.ToString());
                    com.Parameters.AddWithValue("@nazivKat", cbKategorija.Text.ToString());
                    com.Parameters.AddWithValue("@nazivB", cbBrend.Text.ToString());
                    com.ExecuteNonQuery();
                    baza.zatvoriKonekciju();
                    prikazProizvoda();

                    MessageBox.Show("Proizvod je uspešno unet!");

                    txtNazivPro.Text = "";
                    txtCenaPro.Text = "";
                }
                catch
                {
                    MessageBox.Show("Unete vrednosti nisu odgovarajućeg tipa");
                }
                
            }
            else
            {
                MessageBox.Show("Neophodno je uneti vrednosti za obavezna polja");
            }
        }

        public void prikazDobavljaca()
        {
            baza.otvoriKonekciju();
            SqlDataAdapter adpt = new SqlDataAdapter("Select idD,nazivD as 'Naziv dobavljaca',adresaD as 'Adresa', telefonD as 'Telefon', pib  from dobavljac", baza.Sqlcon);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dgvPrikazDobavljaca.DataSource = dt;
            baza.zatvoriKonekciju();

        }
        private void btnDobavljac_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtNazivDob.Text) && String.IsNullOrEmpty(txtAdresaDob.Text) && String.IsNullOrEmpty(txtPib.Text)))
            {
                baza.otvoriKonekciju();
                string query = "sp_UnesiDobavljaca";
                SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@nazivDob", txtNazivDob.Text.ToString());
                com.Parameters.AddWithValue("@adresaDob", txtAdresaDob.Text.ToString());
                com.Parameters.AddWithValue("@telefonDob", txtTelefonDob.Text.ToString());
                com.Parameters.AddWithValue("@pib", txtPib.Text.ToString());
                com.ExecuteNonQuery();
                baza.zatvoriKonekciju();
                prikazDobavljaca();
                MessageBox.Show("Unos dobavljača je uspešno izvršen.");
                txtNazivDob.Text = "";
                txtAdresaDob.Text = "";
                txtTelefonDob.Text = "";
                txtPib.Text = "";
            }
            else
            {
                MessageBox.Show("Potrebno je uneti vrednosti u obavezna polja");
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try {
                if (!(String.IsNullOrEmpty(txtIme.Text) || String.IsNullOrEmpty(txtPrezime.Text) || String.IsNullOrEmpty(txtKorIme.Text) || String.IsNullOrEmpty(txtLozinka.Text) || String.IsNullOrEmpty(txtPlata.Text) || String.IsNullOrEmpty(txtAdresaZ.Text)))
                {
                    baza.otvoriKonekciju();
                    string query = "sp_UnosZaposlenog";
                    SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@ime", txtIme.Text.ToString());
                    com.Parameters.AddWithValue("@prezime", txtPrezime.Text.ToString());
                    com.Parameters.AddWithValue("@korIme", txtKorIme.Text.ToString());
                    com.Parameters.AddWithValue("@lozinka", txtLozinka.Text.ToString());
                    com.Parameters.AddWithValue("@datZap", dtpZaposlenje.Text.ToString());
                    com.Parameters.AddWithValue("@plata", txtPlata.Text.ToString());
                    com.Parameters.AddWithValue("@adresaZ", txtAdresaZ.Text.ToString());
                    com.Parameters.AddWithValue("@emailZ", txtEmailZ.Text.ToString());
                    com.Parameters.AddWithValue("@telefonZ", txtTelefonZ.Text.ToString());
                    com.Parameters.AddWithValue("@nazivPosla", cbPosao.Text.ToString());
                    com.ExecuteNonQuery();
                    baza.zatvoriKonekciju();
                    this.view_ZaposleniTableAdapter.Fill(this.prodavnicaIgracakaDataSet4.view_Zaposleni);

                    MessageBox.Show("Podaci su uspešno uneti!");
                    txtIme.Text = "";
                    txtPrezime.Text = "";
                    txtKorIme.Text = "";
                    txtLozinka.Text = "";
                    txtPlata.Text = "";
                    txtAdresaZ.Text = "";
                    txtEmailZ.Text = "";
                    txtTelefonZ.Text = "";
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

        private void Rukovodilac_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void prikazKategorija()
        {
            baza.otvoriKonekciju();
            SqlDataAdapter adpt = new SqlDataAdapter("Select idKat,nazivKat as 'Naziv kategorije' from kategorija", baza.Sqlcon);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dgvKategorije.DataSource = dt;
            baza.zatvoriKonekciju();

        }
        private void btnKategorije_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(String.IsNullOrEmpty(txtNazivKat.Text)))
                {
                    baza.otvoriKonekciju();
                    string query = "sp_DodajKategoriju";
                    SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@nazivKat", txtNazivKat.Text);
                    com.ExecuteNonQuery();
                    baza.zatvoriKonekciju();
                    MessageBox.Show("Uspešan unos nove kategorije");
                    prikazKategorija();
                    txtNazivKat.Text = "";
                }
                else
                {
                    MessageBox.Show("Potrebno je uneti naziv kategorije");
                }
            }catch
            {
                MessageBox.Show("Neusešan unos nove kategorije");
            }
        }

        private void unosKategorijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlDobavljac.Visible = false;
            pnlKategorija.Visible = true;
            pnlNabavke.Visible = false;
            pnlUnosProizvoda.Visible = false;
            pnlZaposljavanje.Visible = false;
            pnlProizvodIzv.Visible = false;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = false;
            panel1.Visible = false;
            pnlOtpustiRadnika.Visible = false;


        }

        private void dodajZaposlenogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlUnosProizvoda.Visible = false;
            pnlDobavljac.Visible = false;
            pnlNabavke.Visible = false;
            pnlZaposljavanje.Visible = true;
            pnlOtpustiRadnika.Visible = false;
            pnlProizvodIzv.Visible = false;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = false;
            panel1.Visible = false;

            this.view_ZaposleniTableAdapter.Fill(this.prodavnicaIgracakaDataSet4.view_Zaposleni);

        }

        private void otpustiRadnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlUnosProizvoda.Visible = false;
            pnlDobavljac.Visible = false;
            pnlNabavke.Visible = false;
            pnlZaposljavanje.Visible = false;
            pnlOtpustiRadnika.Visible = true;
            pnlProizvodIzv.Visible = false;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = false;
            panel1.Visible = false;
            pnlKategorija.Visible = false;
        }

        private void btnPronadjiZap_Click(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            String query = "SELECT * FROM ZAPOSLENI WHERE ime=N'" + txtImeZap.Text+"' and  aktivan=1";
            SqlDataAdapter sda = new SqlDataAdapter(query, baza.Sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            dgvZaposleni.DataSource = dtb;

            baza.zatvoriKonekciju();
        }

        private void dgvZaposleni_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtIdZap.Text=dgvZaposleni.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnOtpustiZap_Click(object sender, EventArgs e)
        {
            try
            {
                baza.otvoriKonekciju();
                string query = "sp_Otpusti";
                SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@idZaposlenog", txtIdZap.Text);
                com.ExecuteNonQuery();
                baza.zatvoriKonekciju();
                MessageBox.Show("Zaposleni je uspešno otpušten.");
                txtImeZap.Text = "";
                txtIdZap.Text = "";
                this.dgvZaposleni.DataSource = null;
                this.dgvZaposleni.Rows.Clear();
            }
            catch{
                MessageBox.Show("Otpuštanje radnika nije uspelo!");

            }
        }

        public void prikazBrenda()
        {
            baza.otvoriKonekciju();
            SqlDataAdapter adpt = new SqlDataAdapter("Select idB,nazivB as 'Naziv brenda' from brend", baza.Sqlcon);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dgvBrend.DataSource = dt;
            baza.zatvoriKonekciju();

        }
        private void btnBrend_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(String.IsNullOrEmpty(txtBrend.Text)))
                {
                    baza.otvoriKonekciju();
                    string query = "sp_DodajBrend";
                    SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@nazivB", txtBrend.Text);
                    com.ExecuteNonQuery();
                    baza.zatvoriKonekciju();
                    prikazBrenda();
                    MessageBox.Show("Uspešan unos novog brenda");
                    txtBrend.Text = "";
                }
                else
                {
                    MessageBox.Show("Potrebno je uneti naziv brenda.");

                }

            }
            catch 
            {

                MessageBox.Show("Neuspešan unos novog brenda");
            }
            

        }

        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlUnosProizvoda.Visible = false;
            pnlDobavljac.Visible = false;
            pnlNabavke.Visible = false;
            pnlZaposljavanje.Visible = false;
            pnlOtpustiRadnika.Visible = false;
            pnlProizvodIzv.Visible = true;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = false;
            panel1.Visible = false;

            prikazProizvoda();
        }

        private void cbKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            string query = "sp_ProizvodiIzKategorije";
            SqlCommand com = new SqlCommand(query, baza.Sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nazivKat", cbKat.Text);
            com.ExecuteNonQuery();;

            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvPrikazProizvoda.DataSource = dt;
            baza.zatvoriKonekciju();
        }

        private void cbB_SelectedIndexChanged(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            string query = "sp_ProizvodiIzBrenda";
            SqlCommand com = new SqlCommand(query, baza.Sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nazivB", cbB.Text);
            com.ExecuteNonQuery(); ;

            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvPrikazProizvoda.DataSource = dt;
            baza.zatvoriKonekciju();
        }

        private void btnPrikazPro_Click(object sender, EventArgs e)
        {

            baza.otvoriKonekciju();
            string query = "sp_ProizvodiKatBrend";
            SqlCommand com = new SqlCommand(query, baza.Sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nazivB", cbB.Text);
            com.Parameters.AddWithValue("@nazivKat", cbKat.Text);
            com.ExecuteNonQuery(); ;

            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvPrikazProizvoda.DataSource = dt;
            baza.zatvoriKonekciju();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void nabavkeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlUnosProizvoda.Visible = false;
            pnlDobavljac.Visible = false;
            pnlNabavke.Visible = false;
            pnlZaposljavanje.Visible = false;
            pnlOtpustiRadnika.Visible = false;
            pnlProizvodIzv.Visible = false;
            pnlNabavkeIzv.Visible = true;
            pnlZaposleniIzv.Visible = false;
            pnlKategorija.Visible = false;
            panel1.Visible = false;

            prikazNabavki();
        }

        public void prikazNabavki()
        {
            baza.otvoriKonekciju();
            SqlDataAdapter adpt = new SqlDataAdapter("select top 100 percent nabavka.idN, nazivD, nazivM, datum, nazivP, Nkolicina from NABAVKA, STAVKE_NABAVKE, DOBAVLJAC, MAGACIN, PROIZVOD where NABAVKA.idN = STAVKE_NABAVKE.idN and NABAVKA.idD = DOBAVLJAC.idD and NABAVKA.idM = MAGACIN.idM and STAVKE_NABAVKE.idP = PROIZVOD.idP order by datum desc, idN desc", baza.Sqlcon);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dgvNabavkeIzv.DataSource = dt;
            baza.zatvoriKonekciju();
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlUnosProizvoda.Visible = false;
            pnlDobavljac.Visible = false;
            pnlNabavke.Visible = false;
            pnlZaposljavanje.Visible = false;
            pnlOtpustiRadnika.Visible = false;
            pnlProizvodIzv.Visible = false;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = true;
            panel1.Visible = false;

            this.view_ZaposleniTableAdapter.Fill(this.prodavnicaIgracakaDataSet4.view_Zaposleni);
            this.view_OtpusteniTableAdapter.Fill(this.prodavnicaIgracakaDataSet5.view_Otpusteni);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            String query = "SELECT * FROM ZAPOSLENI WHERE ime=N'" + txtZap.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baza.Sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            dgvPronadjiZap.DataSource = dtb;

            baza.zatvoriKonekciju();
        }

        private void dgvPronadjiZap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtZapId.Text= dgvPronadjiZap.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnPrikazRacuna_Click(object sender, EventArgs e)
        {
            baza.otvoriKonekciju();
            String query = "select racun.idR, datum, ukupanIznos, nazivP, cenaP from racun, STAVKE_RACUNA, PROIZVOD where racun.idR = STAVKE_RACUNA.idR and STAVKE_RACUNA.idP = PROIZVOD.idP and idZ = '"+txtZapId.Text+"' order by datum desc";
            SqlDataAdapter sda = new SqlDataAdapter(query, baza.Sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            dgvIzdati.DataSource = dtb;

            baza.zatvoriKonekciju();
        }

        public string idZ;
        private void dgvRadnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idZ= dgvRadnici.SelectedRows[0].Cells[0].Value.ToString();
            txtIme.Text = dgvRadnici.SelectedRows[0].Cells[1].Value.ToString();
            txtPrezime.Text = dgvRadnici.SelectedRows[0].Cells[2].Value.ToString();
            txtKorIme.Text = dgvRadnici.SelectedRows[0].Cells[3].Value.ToString();
            txtLozinka.Text = dgvRadnici.SelectedRows[0].Cells[4].Value.ToString();
            dtpZaposlenje.Text = dgvRadnici.SelectedRows[0].Cells[5].Value.ToString();
            txtPlata.Text = dgvRadnici.SelectedRows[0].Cells[6].Value.ToString();
            txtAdresaZ.Text = dgvRadnici.SelectedRows[0].Cells[7].Value.ToString();
            txtEmailZ.Text = dgvRadnici.SelectedRows[0].Cells[8].Value.ToString();
            txtTelefonZ.Text = dgvRadnici.SelectedRows[0].Cells[9].Value.ToString();
            baza.otvoriKonekciju();
            SqlCommand command = new SqlCommand("Select nazivPosla from posao where idPosla='" + dgvRadnici.SelectedRows[0].Cells[10].Value.ToString()+ "'", baza.Sqlcon);
             SqlDataReader reader = command.ExecuteReader();
             while (reader.Read())
             {
                 cbPosao.Text = reader.GetValue(0).ToString();
             }
             reader.Close();
             command.ExecuteNonQuery();

            baza.zatvoriKonekciju();
        }

        private void btnIzmeniZap_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtIme.Text) || String.IsNullOrEmpty(txtPrezime.Text) || String.IsNullOrEmpty(txtKorIme.Text) || String.IsNullOrEmpty(txtLozinka.Text) || String.IsNullOrEmpty(txtPlata.Text) || String.IsNullOrEmpty(txtAdresaZ.Text)))
            {
                try
                {
                    baza.otvoriKonekciju();
                    string query = "sp_IzmeniZap";
                    SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@idZ", idZ);
                    com.Parameters.AddWithValue("@ime", txtIme.Text);
                    com.Parameters.AddWithValue("@prezime", txtPrezime.Text);
                    com.Parameters.AddWithValue("@korIme", txtKorIme.Text);
                    com.Parameters.AddWithValue("@lozinka", txtLozinka.Text);
                    com.Parameters.AddWithValue("@datZap", dtpZaposlenje.Value);
                    com.Parameters.AddWithValue("@plata", txtPlata.Text);
                    com.Parameters.AddWithValue("@adresaZ", txtAdresaZ.Text);
                    com.Parameters.AddWithValue("@emailZ", txtEmailZ.Text);
                    com.Parameters.AddWithValue("@telefonZ", txtTelefonZ.Text);
                    com.Parameters.AddWithValue("@nazivPosla", cbPosao.Text);

                    com.ExecuteNonQuery();
                    baza.zatvoriKonekciju();
                    MessageBox.Show("Izmena podataka je uspešno izvršena.");
                    this.view_ZaposleniTableAdapter.Fill(this.prodavnicaIgracakaDataSet4.view_Zaposleni);
                    txtIme.Text = "";
                    txtPrezime.Text = "";
                    txtKorIme.Text = "";
                    txtLozinka.Text = "";
                    txtPlata.Text = "";
                    txtAdresaZ.Text = "";
                    txtEmailZ.Text = "";
                    txtTelefonZ.Text = "";

                }
                catch
                {
                    MessageBox.Show("Izmena podataka nije usešno izvršena.");
                }
            }
            else
            {
                MessageBox.Show("Neophodno je uneti sve tražene podatke!");
            }
        }

        private void vratiOtpuštenogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlUnosProizvoda.Visible = false;
            pnlDobavljac.Visible = false;
            pnlNabavke.Visible = false;
            pnlZaposljavanje.Visible = false;
            pnlOtpustiRadnika.Visible = false;
            pnlProizvodIzv.Visible = false;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = false;
            panel1.Visible = true;
            this.view_OtpusteniTableAdapter.Fill(this.prodavnicaIgracakaDataSet5.view_Otpusteni);

        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtIdRadnika.Text = dgvOtpusteniR.SelectedRows[0].Cells[0].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                baza.otvoriKonekciju();
                string query = "sp_VratiOtpustenog";
                SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@idZ", txtIdRadnika.Text);
                com.ExecuteNonQuery();
                baza.zatvoriKonekciju();
                MessageBox.Show("Radnik je ponovo zaposlen.");
                this.view_OtpusteniTableAdapter.Fill(this.prodavnicaIgracakaDataSet5.view_Otpusteni);

            }
            catch
            {
                MessageBox.Show("Ponovno zapošljavanje radnika nije uspelo.");
            }
        }

        private void dgvProizvod_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtNazivPro.Text = dgvProizvod.SelectedRows[0].Cells[1].Value.ToString();
            txtCenaPro.Text = dgvProizvod.SelectedRows[0].Cells[2].Value.ToString();
            cbKategorija.Text = dgvProizvod.SelectedRows[0].Cells[3].Value.ToString();
            cbBrend.Text= dgvProizvod.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnIzmeniPro_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtNazivPro.Text) || String.IsNullOrEmpty(txtCenaPro.Text)))
            {
                try
                {
                    baza.otvoriKonekciju();
                    string query = "sp_IzmeniProizvod";
                    SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@idP", dgvProizvod.SelectedRows[0].Cells[0].Value.ToString());
                    com.Parameters.AddWithValue("@nazivP", txtNazivPro.Text);
                    com.Parameters.AddWithValue("@cenaP", txtCenaPro.Text);
                    com.Parameters.AddWithValue("@nazivKat", cbKategorija.Text);
                    com.Parameters.AddWithValue("@nazivB", cbBrend.Text);
                    com.ExecuteNonQuery();
                    baza.zatvoriKonekciju();
                    prikazProizvoda();
                    MessageBox.Show("Izmena je uspešno izvršena.");
                    txtNazivPro.Text = "";
                    txtCenaPro.Text = "";

                }
                catch
                {
                    MessageBox.Show("Izmena nije uspela.");
                }
            }
            else
            {
                MessageBox.Show("Neophodno je uneti vrednosti za obavezna polja");
            }
        }

        private void dgvPrikazDobavljaca_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtNazivDob.Text= dgvPrikazDobavljaca.SelectedRows[0].Cells[1].Value.ToString();
            txtAdresaDob.Text= dgvPrikazDobavljaca.SelectedRows[0].Cells[2].Value.ToString();
            txtTelefonDob.Text= dgvPrikazDobavljaca.SelectedRows[0].Cells[3].Value.ToString();
            txtPib.Text= dgvPrikazDobavljaca.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnIzmaniDob_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtNazivDob.Text) && String.IsNullOrEmpty(txtAdresaDob.Text) && String.IsNullOrEmpty(txtPib.Text)))
            {
                try
                {
                    baza.otvoriKonekciju();
                    string query = "sp_IzmeniDob";
                    SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@idD", dgvPrikazDobavljaca.SelectedRows[0].Cells[0].Value.ToString());
                    com.Parameters.AddWithValue("@nazivDob", txtNazivDob.Text);
                    com.Parameters.AddWithValue("@adresaDob", txtAdresaDob.Text);
                    com.Parameters.AddWithValue("@telefonDob", txtTelefonDob.Text);
                    com.Parameters.AddWithValue("@pib", txtPib.Text);
                    com.ExecuteNonQuery();
                    baza.zatvoriKonekciju();
                    prikazDobavljaca();
                    MessageBox.Show("Izmena je uspešno izvršena.");
                    txtNazivDob.Text = "";
                    txtAdresaDob.Text = "";
                    txtTelefonDob.Text = "";
                    txtPib.Text = "";

                }
                catch
                {
                    MessageBox.Show("Izmena nije uspela.");
                }
            }
            else
            {
                MessageBox.Show("Potrebno je uneti vrednosti u obavezna polja");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtNazivKat.Text)))
            {
                try
                {
                    baza.otvoriKonekciju();
                    string query = "sp_IzmeniKategoriju";
                    SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@idKat", dgvKategorije.SelectedRows[0].Cells[0].Value.ToString());
                    com.Parameters.AddWithValue("@nazivKat", txtNazivKat.Text.ToString());
                    com.ExecuteNonQuery();
                    baza.zatvoriKonekciju();
                    prikazKategorija();
                    MessageBox.Show("Izmena je uspešno izvršena.");
                    txtNazivKat.Text = "";
                }
                catch
                {
                    MessageBox.Show("Izmena nije uspela.");
                }
            }
            else
            {
                MessageBox.Show("Potrebno je uneti naziv kategorije");
            }
        }

        private void dgvKategorije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtNazivKat.Text = dgvKategorije.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtBrend.Text)))
            {
                try
                {
                    baza.otvoriKonekciju();
                    string query = "sp_IzmeniBrend";
                    SqlCommand com = new SqlCommand(query, baza.Sqlcon);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@idB", dgvBrend.SelectedRows[0].Cells[0].Value.ToString());
                    com.Parameters.AddWithValue("@nazivB", txtBrend.Text);
                    com.ExecuteNonQuery();
                    baza.zatvoriKonekciju();
                    prikazBrenda();
                    MessageBox.Show("Izmena je uspešno izvršena.");
                    txtBrend.Text = "";
                }
                catch
                {
                    MessageBox.Show("Izmena nije uspela.");
                }
            }
            else
            {
                MessageBox.Show("Potrebno je uneti naziv brenda.");

            }
        }

        private void dgvBrend_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtBrend.Text = dgvBrend.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void odjaviMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logovanje frmLog = new Logovanje();

            this.FormClosed += new FormClosedEventHandler(Rukovodilac_FormClosed);
            frmLog.Show();
            this.Hide();
        }

        private void MeniProizvodi_Click(object sender, EventArgs e)
        {
            pnlUnosProizvoda.Visible = true;
            pnlDobavljac.Visible = false;
            pnlNabavke.Visible = false;
            pnlZaposljavanje.Visible = false;
            pnlProizvodIzv.Visible = false;
            pnlOtpustiRadnika.Visible = false;
            pnlKategorija.Visible = false;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = false;
            panel1.Visible = false;
            this.kATEGORIJATableAdapter.Fill(this.kategorija.KATEGORIJA);
            this.bRENDTableAdapter.Fill(this.brend.BREND);
        }

        private void MeniZaposljavanje_Click(object sender, EventArgs e)
        {
            prikaziPodmeni(podmeniZaposljavanje);
        }

        private void MeniIzvestaji_Click(object sender, EventArgs e)
        {
            prikaziPodmeni(podmeniIzvestaji);
        }

        private void MeniOdjava_Click(object sender, EventArgs e)
        {
            prikaziPodmeni(podmeniOdjava);
        }

        private void podmeniDodajRad_Click(object sender, EventArgs e)
        {
            pnlUnosProizvoda.Visible = false;
            pnlDobavljac.Visible = false;
            pnlNabavke.Visible = false;
            pnlZaposljavanje.Visible = true;
            pnlOtpustiRadnika.Visible = false;
            pnlProizvodIzv.Visible = false;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = false;
            pnlKategorija.Visible = false;
            panel1.Visible = false;

            this.view_ZaposleniTableAdapter.Fill(this.prodavnicaIgracakaDataSet4.view_Zaposleni);

            sakrijPodmeni();
        }

        private void podmeniOtpustiRad_Click(object sender, EventArgs e)
        {
            pnlUnosProizvoda.Visible = false;
            pnlDobavljac.Visible = false;
            pnlNabavke.Visible = false;
            pnlZaposljavanje.Visible = false;
            pnlOtpustiRadnika.Visible = true;
            pnlProizvodIzv.Visible = false;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = false;
            panel1.Visible = false;
            pnlKategorija.Visible = false;
            sakrijPodmeni();

        }

        private void podmeniVratiOtp_Click(object sender, EventArgs e)
        {
            pnlUnosProizvoda.Visible = false;
            pnlDobavljac.Visible = false;
            pnlNabavke.Visible = false;
            pnlZaposljavanje.Visible = false;
            pnlOtpustiRadnika.Visible = false;
            pnlProizvodIzv.Visible = false;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = false;
            panel1.Visible = true;
            this.view_OtpusteniTableAdapter.Fill(this.prodavnicaIgracakaDataSet5.view_Otpusteni);

            sakrijPodmeni();

        }

        private void podmeniIzvPro_Click(object sender, EventArgs e)
        {
            pnlUnosProizvoda.Visible = false;
            pnlDobavljac.Visible = false;
            pnlNabavke.Visible = false;
            pnlZaposljavanje.Visible = false;
            pnlOtpustiRadnika.Visible = false;
            pnlProizvodIzv.Visible = true;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = false;
            panel1.Visible = false;

            prikazProizvoda();
            sakrijPodmeni();

        }

        private void podmeniIzvNab_Click(object sender, EventArgs e)
        {
            pnlUnosProizvoda.Visible = false;
            pnlDobavljac.Visible = false;
            pnlNabavke.Visible = false;
            pnlZaposljavanje.Visible = false;
            pnlOtpustiRadnika.Visible = false;
            pnlProizvodIzv.Visible = false;
            pnlNabavkeIzv.Visible = true;
            pnlZaposleniIzv.Visible = false;
            pnlKategorija.Visible = false;
            panel1.Visible = false;

            prikazNabavki();
            sakrijPodmeni();

        }

        private void podmeniIzvZap_Click(object sender, EventArgs e)
        {
            pnlUnosProizvoda.Visible = false;
            pnlDobavljac.Visible = false;
            pnlNabavke.Visible = false;
            pnlZaposljavanje.Visible = false;
            pnlOtpustiRadnika.Visible = false;
            pnlProizvodIzv.Visible = false;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = true;
            panel1.Visible = false;

            this.view_ZaposleniTableAdapter.Fill(this.prodavnicaIgracakaDataSet4.view_Zaposleni);
            this.view_OtpusteniTableAdapter.Fill(this.prodavnicaIgracakaDataSet5.view_Otpusteni);
            sakrijPodmeni();

        }

        private void podmeniOdjaviMe_Click(object sender, EventArgs e)
        {
            Logovanje frmLog = new Logovanje();

            this.FormClosed += new FormClosedEventHandler(Rukovodilac_FormClosed);
            frmLog.Show();
            this.Hide();
            sakrijPodmeni();
        }

        private void MeniNabavke_Click(object sender, EventArgs e)
        {
            pnlUnosProizvoda.Visible = false;
            pnlDobavljac.Visible = false;
            pnlNabavke.Visible = true;
            pnlZaposljavanje.Visible = false;
            pnlProizvodIzv.Visible = false;
            pnlOtpustiRadnika.Visible = false;
            pnlKategorija.Visible = false;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = false;
            panel1.Visible = false;
        }

        private void MeniDobavljaci_Click(object sender, EventArgs e)
        {
            pnlUnosProizvoda.Visible = false;
            pnlDobavljac.Visible = true;
            pnlNabavke.Visible = false;
            pnlZaposljavanje.Visible = false;
            pnlProizvodIzv.Visible = false;
            pnlOtpustiRadnika.Visible = false;
            pnlKategorija.Visible = false;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = false;
            panel1.Visible = false;
        }

        private void MeniKategorija_Click(object sender, EventArgs e)
        {
            pnlDobavljac.Visible = false;
            pnlKategorija.Visible = true;
            pnlNabavke.Visible = false;
            pnlUnosProizvoda.Visible = false;
            pnlZaposljavanje.Visible = false;
            pnlProizvodIzv.Visible = false;
            pnlNabavkeIzv.Visible = false;
            pnlZaposleniIzv.Visible = false;
            panel1.Visible = false;
            pnlOtpustiRadnika.Visible = false;
        }
    }
}
