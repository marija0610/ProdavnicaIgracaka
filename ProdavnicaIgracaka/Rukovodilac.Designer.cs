using System.Diagnostics.Tracing;

namespace ProdavnicaIgracaka
{
    partial class Rukovodilac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rukovodilac));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUnosProizvoda = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvProizvod = new System.Windows.Forms.DataGridView();
            this.lblBrend = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBrend = new System.Windows.Forms.ComboBox();
            this.bRENDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brend = new ProdavnicaIgracaka.Brend();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.kATEGORIJABindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorija = new ProdavnicaIgracaka.Kategorija();
            this.txtCenaPro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivPro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzmeniPro = new System.Windows.Forms.Button();
            this.btnUnesiPro = new System.Windows.Forms.Button();
            this.pnlZaposljavanje = new System.Windows.Forms.Panel();
            this.btnIzmeniZap = new System.Windows.Forms.Button();
            this.dgvRadnici = new System.Windows.Forms.DataGridView();
            this.idZDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korImeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datZapDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaZDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailZDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonZDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPoslaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanDataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.viewZaposleniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodavnicaIgracakaDataSet4 = new ProdavnicaIgracaka.ProdavnicaIgracakaDataSet4();
            this.dtpZaposlenje = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.cbPosao = new System.Windows.Forms.ComboBox();
            this.pOSAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posao = new ProdavnicaIgracaka.Posao();
            this.txtTelefonZ = new System.Windows.Forms.TextBox();
            this.txtEmailZ = new System.Windows.Forms.TextBox();
            this.txtAdresaZ = new System.Windows.Forms.TextBox();
            this.txtPlata = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlNabavke = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbMagacin = new System.Windows.Forms.ComboBox();
            this.mAGACINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magacin = new ProdavnicaIgracaka.Magacin();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.dOBAVLJACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljac = new ProdavnicaIgracaka.Dobavljac();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlDobavljac = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnIzmaniDob = new System.Windows.Forms.Button();
            this.txtPib = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.dgvPrikazDobavljaca = new System.Windows.Forms.DataGridView();
            this.btnDobavljac = new System.Windows.Forms.Button();
            this.txtTelefonDob = new System.Windows.Forms.TextBox();
            this.txtAdresaDob = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNazivDob = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pnlKategorija = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dgvBrend = new System.Windows.Forms.DataGridView();
            this.btnBrend = new System.Windows.Forms.Button();
            this.txtBrend = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dgvKategorije = new System.Windows.Forms.DataGridView();
            this.btnKategorije = new System.Windows.Forms.Button();
            this.txtNazivKat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlOtpustiRadnika = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnOtpustiZap = new System.Windows.Forms.Button();
            this.txtIdZap = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dgvZaposleni = new System.Windows.Forms.DataGridView();
            this.btnPronadjiZap = new System.Windows.Forms.Button();
            this.txtImeZap = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.pnlProizvodIzv = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label28 = new System.Windows.Forms.Label();
            this.btnPrikazPro = new System.Windows.Forms.Button();
            this.dgvPrikazProizvoda = new System.Windows.Forms.DataGridView();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cbB = new System.Windows.Forms.ComboBox();
            this.cbKat = new System.Windows.Forms.ComboBox();
            this.prodavnicaIgracakaDataSet3 = new ProdavnicaIgracaka.ProdavnicaIgracakaDataSet3();
            this.poredjajOdNajprodavanijegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poredjajOdNajprodavanijegTableAdapter = new ProdavnicaIgracaka.ProdavnicaIgracakaDataSet3TableAdapters.poredjajOdNajprodavanijegTableAdapter();
            this.pnlNabavkeIzv = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.dgvNabavkeIzv = new System.Windows.Forms.DataGridView();
            this.viewNabavkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlZaposleniIzv = new System.Windows.Forms.Panel();
            this.btnPrikazRacuna = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.dgvIzdati = new System.Windows.Forms.DataGridView();
            this.txtZapId = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.dgvPronadjiZap = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.txtZap = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.dgvOtpusten = new System.Windows.Forms.DataGridView();
            this.idZDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korImeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datZapDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaZDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailZDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonZDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPoslaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.viewOtpusteniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodavnicaIgracakaDataSet5 = new ProdavnicaIgracaka.ProdavnicaIgracakaDataSet5();
            this.label31 = new System.Windows.Forms.Label();
            this.dgvZap = new System.Windows.Forms.DataGridView();
            this.idZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datZapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPoslaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label30 = new System.Windows.Forms.Label();
            this.view_ZaposleniTableAdapter = new ProdavnicaIgracaka.ProdavnicaIgracakaDataSet4TableAdapters.view_ZaposleniTableAdapter();
            this.view_OtpusteniTableAdapter = new ProdavnicaIgracaka.ProdavnicaIgracakaDataSet5TableAdapters.view_OtpusteniTableAdapter();
            this.kATEGORIJATableAdapter = new ProdavnicaIgracaka.KategorijaTableAdapters.KATEGORIJATableAdapter();
            this.bRENDTableAdapter = new ProdavnicaIgracaka.BrendTableAdapters.BRENDTableAdapter();
            this.pOSAOTableAdapter = new ProdavnicaIgracaka.PosaoTableAdapters.POSAOTableAdapter();
            this.dOBAVLJACTableAdapter = new ProdavnicaIgracaka.DobavljacTableAdapters.DOBAVLJACTableAdapter();
            this.mAGACINTableAdapter = new ProdavnicaIgracaka.MagacinTableAdapters.MAGACINTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.txtIdRadnika = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.dgvOtpusteniR = new System.Windows.Forms.DataGridView();
            this.idZDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korImeDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datZapDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaZDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailZDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonZDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPoslaDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanDataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label35 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.podmeniOdjava = new System.Windows.Forms.Panel();
            this.podmeniOdjaviMe = new System.Windows.Forms.Button();
            this.MeniOdjava = new System.Windows.Forms.Button();
            this.podmeniIzvestaji = new System.Windows.Forms.Panel();
            this.podmeniIzvZap = new System.Windows.Forms.Button();
            this.podmeniIzvNab = new System.Windows.Forms.Button();
            this.podmeniIzvPro = new System.Windows.Forms.Button();
            this.MeniIzvestaji = new System.Windows.Forms.Button();
            this.podmeniZaposljavanje = new System.Windows.Forms.Panel();
            this.podmeniVratiOtp = new System.Windows.Forms.Button();
            this.podmeniOtpustiRad = new System.Windows.Forms.Button();
            this.podmeniDodajRad = new System.Windows.Forms.Button();
            this.MeniZaposljavanje = new System.Windows.Forms.Button();
            this.MeniKategorija = new System.Windows.Forms.Button();
            this.MeniDobavljaci = new System.Windows.Forms.Button();
            this.MeniNabavke = new System.Windows.Forms.Button();
            this.MeniProizvodi = new System.Windows.Forms.Button();
            this.LogoPnl = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlUnosProizvoda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRENDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATEGORIJABindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorija)).BeginInit();
            this.pnlZaposljavanje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewZaposleniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodavnicaIgracakaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posao)).BeginInit();
            this.pnlNabavke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAGACINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magacin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOBAVLJACBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).BeginInit();
            this.pnlDobavljac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazDobavljaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.pnlKategorija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).BeginInit();
            this.pnlOtpustiRadnika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).BeginInit();
            this.pnlProizvodIzv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazProizvoda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodavnicaIgracakaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poredjajOdNajprodavanijegBindingSource)).BeginInit();
            this.pnlNabavkeIzv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNabavkeIzv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNabavkeBindingSource)).BeginInit();
            this.pnlZaposleniIzv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPronadjiZap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtpusten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOtpusteniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodavnicaIgracakaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZap)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtpusteniR)).BeginInit();
            this.panel2.SuspendLayout();
            this.podmeniOdjava.SuspendLayout();
            this.podmeniIzvestaji.SuspendLayout();
            this.podmeniZaposljavanje.SuspendLayout();
            this.LogoPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUnosProizvoda
            // 
            this.pnlUnosProizvoda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUnosProizvoda.BackColor = System.Drawing.Color.Transparent;
            this.pnlUnosProizvoda.Controls.Add(this.pictureBox1);
            this.pnlUnosProizvoda.Controls.Add(this.dgvProizvod);
            this.pnlUnosProizvoda.Controls.Add(this.lblBrend);
            this.pnlUnosProizvoda.Controls.Add(this.label3);
            this.pnlUnosProizvoda.Controls.Add(this.cbBrend);
            this.pnlUnosProizvoda.Controls.Add(this.cbKategorija);
            this.pnlUnosProizvoda.Controls.Add(this.txtCenaPro);
            this.pnlUnosProizvoda.Controls.Add(this.label2);
            this.pnlUnosProizvoda.Controls.Add(this.txtNazivPro);
            this.pnlUnosProizvoda.Controls.Add(this.label1);
            this.pnlUnosProizvoda.Controls.Add(this.btnIzmeniPro);
            this.pnlUnosProizvoda.Controls.Add(this.btnUnesiPro);
            this.pnlUnosProizvoda.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUnosProizvoda.Location = new System.Drawing.Point(237, 21);
            this.pnlUnosProizvoda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUnosProizvoda.Name = "pnlUnosProizvoda";
            this.pnlUnosProizvoda.Size = new System.Drawing.Size(990, 557);
            this.pnlUnosProizvoda.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(655, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dgvProizvod
            // 
            this.dgvProizvod.AllowUserToAddRows = false;
            this.dgvProizvod.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProizvod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProizvod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProizvod.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvProizvod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvod.Location = new System.Drawing.Point(65, 341);
            this.dgvProizvod.MultiSelect = false;
            this.dgvProizvod.Name = "dgvProizvod";
            this.dgvProizvod.ReadOnly = true;
            this.dgvProizvod.RowHeadersWidth = 51;
            this.dgvProizvod.RowTemplate.Height = 24;
            this.dgvProizvod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvod.Size = new System.Drawing.Size(844, 204);
            this.dgvProizvod.TabIndex = 11;
            this.dgvProizvod.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProizvod_MouseDoubleClick);
            // 
            // lblBrend
            // 
            this.lblBrend.AutoSize = true;
            this.lblBrend.Location = new System.Drawing.Point(63, 201);
            this.lblBrend.Name = "lblBrend";
            this.lblBrend.Size = new System.Drawing.Size(77, 27);
            this.lblBrend.TabIndex = 10;
            this.lblBrend.Text = "Brend:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kategrija:";
            // 
            // cbBrend
            // 
            this.cbBrend.BackColor = System.Drawing.Color.LightBlue;
            this.cbBrend.DataSource = this.bRENDBindingSource;
            this.cbBrend.DisplayMember = "nazivB";
            this.cbBrend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrend.FormattingEnabled = true;
            this.cbBrend.Location = new System.Drawing.Point(186, 193);
            this.cbBrend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBrend.Name = "cbBrend";
            this.cbBrend.Size = new System.Drawing.Size(446, 34);
            this.cbBrend.TabIndex = 8;
            this.cbBrend.ValueMember = "nazivB";
            // 
            // bRENDBindingSource
            // 
            this.bRENDBindingSource.DataMember = "BREND";
            this.bRENDBindingSource.DataSource = this.brend;
            // 
            // brend
            // 
            this.brend.DataSetName = "Brend";
            this.brend.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbKategorija
            // 
            this.cbKategorija.BackColor = System.Drawing.Color.LightBlue;
            this.cbKategorija.DataSource = this.kATEGORIJABindingSource2;
            this.cbKategorija.DisplayMember = "nazivKat";
            this.cbKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(188, 134);
            this.cbKategorija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(444, 34);
            this.cbKategorija.TabIndex = 7;
            this.cbKategorija.ValueMember = "nazivKat";
            // 
            // kATEGORIJABindingSource2
            // 
            this.kATEGORIJABindingSource2.DataMember = "KATEGORIJA";
            this.kATEGORIJABindingSource2.DataSource = this.kategorijaBindingSource;
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataSource = this.kategorija;
            this.kategorijaBindingSource.Position = 0;
            // 
            // kategorija
            // 
            this.kategorija.DataSetName = "Kategorija";
            this.kategorija.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCenaPro
            // 
            this.txtCenaPro.Location = new System.Drawing.Point(186, 78);
            this.txtCenaPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCenaPro.Name = "txtCenaPro";
            this.txtCenaPro.Size = new System.Drawing.Size(446, 34);
            this.txtCenaPro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cena:";
            // 
            // txtNazivPro
            // 
            this.txtNazivPro.Location = new System.Drawing.Point(186, 23);
            this.txtNazivPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNazivPro.Name = "txtNazivPro";
            this.txtNazivPro.Size = new System.Drawing.Size(446, 34);
            this.txtNazivPro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv:";
            // 
            // btnIzmeniPro
            // 
            this.btnIzmeniPro.BackColor = System.Drawing.Color.LightBlue;
            this.btnIzmeniPro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIzmeniPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeniPro.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniPro.Location = new System.Drawing.Point(503, 257);
            this.btnIzmeniPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzmeniPro.Name = "btnIzmeniPro";
            this.btnIzmeniPro.Size = new System.Drawing.Size(406, 64);
            this.btnIzmeniPro.TabIndex = 12;
            this.btnIzmeniPro.Text = "Izmeni";
            this.btnIzmeniPro.UseVisualStyleBackColor = false;
            this.btnIzmeniPro.Click += new System.EventHandler(this.btnIzmeniPro_Click);
            // 
            // btnUnesiPro
            // 
            this.btnUnesiPro.BackColor = System.Drawing.Color.LightBlue;
            this.btnUnesiPro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUnesiPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnesiPro.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesiPro.Location = new System.Drawing.Point(65, 258);
            this.btnUnesiPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUnesiPro.Name = "btnUnesiPro";
            this.btnUnesiPro.Size = new System.Drawing.Size(415, 64);
            this.btnUnesiPro.TabIndex = 6;
            this.btnUnesiPro.Text = "Unesi proizvod";
            this.btnUnesiPro.UseVisualStyleBackColor = false;
            this.btnUnesiPro.Click += new System.EventHandler(this.btnUnesiPro_Click);
            // 
            // pnlZaposljavanje
            // 
            this.pnlZaposljavanje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlZaposljavanje.BackColor = System.Drawing.Color.Transparent;
            this.pnlZaposljavanje.Controls.Add(this.btnIzmeniZap);
            this.pnlZaposljavanje.Controls.Add(this.dgvRadnici);
            this.pnlZaposljavanje.Controls.Add(this.dtpZaposlenje);
            this.pnlZaposljavanje.Controls.Add(this.button2);
            this.pnlZaposljavanje.Controls.Add(this.cbPosao);
            this.pnlZaposljavanje.Controls.Add(this.txtTelefonZ);
            this.pnlZaposljavanje.Controls.Add(this.txtEmailZ);
            this.pnlZaposljavanje.Controls.Add(this.txtAdresaZ);
            this.pnlZaposljavanje.Controls.Add(this.txtPlata);
            this.pnlZaposljavanje.Controls.Add(this.txtLozinka);
            this.pnlZaposljavanje.Controls.Add(this.txtKorIme);
            this.pnlZaposljavanje.Controls.Add(this.txtPrezime);
            this.pnlZaposljavanje.Controls.Add(this.txtIme);
            this.pnlZaposljavanje.Controls.Add(this.label14);
            this.pnlZaposljavanje.Controls.Add(this.label13);
            this.pnlZaposljavanje.Controls.Add(this.label12);
            this.pnlZaposljavanje.Controls.Add(this.label11);
            this.pnlZaposljavanje.Controls.Add(this.label10);
            this.pnlZaposljavanje.Controls.Add(this.label9);
            this.pnlZaposljavanje.Controls.Add(this.label8);
            this.pnlZaposljavanje.Controls.Add(this.label7);
            this.pnlZaposljavanje.Controls.Add(this.label6);
            this.pnlZaposljavanje.Controls.Add(this.label5);
            this.pnlZaposljavanje.Location = new System.Drawing.Point(236, 21);
            this.pnlZaposljavanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlZaposljavanje.Name = "pnlZaposljavanje";
            this.pnlZaposljavanje.Size = new System.Drawing.Size(990, 559);
            this.pnlZaposljavanje.TabIndex = 11;
            // 
            // btnIzmeniZap
            // 
            this.btnIzmeniZap.BackColor = System.Drawing.Color.LightBlue;
            this.btnIzmeniZap.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIzmeniZap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeniZap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniZap.Location = new System.Drawing.Point(283, 488);
            this.btnIzmeniZap.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeniZap.Name = "btnIzmeniZap";
            this.btnIzmeniZap.Size = new System.Drawing.Size(186, 52);
            this.btnIzmeniZap.TabIndex = 23;
            this.btnIzmeniZap.Text = "Izmeni";
            this.btnIzmeniZap.UseVisualStyleBackColor = false;
            this.btnIzmeniZap.Click += new System.EventHandler(this.btnIzmeniZap_Click);
            // 
            // dgvRadnici
            // 
            this.dgvRadnici.AllowUserToAddRows = false;
            this.dgvRadnici.AllowUserToDeleteRows = false;
            this.dgvRadnici.AutoGenerateColumns = false;
            this.dgvRadnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRadnici.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvRadnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZDataGridViewTextBoxColumn2,
            this.imeDataGridViewTextBoxColumn2,
            this.prezimeDataGridViewTextBoxColumn2,
            this.korImeDataGridViewTextBoxColumn2,
            this.lozinkaDataGridViewTextBoxColumn2,
            this.datZapDataGridViewTextBoxColumn2,
            this.plataDataGridViewTextBoxColumn2,
            this.adresaZDataGridViewTextBoxColumn2,
            this.emailZDataGridViewTextBoxColumn2,
            this.telefonZDataGridViewTextBoxColumn2,
            this.idPoslaDataGridViewTextBoxColumn2,
            this.aktivanDataGridViewCheckBoxColumn2});
            this.dgvRadnici.DataSource = this.viewZaposleniBindingSource;
            this.dgvRadnici.Location = new System.Drawing.Point(500, 18);
            this.dgvRadnici.Name = "dgvRadnici";
            this.dgvRadnici.ReadOnly = true;
            this.dgvRadnici.RowHeadersWidth = 51;
            this.dgvRadnici.RowTemplate.Height = 24;
            this.dgvRadnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRadnici.Size = new System.Drawing.Size(490, 523);
            this.dgvRadnici.TabIndex = 22;
            this.dgvRadnici.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvRadnici_MouseDoubleClick);
            // 
            // idZDataGridViewTextBoxColumn2
            // 
            this.idZDataGridViewTextBoxColumn2.DataPropertyName = "idZ";
            this.idZDataGridViewTextBoxColumn2.HeaderText = "idZ";
            this.idZDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idZDataGridViewTextBoxColumn2.Name = "idZDataGridViewTextBoxColumn2";
            this.idZDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idZDataGridViewTextBoxColumn2.Width = 57;
            // 
            // imeDataGridViewTextBoxColumn2
            // 
            this.imeDataGridViewTextBoxColumn2.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn2.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.imeDataGridViewTextBoxColumn2.Name = "imeDataGridViewTextBoxColumn2";
            this.imeDataGridViewTextBoxColumn2.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn2.Width = 59;
            // 
            // prezimeDataGridViewTextBoxColumn2
            // 
            this.prezimeDataGridViewTextBoxColumn2.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn2.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.prezimeDataGridViewTextBoxColumn2.Name = "prezimeDataGridViewTextBoxColumn2";
            this.prezimeDataGridViewTextBoxColumn2.ReadOnly = true;
            this.prezimeDataGridViewTextBoxColumn2.Width = 87;
            // 
            // korImeDataGridViewTextBoxColumn2
            // 
            this.korImeDataGridViewTextBoxColumn2.DataPropertyName = "korIme";
            this.korImeDataGridViewTextBoxColumn2.HeaderText = "korIme";
            this.korImeDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.korImeDataGridViewTextBoxColumn2.Name = "korImeDataGridViewTextBoxColumn2";
            this.korImeDataGridViewTextBoxColumn2.ReadOnly = true;
            this.korImeDataGridViewTextBoxColumn2.Width = 79;
            // 
            // lozinkaDataGridViewTextBoxColumn2
            // 
            this.lozinkaDataGridViewTextBoxColumn2.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn2.HeaderText = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.lozinkaDataGridViewTextBoxColumn2.Name = "lozinkaDataGridViewTextBoxColumn2";
            this.lozinkaDataGridViewTextBoxColumn2.ReadOnly = true;
            this.lozinkaDataGridViewTextBoxColumn2.Width = 81;
            // 
            // datZapDataGridViewTextBoxColumn2
            // 
            this.datZapDataGridViewTextBoxColumn2.DataPropertyName = "datZap";
            this.datZapDataGridViewTextBoxColumn2.HeaderText = "datZap";
            this.datZapDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.datZapDataGridViewTextBoxColumn2.Name = "datZapDataGridViewTextBoxColumn2";
            this.datZapDataGridViewTextBoxColumn2.ReadOnly = true;
            this.datZapDataGridViewTextBoxColumn2.Width = 82;
            // 
            // plataDataGridViewTextBoxColumn2
            // 
            this.plataDataGridViewTextBoxColumn2.DataPropertyName = "plata";
            this.plataDataGridViewTextBoxColumn2.HeaderText = "plata";
            this.plataDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.plataDataGridViewTextBoxColumn2.Name = "plataDataGridViewTextBoxColumn2";
            this.plataDataGridViewTextBoxColumn2.ReadOnly = true;
            this.plataDataGridViewTextBoxColumn2.Width = 68;
            // 
            // adresaZDataGridViewTextBoxColumn2
            // 
            this.adresaZDataGridViewTextBoxColumn2.DataPropertyName = "adresaZ";
            this.adresaZDataGridViewTextBoxColumn2.HeaderText = "adresaZ";
            this.adresaZDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.adresaZDataGridViewTextBoxColumn2.Name = "adresaZDataGridViewTextBoxColumn2";
            this.adresaZDataGridViewTextBoxColumn2.ReadOnly = true;
            this.adresaZDataGridViewTextBoxColumn2.Width = 90;
            // 
            // emailZDataGridViewTextBoxColumn2
            // 
            this.emailZDataGridViewTextBoxColumn2.DataPropertyName = "emailZ";
            this.emailZDataGridViewTextBoxColumn2.HeaderText = "emailZ";
            this.emailZDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.emailZDataGridViewTextBoxColumn2.Name = "emailZDataGridViewTextBoxColumn2";
            this.emailZDataGridViewTextBoxColumn2.ReadOnly = true;
            this.emailZDataGridViewTextBoxColumn2.Width = 79;
            // 
            // telefonZDataGridViewTextBoxColumn2
            // 
            this.telefonZDataGridViewTextBoxColumn2.DataPropertyName = "telefonZ";
            this.telefonZDataGridViewTextBoxColumn2.HeaderText = "telefonZ";
            this.telefonZDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.telefonZDataGridViewTextBoxColumn2.Name = "telefonZDataGridViewTextBoxColumn2";
            this.telefonZDataGridViewTextBoxColumn2.ReadOnly = true;
            this.telefonZDataGridViewTextBoxColumn2.Width = 89;
            // 
            // idPoslaDataGridViewTextBoxColumn2
            // 
            this.idPoslaDataGridViewTextBoxColumn2.DataPropertyName = "idPosla";
            this.idPoslaDataGridViewTextBoxColumn2.HeaderText = "idPosla";
            this.idPoslaDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idPoslaDataGridViewTextBoxColumn2.Name = "idPoslaDataGridViewTextBoxColumn2";
            this.idPoslaDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idPoslaDataGridViewTextBoxColumn2.Width = 83;
            // 
            // aktivanDataGridViewCheckBoxColumn2
            // 
            this.aktivanDataGridViewCheckBoxColumn2.DataPropertyName = "aktivan";
            this.aktivanDataGridViewCheckBoxColumn2.HeaderText = "aktivan";
            this.aktivanDataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.aktivanDataGridViewCheckBoxColumn2.Name = "aktivanDataGridViewCheckBoxColumn2";
            this.aktivanDataGridViewCheckBoxColumn2.ReadOnly = true;
            this.aktivanDataGridViewCheckBoxColumn2.Width = 59;
            // 
            // viewZaposleniBindingSource
            // 
            this.viewZaposleniBindingSource.DataMember = "view_Zaposleni";
            this.viewZaposleniBindingSource.DataSource = this.prodavnicaIgracakaDataSet4;
            // 
            // prodavnicaIgracakaDataSet4
            // 
            this.prodavnicaIgracakaDataSet4.DataSetName = "ProdavnicaIgracakaDataSet4";
            this.prodavnicaIgracakaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpZaposlenje
            // 
            this.dtpZaposlenje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpZaposlenje.Location = new System.Drawing.Point(236, 210);
            this.dtpZaposlenje.Name = "dtpZaposlenje";
            this.dtpZaposlenje.Size = new System.Drawing.Size(233, 30);
            this.dtpZaposlenje.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(19, 488);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 53);
            this.button2.TabIndex = 20;
            this.button2.Text = "Dodaj zaposlenog";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbPosao
            // 
            this.cbPosao.DataSource = this.pOSAOBindingSource;
            this.cbPosao.DisplayMember = "nazivPosla";
            this.cbPosao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosao.FormattingEnabled = true;
            this.cbPosao.Location = new System.Drawing.Point(236, 434);
            this.cbPosao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPosao.Name = "cbPosao";
            this.cbPosao.Size = new System.Drawing.Size(230, 30);
            this.cbPosao.TabIndex = 19;
            this.cbPosao.ValueMember = "nazivPosla";
            // 
            // pOSAOBindingSource
            // 
            this.pOSAOBindingSource.DataMember = "POSAO";
            this.pOSAOBindingSource.DataSource = this.posao;
            // 
            // posao
            // 
            this.posao.DataSetName = "Posao";
            this.posao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTelefonZ
            // 
            this.txtTelefonZ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonZ.Location = new System.Drawing.Point(235, 389);
            this.txtTelefonZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefonZ.Name = "txtTelefonZ";
            this.txtTelefonZ.Size = new System.Drawing.Size(233, 30);
            this.txtTelefonZ.TabIndex = 18;
            // 
            // txtEmailZ
            // 
            this.txtEmailZ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailZ.Location = new System.Drawing.Point(236, 341);
            this.txtEmailZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailZ.Name = "txtEmailZ";
            this.txtEmailZ.Size = new System.Drawing.Size(233, 30);
            this.txtEmailZ.TabIndex = 17;
            // 
            // txtAdresaZ
            // 
            this.txtAdresaZ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresaZ.Location = new System.Drawing.Point(236, 295);
            this.txtAdresaZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdresaZ.Name = "txtAdresaZ";
            this.txtAdresaZ.Size = new System.Drawing.Size(233, 30);
            this.txtAdresaZ.TabIndex = 16;
            // 
            // txtPlata
            // 
            this.txtPlata.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlata.Location = new System.Drawing.Point(235, 249);
            this.txtPlata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlata.Name = "txtPlata";
            this.txtPlata.Size = new System.Drawing.Size(233, 30);
            this.txtPlata.TabIndex = 15;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLozinka.Location = new System.Drawing.Point(235, 165);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(233, 30);
            this.txtLozinka.TabIndex = 13;
            // 
            // txtKorIme
            // 
            this.txtKorIme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorIme.Location = new System.Drawing.Point(235, 123);
            this.txtKorIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(233, 30);
            this.txtKorIme.TabIndex = 12;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.Location = new System.Drawing.Point(235, 82);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(233, 30);
            this.txtPrezime.TabIndex = 11;
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(236, 42);
            this.txtIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(233, 30);
            this.txtIme.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 434);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 27);
            this.label14.TabIndex = 9;
            this.label14.Text = "Posao:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 27);
            this.label13.TabIndex = 8;
            this.label13.Text = "Lozinka:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 27);
            this.label12.TabIndex = 7;
            this.label12.Text = "Korisničko ime:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 27);
            this.label11.TabIndex = 6;
            this.label11.Text = "Telefon:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 27);
            this.label10.TabIndex = 5;
            this.label10.Text = "E-mail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 27);
            this.label9.TabIndex = 4;
            this.label9.Text = "Adresa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 27);
            this.label8.TabIndex = 3;
            this.label8.Text = "Plata:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 27);
            this.label7.TabIndex = 2;
            this.label7.Text = "Datum zaposlenja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "Prezime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ime:";
            // 
            // pnlNabavke
            // 
            this.pnlNabavke.BackColor = System.Drawing.Color.Transparent;
            this.pnlNabavke.Controls.Add(this.pictureBox2);
            this.pnlNabavke.Controls.Add(this.dateTimePicker1);
            this.pnlNabavke.Controls.Add(this.cbMagacin);
            this.pnlNabavke.Controls.Add(this.label20);
            this.pnlNabavke.Controls.Add(this.button1);
            this.pnlNabavke.Controls.Add(this.cbDobavljac);
            this.pnlNabavke.Controls.Add(this.label16);
            this.pnlNabavke.Controls.Add(this.label15);
            this.pnlNabavke.Location = new System.Drawing.Point(235, 21);
            this.pnlNabavke.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNabavke.Name = "pnlNabavke";
            this.pnlNabavke.Size = new System.Drawing.Size(993, 559);
            this.pnlNabavke.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(582, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(380, 310);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(323, 248);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 30);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // cbMagacin
            // 
            this.cbMagacin.DataSource = this.mAGACINBindingSource;
            this.cbMagacin.DisplayMember = "nazivM";
            this.cbMagacin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMagacin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMagacin.FormattingEnabled = true;
            this.cbMagacin.Location = new System.Drawing.Point(323, 176);
            this.cbMagacin.Margin = new System.Windows.Forms.Padding(4);
            this.cbMagacin.Name = "cbMagacin";
            this.cbMagacin.Size = new System.Drawing.Size(229, 35);
            this.cbMagacin.TabIndex = 10;
            this.cbMagacin.ValueMember = "nazivM";
            // 
            // mAGACINBindingSource
            // 
            this.mAGACINBindingSource.DataMember = "MAGACIN";
            this.mAGACINBindingSource.DataSource = this.magacin;
            // 
            // magacin
            // 
            this.magacin.DataSetName = "Magacin";
            this.magacin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(84, 184);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 27);
            this.label20.TabIndex = 9;
            this.label20.Text = "Magacin:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(78, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(477, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "Započni unos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.DataSource = this.dOBAVLJACBindingSource;
            this.cbDobavljac.DisplayMember = "nazivD";
            this.cbDobavljac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDobavljac.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(323, 119);
            this.cbDobavljac.Margin = new System.Windows.Forms.Padding(4);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(229, 35);
            this.cbDobavljac.TabIndex = 2;
            // 
            // dOBAVLJACBindingSource
            // 
            this.dOBAVLJACBindingSource.DataMember = "DOBAVLJAC";
            this.dOBAVLJACBindingSource.DataSource = this.dobavljac;
            // 
            // dobavljac
            // 
            this.dobavljac.DataSetName = "Dobavljac";
            this.dobavljac.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(82, 243);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(216, 27);
            this.label16.TabIndex = 1;
            this.label16.Text = "Datum prijema robe: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(82, 123);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(196, 27);
            this.label15.TabIndex = 0;
            this.label15.Text = "Spisak dobavljača: ";
            // 
            // pnlDobavljac
            // 
            this.pnlDobavljac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDobavljac.BackColor = System.Drawing.Color.Transparent;
            this.pnlDobavljac.Controls.Add(this.pictureBox3);
            this.pnlDobavljac.Controls.Add(this.btnIzmaniDob);
            this.pnlDobavljac.Controls.Add(this.txtPib);
            this.pnlDobavljac.Controls.Add(this.label37);
            this.pnlDobavljac.Controls.Add(this.dgvPrikazDobavljaca);
            this.pnlDobavljac.Controls.Add(this.btnDobavljac);
            this.pnlDobavljac.Controls.Add(this.txtTelefonDob);
            this.pnlDobavljac.Controls.Add(this.txtAdresaDob);
            this.pnlDobavljac.Controls.Add(this.label19);
            this.pnlDobavljac.Controls.Add(this.label18);
            this.pnlDobavljac.Controls.Add(this.txtNazivDob);
            this.pnlDobavljac.Controls.Add(this.label17);
            this.pnlDobavljac.Location = new System.Drawing.Point(236, 21);
            this.pnlDobavljac.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDobavljac.Name = "pnlDobavljac";
            this.pnlDobavljac.Size = new System.Drawing.Size(993, 559);
            this.pnlDobavljac.TabIndex = 20;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(667, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(306, 266);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // btnIzmaniDob
            // 
            this.btnIzmaniDob.BackColor = System.Drawing.Color.LightBlue;
            this.btnIzmaniDob.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIzmaniDob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmaniDob.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmaniDob.Location = new System.Drawing.Point(377, 239);
            this.btnIzmaniDob.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmaniDob.Name = "btnIzmaniDob";
            this.btnIzmaniDob.Size = new System.Drawing.Size(256, 52);
            this.btnIzmaniDob.TabIndex = 10;
            this.btnIzmaniDob.Text = "Izmeni";
            this.btnIzmaniDob.UseVisualStyleBackColor = false;
            this.btnIzmaniDob.Click += new System.EventHandler(this.btnIzmaniDob_Click);
            // 
            // txtPib
            // 
            this.txtPib.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPib.Location = new System.Drawing.Point(242, 185);
            this.txtPib.Margin = new System.Windows.Forms.Padding(4);
            this.txtPib.Name = "txtPib";
            this.txtPib.Size = new System.Drawing.Size(391, 35);
            this.txtPib.TabIndex = 9;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(45, 188);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(56, 27);
            this.label37.TabIndex = 8;
            this.label37.Text = "PIB:";
            // 
            // dgvPrikazDobavljaca
            // 
            this.dgvPrikazDobavljaca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrikazDobavljaca.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvPrikazDobavljaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazDobavljaca.Location = new System.Drawing.Point(41, 314);
            this.dgvPrikazDobavljaca.Name = "dgvPrikazDobavljaca";
            this.dgvPrikazDobavljaca.RowHeadersWidth = 51;
            this.dgvPrikazDobavljaca.RowTemplate.Height = 24;
            this.dgvPrikazDobavljaca.Size = new System.Drawing.Size(932, 226);
            this.dgvPrikazDobavljaca.TabIndex = 7;
            this.dgvPrikazDobavljaca.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPrikazDobavljaca_MouseDoubleClick);
            // 
            // btnDobavljac
            // 
            this.btnDobavljac.BackColor = System.Drawing.Color.LightBlue;
            this.btnDobavljac.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDobavljac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDobavljac.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDobavljac.Location = new System.Drawing.Point(44, 236);
            this.btnDobavljac.Margin = new System.Windows.Forms.Padding(4);
            this.btnDobavljac.Name = "btnDobavljac";
            this.btnDobavljac.Size = new System.Drawing.Size(306, 55);
            this.btnDobavljac.TabIndex = 6;
            this.btnDobavljac.Text = "Dodaj dobavljača";
            this.btnDobavljac.UseVisualStyleBackColor = false;
            this.btnDobavljac.Click += new System.EventHandler(this.btnDobavljac_Click);
            // 
            // txtTelefonDob
            // 
            this.txtTelefonDob.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonDob.Location = new System.Drawing.Point(242, 135);
            this.txtTelefonDob.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonDob.Name = "txtTelefonDob";
            this.txtTelefonDob.Size = new System.Drawing.Size(391, 35);
            this.txtTelefonDob.TabIndex = 5;
            // 
            // txtAdresaDob
            // 
            this.txtAdresaDob.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresaDob.Location = new System.Drawing.Point(242, 79);
            this.txtAdresaDob.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdresaDob.Name = "txtAdresaDob";
            this.txtAdresaDob.Size = new System.Drawing.Size(391, 35);
            this.txtAdresaDob.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(45, 138);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 27);
            this.label19.TabIndex = 3;
            this.label19.Text = "Telefon:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(45, 79);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 27);
            this.label18.TabIndex = 2;
            this.label18.Text = "Adresa:";
            // 
            // txtNazivDob
            // 
            this.txtNazivDob.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivDob.Location = new System.Drawing.Point(242, 27);
            this.txtNazivDob.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazivDob.Name = "txtNazivDob";
            this.txtNazivDob.Size = new System.Drawing.Size(391, 35);
            this.txtNazivDob.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(45, 29);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(184, 27);
            this.label17.TabIndex = 0;
            this.label17.Text = "Naziv dobavljača:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pnlKategorija
            // 
            this.pnlKategorija.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlKategorija.BackColor = System.Drawing.Color.Transparent;
            this.pnlKategorija.Controls.Add(this.button6);
            this.pnlKategorija.Controls.Add(this.button5);
            this.pnlKategorija.Controls.Add(this.label25);
            this.pnlKategorija.Controls.Add(this.label24);
            this.pnlKategorija.Controls.Add(this.dgvBrend);
            this.pnlKategorija.Controls.Add(this.btnBrend);
            this.pnlKategorija.Controls.Add(this.txtBrend);
            this.pnlKategorija.Controls.Add(this.label23);
            this.pnlKategorija.Controls.Add(this.dgvKategorije);
            this.pnlKategorija.Controls.Add(this.btnKategorije);
            this.pnlKategorija.Controls.Add(this.txtNazivKat);
            this.pnlKategorija.Controls.Add(this.label4);
            this.pnlKategorija.Location = new System.Drawing.Point(236, 21);
            this.pnlKategorija.Name = "pnlKategorija";
            this.pnlKategorija.Size = new System.Drawing.Size(993, 554);
            this.pnlKategorija.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightBlue;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(721, 131);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(241, 64);
            this.button6.TabIndex = 11;
            this.button6.Text = "Izmeni brend";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightBlue;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(261, 131);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(208, 66);
            this.button5.TabIndex = 10;
            this.button5.Text = "Izmeni kategoriju";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(605, 25);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(253, 27);
            this.label25.TabIndex = 9;
            this.label25.Text = "Dodavanje novog brenda";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(101, 25);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(270, 27);
            this.label24.TabIndex = 8;
            this.label24.Text = "Dodavanje nove kategorije";
            // 
            // dgvBrend
            // 
            this.dgvBrend.AllowUserToAddRows = false;
            this.dgvBrend.AllowUserToDeleteRows = false;
            this.dgvBrend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrend.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvBrend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrend.Location = new System.Drawing.Point(506, 226);
            this.dgvBrend.Name = "dgvBrend";
            this.dgvBrend.ReadOnly = true;
            this.dgvBrend.RowHeadersWidth = 51;
            this.dgvBrend.RowTemplate.Height = 24;
            this.dgvBrend.Size = new System.Drawing.Size(456, 308);
            this.dgvBrend.TabIndex = 7;
            this.dgvBrend.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvBrend_MouseDoubleClick);
            // 
            // btnBrend
            // 
            this.btnBrend.BackColor = System.Drawing.Color.LightBlue;
            this.btnBrend.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBrend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrend.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrend.Location = new System.Drawing.Point(506, 131);
            this.btnBrend.Name = "btnBrend";
            this.btnBrend.Size = new System.Drawing.Size(195, 64);
            this.btnBrend.TabIndex = 6;
            this.btnBrend.Text = "Dodaj brend";
            this.btnBrend.UseVisualStyleBackColor = false;
            this.btnBrend.Click += new System.EventHandler(this.btnBrend_Click);
            // 
            // txtBrend
            // 
            this.txtBrend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrend.Location = new System.Drawing.Point(667, 78);
            this.txtBrend.Name = "txtBrend";
            this.txtBrend.Size = new System.Drawing.Size(295, 30);
            this.txtBrend.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(502, 81);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(135, 25);
            this.label23.TabIndex = 4;
            this.label23.Text = "Naziv brenda:";
            // 
            // dgvKategorije
            // 
            this.dgvKategorije.AllowUserToAddRows = false;
            this.dgvKategorije.AllowUserToDeleteRows = false;
            this.dgvKategorije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKategorije.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorije.Location = new System.Drawing.Point(16, 226);
            this.dgvKategorije.Name = "dgvKategorije";
            this.dgvKategorije.ReadOnly = true;
            this.dgvKategorije.RowHeadersWidth = 51;
            this.dgvKategorije.RowTemplate.Height = 24;
            this.dgvKategorije.Size = new System.Drawing.Size(453, 308);
            this.dgvKategorije.TabIndex = 3;
            this.dgvKategorije.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKategorije_MouseDoubleClick);
            // 
            // btnKategorije
            // 
            this.btnKategorije.BackColor = System.Drawing.Color.LightBlue;
            this.btnKategorije.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKategorije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategorije.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategorije.Location = new System.Drawing.Point(16, 131);
            this.btnKategorije.Name = "btnKategorije";
            this.btnKategorije.Size = new System.Drawing.Size(219, 65);
            this.btnKategorije.TabIndex = 2;
            this.btnKategorije.Text = "Dodaj kategoriju";
            this.btnKategorije.UseVisualStyleBackColor = false;
            this.btnKategorije.Click += new System.EventHandler(this.btnKategorije_Click);
            // 
            // txtNazivKat
            // 
            this.txtNazivKat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivKat.Location = new System.Drawing.Point(192, 78);
            this.txtNazivKat.Name = "txtNazivKat";
            this.txtNazivKat.Size = new System.Drawing.Size(277, 30);
            this.txtNazivKat.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Naziv kategorije:";
            // 
            // pnlOtpustiRadnika
            // 
            this.pnlOtpustiRadnika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOtpustiRadnika.BackColor = System.Drawing.Color.Transparent;
            this.pnlOtpustiRadnika.Controls.Add(this.pictureBox4);
            this.pnlOtpustiRadnika.Controls.Add(this.btnOtpustiZap);
            this.pnlOtpustiRadnika.Controls.Add(this.txtIdZap);
            this.pnlOtpustiRadnika.Controls.Add(this.label22);
            this.pnlOtpustiRadnika.Controls.Add(this.dgvZaposleni);
            this.pnlOtpustiRadnika.Controls.Add(this.btnPronadjiZap);
            this.pnlOtpustiRadnika.Controls.Add(this.txtImeZap);
            this.pnlOtpustiRadnika.Controls.Add(this.label21);
            this.pnlOtpustiRadnika.Location = new System.Drawing.Point(236, 21);
            this.pnlOtpustiRadnika.Name = "pnlOtpustiRadnika";
            this.pnlOtpustiRadnika.Size = new System.Drawing.Size(993, 559);
            this.pnlOtpustiRadnika.TabIndex = 21;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(721, 54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(241, 429);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // btnOtpustiZap
            // 
            this.btnOtpustiZap.BackColor = System.Drawing.Color.LightBlue;
            this.btnOtpustiZap.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOtpustiZap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtpustiZap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtpustiZap.ForeColor = System.Drawing.Color.Black;
            this.btnOtpustiZap.Location = new System.Drawing.Point(19, 430);
            this.btnOtpustiZap.Name = "btnOtpustiZap";
            this.btnOtpustiZap.Size = new System.Drawing.Size(666, 57);
            this.btnOtpustiZap.TabIndex = 6;
            this.btnOtpustiZap.Text = "Otpusti radnika";
            this.btnOtpustiZap.UseVisualStyleBackColor = false;
            this.btnOtpustiZap.Click += new System.EventHandler(this.btnOtpustiZap_Click);
            // 
            // txtIdZap
            // 
            this.txtIdZap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdZap.Location = new System.Drawing.Point(261, 377);
            this.txtIdZap.Name = "txtIdZap";
            this.txtIdZap.ReadOnly = true;
            this.txtIdZap.Size = new System.Drawing.Size(424, 30);
            this.txtIdZap.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(14, 381);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(196, 25);
            this.label22.TabIndex = 4;
            this.label22.Text = "Id izabranog radnika:";
            // 
            // dgvZaposleni
            // 
            this.dgvZaposleni.AllowUserToAddRows = false;
            this.dgvZaposleni.AllowUserToDeleteRows = false;
            this.dgvZaposleni.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvZaposleni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposleni.Location = new System.Drawing.Point(19, 155);
            this.dgvZaposleni.Name = "dgvZaposleni";
            this.dgvZaposleni.ReadOnly = true;
            this.dgvZaposleni.RowHeadersWidth = 51;
            this.dgvZaposleni.RowTemplate.Height = 24;
            this.dgvZaposleni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposleni.Size = new System.Drawing.Size(665, 202);
            this.dgvZaposleni.TabIndex = 3;
            this.dgvZaposleni.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvZaposleni_MouseDoubleClick);
            // 
            // btnPronadjiZap
            // 
            this.btnPronadjiZap.BackColor = System.Drawing.Color.LightBlue;
            this.btnPronadjiZap.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPronadjiZap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPronadjiZap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPronadjiZap.ForeColor = System.Drawing.Color.Black;
            this.btnPronadjiZap.Location = new System.Drawing.Point(19, 87);
            this.btnPronadjiZap.Name = "btnPronadjiZap";
            this.btnPronadjiZap.Size = new System.Drawing.Size(666, 55);
            this.btnPronadjiZap.TabIndex = 2;
            this.btnPronadjiZap.Text = "Pronađi zaposlenog";
            this.btnPronadjiZap.UseVisualStyleBackColor = false;
            this.btnPronadjiZap.Click += new System.EventHandler(this.btnPronadjiZap_Click);
            // 
            // txtImeZap
            // 
            this.txtImeZap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImeZap.Location = new System.Drawing.Point(261, 47);
            this.txtImeZap.Name = "txtImeZap";
            this.txtImeZap.Size = new System.Drawing.Size(424, 30);
            this.txtImeZap.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(14, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(225, 25);
            this.label21.TabIndex = 0;
            this.label21.Text = "Unesite ime zaposlenog:";
            // 
            // pnlProizvodIzv
            // 
            this.pnlProizvodIzv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProizvodIzv.BackColor = System.Drawing.Color.Transparent;
            this.pnlProizvodIzv.Controls.Add(this.dataGridView1);
            this.pnlProizvodIzv.Controls.Add(this.label28);
            this.pnlProizvodIzv.Controls.Add(this.btnPrikazPro);
            this.pnlProizvodIzv.Controls.Add(this.dgvPrikazProizvoda);
            this.pnlProizvodIzv.Controls.Add(this.label27);
            this.pnlProizvodIzv.Controls.Add(this.label26);
            this.pnlProizvodIzv.Controls.Add(this.cbB);
            this.pnlProizvodIzv.Controls.Add(this.cbKat);
            this.pnlProizvodIzv.Location = new System.Drawing.Point(236, 21);
            this.pnlProizvodIzv.Name = "pnlProizvodIzv";
            this.pnlProizvodIzv.Size = new System.Drawing.Size(993, 559);
            this.pnlProizvodIzv.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(506, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(456, 440);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(539, 26);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(398, 54);
            this.label28.TabIndex = 6;
            this.label28.Text = "Prikaz proizvoda od najprodavanijeg ka \r\nnajmanje prodavanom:";
            // 
            // btnPrikazPro
            // 
            this.btnPrikazPro.BackColor = System.Drawing.Color.LightBlue;
            this.btnPrikazPro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrikazPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazPro.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazPro.Location = new System.Drawing.Point(32, 114);
            this.btnPrikazPro.Name = "btnPrikazPro";
            this.btnPrikazPro.Size = new System.Drawing.Size(448, 80);
            this.btnPrikazPro.TabIndex = 5;
            this.btnPrikazPro.Text = "Prikaz proizvoda izabrane kategorije i brenda";
            this.btnPrikazPro.UseVisualStyleBackColor = false;
            this.btnPrikazPro.Click += new System.EventHandler(this.btnPrikazPro_Click);
            // 
            // dgvPrikazProizvoda
            // 
            this.dgvPrikazProizvoda.AllowUserToDeleteRows = false;
            this.dgvPrikazProizvoda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrikazProizvoda.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvPrikazProizvoda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazProizvoda.Location = new System.Drawing.Point(37, 213);
            this.dgvPrikazProizvoda.Name = "dgvPrikazProizvoda";
            this.dgvPrikazProizvoda.ReadOnly = true;
            this.dgvPrikazProizvoda.RowHeadersWidth = 51;
            this.dgvPrikazProizvoda.RowTemplate.Height = 24;
            this.dgvPrikazProizvoda.Size = new System.Drawing.Size(443, 321);
            this.dgvPrikazProizvoda.TabIndex = 4;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(26, 71);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(148, 25);
            this.label27.TabIndex = 3;
            this.label27.Text = "Izaberite brend:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(28, 33);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(187, 25);
            this.label26.TabIndex = 2;
            this.label26.Text = "Izaberite kategoriju:";
            // 
            // cbB
            // 
            this.cbB.DataSource = this.bRENDBindingSource;
            this.cbB.DisplayMember = "nazivB";
            this.cbB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbB.FormattingEnabled = true;
            this.cbB.Location = new System.Drawing.Point(235, 71);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(245, 30);
            this.cbB.TabIndex = 1;
            this.cbB.SelectedIndexChanged += new System.EventHandler(this.cbB_SelectedIndexChanged);
            // 
            // cbKat
            // 
            this.cbKat.DataSource = this.kATEGORIJABindingSource2;
            this.cbKat.DisplayMember = "nazivKat";
            this.cbKat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKat.FormattingEnabled = true;
            this.cbKat.Location = new System.Drawing.Point(235, 30);
            this.cbKat.Name = "cbKat";
            this.cbKat.Size = new System.Drawing.Size(245, 30);
            this.cbKat.TabIndex = 0;
            this.cbKat.SelectedIndexChanged += new System.EventHandler(this.cbKat_SelectedIndexChanged);
            // 
            // prodavnicaIgracakaDataSet3
            // 
            this.prodavnicaIgracakaDataSet3.DataSetName = "ProdavnicaIgracakaDataSet3";
            this.prodavnicaIgracakaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poredjajOdNajprodavanijegBindingSource
            // 
            this.poredjajOdNajprodavanijegBindingSource.DataMember = "poredjajOdNajprodavanijeg";
            this.poredjajOdNajprodavanijegBindingSource.DataSource = this.prodavnicaIgracakaDataSet3;
            // 
            // poredjajOdNajprodavanijegTableAdapter
            // 
            this.poredjajOdNajprodavanijegTableAdapter.ClearBeforeFill = true;
            // 
            // pnlNabavkeIzv
            // 
            this.pnlNabavkeIzv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNabavkeIzv.BackColor = System.Drawing.Color.Transparent;
            this.pnlNabavkeIzv.Controls.Add(this.label29);
            this.pnlNabavkeIzv.Controls.Add(this.dgvNabavkeIzv);
            this.pnlNabavkeIzv.Location = new System.Drawing.Point(236, 21);
            this.pnlNabavkeIzv.Name = "pnlNabavkeIzv";
            this.pnlNabavkeIzv.Size = new System.Drawing.Size(993, 559);
            this.pnlNabavkeIzv.TabIndex = 23;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(321, 26);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(243, 34);
            this.label29.TabIndex = 1;
            this.label29.Text = "Prikaz svih nabavki";
            // 
            // dgvNabavkeIzv
            // 
            this.dgvNabavkeIzv.AllowUserToAddRows = false;
            this.dgvNabavkeIzv.AllowUserToDeleteRows = false;
            this.dgvNabavkeIzv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNabavkeIzv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNabavkeIzv.Location = new System.Drawing.Point(16, 78);
            this.dgvNabavkeIzv.Name = "dgvNabavkeIzv";
            this.dgvNabavkeIzv.ReadOnly = true;
            this.dgvNabavkeIzv.RowHeadersWidth = 51;
            this.dgvNabavkeIzv.RowTemplate.Height = 24;
            this.dgvNabavkeIzv.Size = new System.Drawing.Size(957, 462);
            this.dgvNabavkeIzv.TabIndex = 0;
            // 
            // viewNabavkeBindingSource
            // 
            this.viewNabavkeBindingSource.DataMember = "view_Nabavke";
            // 
            // pnlZaposleniIzv
            // 
            this.pnlZaposleniIzv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlZaposleniIzv.BackColor = System.Drawing.Color.Transparent;
            this.pnlZaposleniIzv.Controls.Add(this.btnPrikazRacuna);
            this.pnlZaposleniIzv.Controls.Add(this.label34);
            this.pnlZaposleniIzv.Controls.Add(this.dgvIzdati);
            this.pnlZaposleniIzv.Controls.Add(this.txtZapId);
            this.pnlZaposleniIzv.Controls.Add(this.label33);
            this.pnlZaposleniIzv.Controls.Add(this.dgvPronadjiZap);
            this.pnlZaposleniIzv.Controls.Add(this.button3);
            this.pnlZaposleniIzv.Controls.Add(this.txtZap);
            this.pnlZaposleniIzv.Controls.Add(this.label32);
            this.pnlZaposleniIzv.Controls.Add(this.dgvOtpusten);
            this.pnlZaposleniIzv.Controls.Add(this.label31);
            this.pnlZaposleniIzv.Controls.Add(this.dgvZap);
            this.pnlZaposleniIzv.Controls.Add(this.label30);
            this.pnlZaposleniIzv.Location = new System.Drawing.Point(236, 21);
            this.pnlZaposleniIzv.Name = "pnlZaposleniIzv";
            this.pnlZaposleniIzv.Size = new System.Drawing.Size(993, 559);
            this.pnlZaposleniIzv.TabIndex = 24;
            // 
            // btnPrikazRacuna
            // 
            this.btnPrikazRacuna.BackColor = System.Drawing.Color.LightBlue;
            this.btnPrikazRacuna.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrikazRacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazRacuna.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazRacuna.Location = new System.Drawing.Point(503, 290);
            this.btnPrikazRacuna.Name = "btnPrikazRacuna";
            this.btnPrikazRacuna.Size = new System.Drawing.Size(470, 35);
            this.btnPrikazRacuna.TabIndex = 12;
            this.btnPrikazRacuna.Text = "Prikaži račune";
            this.btnPrikazRacuna.UseVisualStyleBackColor = false;
            this.btnPrikazRacuna.Click += new System.EventHandler(this.btnPrikazRacuna_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(522, 13);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(372, 27);
            this.label34.TabIndex = 11;
            this.label34.Text = "Prikaz racuna koje je zaposleni izdao:";
            // 
            // dgvIzdati
            // 
            this.dgvIzdati.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvIzdati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzdati.Location = new System.Drawing.Point(503, 330);
            this.dgvIzdati.Name = "dgvIzdati";
            this.dgvIzdati.RowHeadersWidth = 51;
            this.dgvIzdati.RowTemplate.Height = 24;
            this.dgvIzdati.Size = new System.Drawing.Size(470, 211);
            this.dgvIzdati.TabIndex = 10;
            // 
            // txtZapId
            // 
            this.txtZapId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZapId.Location = new System.Drawing.Point(748, 255);
            this.txtZapId.Name = "txtZapId";
            this.txtZapId.ReadOnly = true;
            this.txtZapId.Size = new System.Drawing.Size(225, 30);
            this.txtZapId.TabIndex = 9;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(502, 258);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(228, 25);
            this.label33.TabIndex = 8;
            this.label33.Text = "Id izabranog zaposlenog:";
            // 
            // dgvPronadjiZap
            // 
            this.dgvPronadjiZap.AllowUserToAddRows = false;
            this.dgvPronadjiZap.AllowUserToDeleteRows = false;
            this.dgvPronadjiZap.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvPronadjiZap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPronadjiZap.Location = new System.Drawing.Point(503, 132);
            this.dgvPronadjiZap.Name = "dgvPronadjiZap";
            this.dgvPronadjiZap.ReadOnly = true;
            this.dgvPronadjiZap.RowHeadersWidth = 51;
            this.dgvPronadjiZap.RowTemplate.Height = 24;
            this.dgvPronadjiZap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPronadjiZap.Size = new System.Drawing.Size(470, 103);
            this.dgvPronadjiZap.TabIndex = 7;
            this.dgvPronadjiZap.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPronadjiZap_MouseDoubleClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(503, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(470, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "Prikaži zaposlene";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtZap
            // 
            this.txtZap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZap.Location = new System.Drawing.Point(748, 51);
            this.txtZap.Name = "txtZap";
            this.txtZap.Size = new System.Drawing.Size(225, 30);
            this.txtZap.TabIndex = 5;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(499, 54);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(225, 25);
            this.label32.TabIndex = 4;
            this.label32.Text = "Unesite ime zaposlenog:";
            // 
            // dgvOtpusten
            // 
            this.dgvOtpusten.AllowUserToAddRows = false;
            this.dgvOtpusten.AllowUserToDeleteRows = false;
            this.dgvOtpusten.AutoGenerateColumns = false;
            this.dgvOtpusten.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvOtpusten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtpusten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZDataGridViewTextBoxColumn1,
            this.imeDataGridViewTextBoxColumn1,
            this.prezimeDataGridViewTextBoxColumn1,
            this.korImeDataGridViewTextBoxColumn1,
            this.lozinkaDataGridViewTextBoxColumn1,
            this.datZapDataGridViewTextBoxColumn1,
            this.plataDataGridViewTextBoxColumn1,
            this.adresaZDataGridViewTextBoxColumn1,
            this.emailZDataGridViewTextBoxColumn1,
            this.telefonZDataGridViewTextBoxColumn1,
            this.idPoslaDataGridViewTextBoxColumn1,
            this.aktivanDataGridViewCheckBoxColumn1});
            this.dgvOtpusten.DataSource = this.viewOtpusteniBindingSource;
            this.dgvOtpusten.Location = new System.Drawing.Point(27, 314);
            this.dgvOtpusten.Name = "dgvOtpusten";
            this.dgvOtpusten.ReadOnly = true;
            this.dgvOtpusten.RowHeadersWidth = 51;
            this.dgvOtpusten.RowTemplate.Height = 24;
            this.dgvOtpusten.Size = new System.Drawing.Size(453, 227);
            this.dgvOtpusten.TabIndex = 3;
            // 
            // idZDataGridViewTextBoxColumn1
            // 
            this.idZDataGridViewTextBoxColumn1.DataPropertyName = "idZ";
            this.idZDataGridViewTextBoxColumn1.HeaderText = "idZ";
            this.idZDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idZDataGridViewTextBoxColumn1.Name = "idZDataGridViewTextBoxColumn1";
            this.idZDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idZDataGridViewTextBoxColumn1.Width = 125;
            // 
            // imeDataGridViewTextBoxColumn1
            // 
            this.imeDataGridViewTextBoxColumn1.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn1.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.imeDataGridViewTextBoxColumn1.Name = "imeDataGridViewTextBoxColumn1";
            this.imeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // prezimeDataGridViewTextBoxColumn1
            // 
            this.prezimeDataGridViewTextBoxColumn1.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn1.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.prezimeDataGridViewTextBoxColumn1.Name = "prezimeDataGridViewTextBoxColumn1";
            this.prezimeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.prezimeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // korImeDataGridViewTextBoxColumn1
            // 
            this.korImeDataGridViewTextBoxColumn1.DataPropertyName = "korIme";
            this.korImeDataGridViewTextBoxColumn1.HeaderText = "korIme";
            this.korImeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.korImeDataGridViewTextBoxColumn1.Name = "korImeDataGridViewTextBoxColumn1";
            this.korImeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.korImeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lozinkaDataGridViewTextBoxColumn1
            // 
            this.lozinkaDataGridViewTextBoxColumn1.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn1.HeaderText = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lozinkaDataGridViewTextBoxColumn1.Name = "lozinkaDataGridViewTextBoxColumn1";
            this.lozinkaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lozinkaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // datZapDataGridViewTextBoxColumn1
            // 
            this.datZapDataGridViewTextBoxColumn1.DataPropertyName = "datZap";
            this.datZapDataGridViewTextBoxColumn1.HeaderText = "datZap";
            this.datZapDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.datZapDataGridViewTextBoxColumn1.Name = "datZapDataGridViewTextBoxColumn1";
            this.datZapDataGridViewTextBoxColumn1.ReadOnly = true;
            this.datZapDataGridViewTextBoxColumn1.Width = 125;
            // 
            // plataDataGridViewTextBoxColumn1
            // 
            this.plataDataGridViewTextBoxColumn1.DataPropertyName = "plata";
            this.plataDataGridViewTextBoxColumn1.HeaderText = "plata";
            this.plataDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.plataDataGridViewTextBoxColumn1.Name = "plataDataGridViewTextBoxColumn1";
            this.plataDataGridViewTextBoxColumn1.ReadOnly = true;
            this.plataDataGridViewTextBoxColumn1.Width = 125;
            // 
            // adresaZDataGridViewTextBoxColumn1
            // 
            this.adresaZDataGridViewTextBoxColumn1.DataPropertyName = "adresaZ";
            this.adresaZDataGridViewTextBoxColumn1.HeaderText = "adresaZ";
            this.adresaZDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.adresaZDataGridViewTextBoxColumn1.Name = "adresaZDataGridViewTextBoxColumn1";
            this.adresaZDataGridViewTextBoxColumn1.ReadOnly = true;
            this.adresaZDataGridViewTextBoxColumn1.Width = 125;
            // 
            // emailZDataGridViewTextBoxColumn1
            // 
            this.emailZDataGridViewTextBoxColumn1.DataPropertyName = "emailZ";
            this.emailZDataGridViewTextBoxColumn1.HeaderText = "emailZ";
            this.emailZDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.emailZDataGridViewTextBoxColumn1.Name = "emailZDataGridViewTextBoxColumn1";
            this.emailZDataGridViewTextBoxColumn1.ReadOnly = true;
            this.emailZDataGridViewTextBoxColumn1.Width = 125;
            // 
            // telefonZDataGridViewTextBoxColumn1
            // 
            this.telefonZDataGridViewTextBoxColumn1.DataPropertyName = "telefonZ";
            this.telefonZDataGridViewTextBoxColumn1.HeaderText = "telefonZ";
            this.telefonZDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.telefonZDataGridViewTextBoxColumn1.Name = "telefonZDataGridViewTextBoxColumn1";
            this.telefonZDataGridViewTextBoxColumn1.ReadOnly = true;
            this.telefonZDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idPoslaDataGridViewTextBoxColumn1
            // 
            this.idPoslaDataGridViewTextBoxColumn1.DataPropertyName = "idPosla";
            this.idPoslaDataGridViewTextBoxColumn1.HeaderText = "idPosla";
            this.idPoslaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idPoslaDataGridViewTextBoxColumn1.Name = "idPoslaDataGridViewTextBoxColumn1";
            this.idPoslaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idPoslaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // aktivanDataGridViewCheckBoxColumn1
            // 
            this.aktivanDataGridViewCheckBoxColumn1.DataPropertyName = "aktivan";
            this.aktivanDataGridViewCheckBoxColumn1.HeaderText = "aktivan";
            this.aktivanDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.aktivanDataGridViewCheckBoxColumn1.Name = "aktivanDataGridViewCheckBoxColumn1";
            this.aktivanDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.aktivanDataGridViewCheckBoxColumn1.Width = 125;
            // 
            // viewOtpusteniBindingSource
            // 
            this.viewOtpusteniBindingSource.DataMember = "view_Otpusteni";
            this.viewOtpusteniBindingSource.DataSource = this.prodavnicaIgracakaDataSet5;
            // 
            // prodavnicaIgracakaDataSet5
            // 
            this.prodavnicaIgracakaDataSet5.DataSetName = "ProdavnicaIgracakaDataSet5";
            this.prodavnicaIgracakaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(24, 285);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(276, 25);
            this.label31.TabIndex = 2;
            this.label31.Text = "Prikaz svih otpuštenih radnika";
            // 
            // dgvZap
            // 
            this.dgvZap.AllowUserToAddRows = false;
            this.dgvZap.AllowUserToDeleteRows = false;
            this.dgvZap.AutoGenerateColumns = false;
            this.dgvZap.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvZap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.korImeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.datZapDataGridViewTextBoxColumn,
            this.plataDataGridViewTextBoxColumn,
            this.adresaZDataGridViewTextBoxColumn,
            this.emailZDataGridViewTextBoxColumn,
            this.telefonZDataGridViewTextBoxColumn,
            this.idPoslaDataGridViewTextBoxColumn,
            this.aktivanDataGridViewCheckBoxColumn});
            this.dgvZap.DataSource = this.viewZaposleniBindingSource;
            this.dgvZap.Location = new System.Drawing.Point(27, 43);
            this.dgvZap.Name = "dgvZap";
            this.dgvZap.ReadOnly = true;
            this.dgvZap.RowHeadersWidth = 51;
            this.dgvZap.RowTemplate.Height = 24;
            this.dgvZap.Size = new System.Drawing.Size(453, 224);
            this.dgvZap.TabIndex = 1;
            // 
            // idZDataGridViewTextBoxColumn
            // 
            this.idZDataGridViewTextBoxColumn.DataPropertyName = "idZ";
            this.idZDataGridViewTextBoxColumn.HeaderText = "idZ";
            this.idZDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idZDataGridViewTextBoxColumn.Name = "idZDataGridViewTextBoxColumn";
            this.idZDataGridViewTextBoxColumn.ReadOnly = true;
            this.idZDataGridViewTextBoxColumn.Width = 125;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn.Width = 125;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prezimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // korImeDataGridViewTextBoxColumn
            // 
            this.korImeDataGridViewTextBoxColumn.DataPropertyName = "korIme";
            this.korImeDataGridViewTextBoxColumn.HeaderText = "korIme";
            this.korImeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.korImeDataGridViewTextBoxColumn.Name = "korImeDataGridViewTextBoxColumn";
            this.korImeDataGridViewTextBoxColumn.ReadOnly = true;
            this.korImeDataGridViewTextBoxColumn.Width = 125;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.lozinkaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datZapDataGridViewTextBoxColumn
            // 
            this.datZapDataGridViewTextBoxColumn.DataPropertyName = "datZap";
            this.datZapDataGridViewTextBoxColumn.HeaderText = "datZap";
            this.datZapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datZapDataGridViewTextBoxColumn.Name = "datZapDataGridViewTextBoxColumn";
            this.datZapDataGridViewTextBoxColumn.ReadOnly = true;
            this.datZapDataGridViewTextBoxColumn.Width = 125;
            // 
            // plataDataGridViewTextBoxColumn
            // 
            this.plataDataGridViewTextBoxColumn.DataPropertyName = "plata";
            this.plataDataGridViewTextBoxColumn.HeaderText = "plata";
            this.plataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plataDataGridViewTextBoxColumn.Name = "plataDataGridViewTextBoxColumn";
            this.plataDataGridViewTextBoxColumn.ReadOnly = true;
            this.plataDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresaZDataGridViewTextBoxColumn
            // 
            this.adresaZDataGridViewTextBoxColumn.DataPropertyName = "adresaZ";
            this.adresaZDataGridViewTextBoxColumn.HeaderText = "adresaZ";
            this.adresaZDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresaZDataGridViewTextBoxColumn.Name = "adresaZDataGridViewTextBoxColumn";
            this.adresaZDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresaZDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailZDataGridViewTextBoxColumn
            // 
            this.emailZDataGridViewTextBoxColumn.DataPropertyName = "emailZ";
            this.emailZDataGridViewTextBoxColumn.HeaderText = "emailZ";
            this.emailZDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailZDataGridViewTextBoxColumn.Name = "emailZDataGridViewTextBoxColumn";
            this.emailZDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailZDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonZDataGridViewTextBoxColumn
            // 
            this.telefonZDataGridViewTextBoxColumn.DataPropertyName = "telefonZ";
            this.telefonZDataGridViewTextBoxColumn.HeaderText = "telefonZ";
            this.telefonZDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonZDataGridViewTextBoxColumn.Name = "telefonZDataGridViewTextBoxColumn";
            this.telefonZDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonZDataGridViewTextBoxColumn.Width = 125;
            // 
            // idPoslaDataGridViewTextBoxColumn
            // 
            this.idPoslaDataGridViewTextBoxColumn.DataPropertyName = "idPosla";
            this.idPoslaDataGridViewTextBoxColumn.HeaderText = "idPosla";
            this.idPoslaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPoslaDataGridViewTextBoxColumn.Name = "idPoslaDataGridViewTextBoxColumn";
            this.idPoslaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPoslaDataGridViewTextBoxColumn.Width = 125;
            // 
            // aktivanDataGridViewCheckBoxColumn
            // 
            this.aktivanDataGridViewCheckBoxColumn.DataPropertyName = "aktivan";
            this.aktivanDataGridViewCheckBoxColumn.HeaderText = "aktivan";
            this.aktivanDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.aktivanDataGridViewCheckBoxColumn.Name = "aktivanDataGridViewCheckBoxColumn";
            this.aktivanDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aktivanDataGridViewCheckBoxColumn.Width = 125;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(23, 13);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(278, 25);
            this.label30.TabIndex = 0;
            this.label30.Text = "Prikaz svih zaposlenih radnika";
            // 
            // view_ZaposleniTableAdapter
            // 
            this.view_ZaposleniTableAdapter.ClearBeforeFill = true;
            // 
            // view_OtpusteniTableAdapter
            // 
            this.view_OtpusteniTableAdapter.ClearBeforeFill = true;
            // 
            // kATEGORIJATableAdapter
            // 
            this.kATEGORIJATableAdapter.ClearBeforeFill = true;
            // 
            // bRENDTableAdapter
            // 
            this.bRENDTableAdapter.ClearBeforeFill = true;
            // 
            // pOSAOTableAdapter
            // 
            this.pOSAOTableAdapter.ClearBeforeFill = true;
            // 
            // dOBAVLJACTableAdapter
            // 
            this.dOBAVLJACTableAdapter.ClearBeforeFill = true;
            // 
            // mAGACINTableAdapter
            // 
            this.mAGACINTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.txtIdRadnika);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.dgvOtpusteniR);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Location = new System.Drawing.Point(236, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 559);
            this.panel1.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightBlue;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(569, 447);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(315, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "Ponovo zaposli";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtIdRadnika
            // 
            this.txtIdRadnika.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdRadnika.Location = new System.Drawing.Point(327, 457);
            this.txtIdRadnika.Name = "txtIdRadnika";
            this.txtIdRadnika.ReadOnly = true;
            this.txtIdRadnika.Size = new System.Drawing.Size(233, 30);
            this.txtIdRadnika.TabIndex = 3;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(102, 457);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(215, 27);
            this.label36.TabIndex = 2;
            this.label36.Text = "Id izabranog radnika:";
            // 
            // dgvOtpusteniR
            // 
            this.dgvOtpusteniR.AllowUserToAddRows = false;
            this.dgvOtpusteniR.AllowUserToDeleteRows = false;
            this.dgvOtpusteniR.AutoGenerateColumns = false;
            this.dgvOtpusteniR.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvOtpusteniR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtpusteniR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZDataGridViewTextBoxColumn3,
            this.imeDataGridViewTextBoxColumn3,
            this.prezimeDataGridViewTextBoxColumn3,
            this.korImeDataGridViewTextBoxColumn3,
            this.lozinkaDataGridViewTextBoxColumn3,
            this.datZapDataGridViewTextBoxColumn3,
            this.plataDataGridViewTextBoxColumn3,
            this.adresaZDataGridViewTextBoxColumn3,
            this.emailZDataGridViewTextBoxColumn3,
            this.telefonZDataGridViewTextBoxColumn3,
            this.idPoslaDataGridViewTextBoxColumn3,
            this.aktivanDataGridViewCheckBoxColumn3});
            this.dgvOtpusteniR.DataSource = this.viewOtpusteniBindingSource;
            this.dgvOtpusteniR.Location = new System.Drawing.Point(106, 138);
            this.dgvOtpusteniR.Name = "dgvOtpusteniR";
            this.dgvOtpusteniR.ReadOnly = true;
            this.dgvOtpusteniR.RowHeadersWidth = 51;
            this.dgvOtpusteniR.RowTemplate.Height = 24;
            this.dgvOtpusteniR.Size = new System.Drawing.Size(778, 291);
            this.dgvOtpusteniR.TabIndex = 1;
            this.dgvOtpusteniR.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseDoubleClick);
            // 
            // idZDataGridViewTextBoxColumn3
            // 
            this.idZDataGridViewTextBoxColumn3.DataPropertyName = "idZ";
            this.idZDataGridViewTextBoxColumn3.HeaderText = "idZ";
            this.idZDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.idZDataGridViewTextBoxColumn3.Name = "idZDataGridViewTextBoxColumn3";
            this.idZDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idZDataGridViewTextBoxColumn3.Width = 57;
            // 
            // imeDataGridViewTextBoxColumn3
            // 
            this.imeDataGridViewTextBoxColumn3.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn3.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.imeDataGridViewTextBoxColumn3.Name = "imeDataGridViewTextBoxColumn3";
            this.imeDataGridViewTextBoxColumn3.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn3.Width = 59;
            // 
            // prezimeDataGridViewTextBoxColumn3
            // 
            this.prezimeDataGridViewTextBoxColumn3.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn3.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.prezimeDataGridViewTextBoxColumn3.Name = "prezimeDataGridViewTextBoxColumn3";
            this.prezimeDataGridViewTextBoxColumn3.ReadOnly = true;
            this.prezimeDataGridViewTextBoxColumn3.Width = 87;
            // 
            // korImeDataGridViewTextBoxColumn3
            // 
            this.korImeDataGridViewTextBoxColumn3.DataPropertyName = "korIme";
            this.korImeDataGridViewTextBoxColumn3.HeaderText = "korIme";
            this.korImeDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.korImeDataGridViewTextBoxColumn3.Name = "korImeDataGridViewTextBoxColumn3";
            this.korImeDataGridViewTextBoxColumn3.ReadOnly = true;
            this.korImeDataGridViewTextBoxColumn3.Width = 79;
            // 
            // lozinkaDataGridViewTextBoxColumn3
            // 
            this.lozinkaDataGridViewTextBoxColumn3.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn3.HeaderText = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.lozinkaDataGridViewTextBoxColumn3.Name = "lozinkaDataGridViewTextBoxColumn3";
            this.lozinkaDataGridViewTextBoxColumn3.ReadOnly = true;
            this.lozinkaDataGridViewTextBoxColumn3.Width = 81;
            // 
            // datZapDataGridViewTextBoxColumn3
            // 
            this.datZapDataGridViewTextBoxColumn3.DataPropertyName = "datZap";
            this.datZapDataGridViewTextBoxColumn3.HeaderText = "datZap";
            this.datZapDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.datZapDataGridViewTextBoxColumn3.Name = "datZapDataGridViewTextBoxColumn3";
            this.datZapDataGridViewTextBoxColumn3.ReadOnly = true;
            this.datZapDataGridViewTextBoxColumn3.Width = 82;
            // 
            // plataDataGridViewTextBoxColumn3
            // 
            this.plataDataGridViewTextBoxColumn3.DataPropertyName = "plata";
            this.plataDataGridViewTextBoxColumn3.HeaderText = "plata";
            this.plataDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.plataDataGridViewTextBoxColumn3.Name = "plataDataGridViewTextBoxColumn3";
            this.plataDataGridViewTextBoxColumn3.ReadOnly = true;
            this.plataDataGridViewTextBoxColumn3.Width = 68;
            // 
            // adresaZDataGridViewTextBoxColumn3
            // 
            this.adresaZDataGridViewTextBoxColumn3.DataPropertyName = "adresaZ";
            this.adresaZDataGridViewTextBoxColumn3.HeaderText = "adresaZ";
            this.adresaZDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.adresaZDataGridViewTextBoxColumn3.Name = "adresaZDataGridViewTextBoxColumn3";
            this.adresaZDataGridViewTextBoxColumn3.ReadOnly = true;
            this.adresaZDataGridViewTextBoxColumn3.Width = 90;
            // 
            // emailZDataGridViewTextBoxColumn3
            // 
            this.emailZDataGridViewTextBoxColumn3.DataPropertyName = "emailZ";
            this.emailZDataGridViewTextBoxColumn3.HeaderText = "emailZ";
            this.emailZDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.emailZDataGridViewTextBoxColumn3.Name = "emailZDataGridViewTextBoxColumn3";
            this.emailZDataGridViewTextBoxColumn3.ReadOnly = true;
            this.emailZDataGridViewTextBoxColumn3.Width = 79;
            // 
            // telefonZDataGridViewTextBoxColumn3
            // 
            this.telefonZDataGridViewTextBoxColumn3.DataPropertyName = "telefonZ";
            this.telefonZDataGridViewTextBoxColumn3.HeaderText = "telefonZ";
            this.telefonZDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.telefonZDataGridViewTextBoxColumn3.Name = "telefonZDataGridViewTextBoxColumn3";
            this.telefonZDataGridViewTextBoxColumn3.ReadOnly = true;
            this.telefonZDataGridViewTextBoxColumn3.Width = 89;
            // 
            // idPoslaDataGridViewTextBoxColumn3
            // 
            this.idPoslaDataGridViewTextBoxColumn3.DataPropertyName = "idPosla";
            this.idPoslaDataGridViewTextBoxColumn3.HeaderText = "idPosla";
            this.idPoslaDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.idPoslaDataGridViewTextBoxColumn3.Name = "idPoslaDataGridViewTextBoxColumn3";
            this.idPoslaDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idPoslaDataGridViewTextBoxColumn3.Width = 83;
            // 
            // aktivanDataGridViewCheckBoxColumn3
            // 
            this.aktivanDataGridViewCheckBoxColumn3.DataPropertyName = "aktivan";
            this.aktivanDataGridViewCheckBoxColumn3.HeaderText = "aktivan";
            this.aktivanDataGridViewCheckBoxColumn3.MinimumWidth = 6;
            this.aktivanDataGridViewCheckBoxColumn3.Name = "aktivanDataGridViewCheckBoxColumn3";
            this.aktivanDataGridViewCheckBoxColumn3.ReadOnly = true;
            this.aktivanDataGridViewCheckBoxColumn3.Width = 59;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(103, 94);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(361, 27);
            this.label35.TabIndex = 0;
            this.label35.Text = "Izaberite radnika iz spiska otuštenih:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.podmeniOdjava);
            this.panel2.Controls.Add(this.MeniOdjava);
            this.panel2.Controls.Add(this.podmeniIzvestaji);
            this.panel2.Controls.Add(this.MeniIzvestaji);
            this.panel2.Controls.Add(this.podmeniZaposljavanje);
            this.panel2.Controls.Add(this.MeniZaposljavanje);
            this.panel2.Controls.Add(this.MeniKategorija);
            this.panel2.Controls.Add(this.MeniDobavljaci);
            this.panel2.Controls.Add(this.MeniNabavke);
            this.panel2.Controls.Add(this.MeniProizvodi);
            this.panel2.Controls.Add(this.LogoPnl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 593);
            this.panel2.TabIndex = 26;
            // 
            // podmeniOdjava
            // 
            this.podmeniOdjava.BackColor = System.Drawing.Color.White;
            this.podmeniOdjava.Controls.Add(this.podmeniOdjaviMe);
            this.podmeniOdjava.Dock = System.Windows.Forms.DockStyle.Top;
            this.podmeniOdjava.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podmeniOdjava.Location = new System.Drawing.Point(0, 653);
            this.podmeniOdjava.Name = "podmeniOdjava";
            this.podmeniOdjava.Size = new System.Drawing.Size(203, 41);
            this.podmeniOdjava.TabIndex = 14;
            // 
            // podmeniOdjaviMe
            // 
            this.podmeniOdjaviMe.BackColor = System.Drawing.Color.LightBlue;
            this.podmeniOdjaviMe.Dock = System.Windows.Forms.DockStyle.Top;
            this.podmeniOdjaviMe.FlatAppearance.BorderSize = 0;
            this.podmeniOdjaviMe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.podmeniOdjaviMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.podmeniOdjaviMe.ForeColor = System.Drawing.Color.Black;
            this.podmeniOdjaviMe.Location = new System.Drawing.Point(0, 0);
            this.podmeniOdjaviMe.Name = "podmeniOdjaviMe";
            this.podmeniOdjaviMe.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.podmeniOdjaviMe.Size = new System.Drawing.Size(203, 41);
            this.podmeniOdjaviMe.TabIndex = 0;
            this.podmeniOdjaviMe.Text = "Odjavi me";
            this.podmeniOdjaviMe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.podmeniOdjaviMe.UseVisualStyleBackColor = false;
            this.podmeniOdjaviMe.Click += new System.EventHandler(this.podmeniOdjaviMe_Click);
            // 
            // MeniOdjava
            // 
            this.MeniOdjava.Dock = System.Windows.Forms.DockStyle.Top;
            this.MeniOdjava.FlatAppearance.BorderSize = 0;
            this.MeniOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MeniOdjava.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeniOdjava.ForeColor = System.Drawing.Color.White;
            this.MeniOdjava.Location = new System.Drawing.Point(0, 608);
            this.MeniOdjava.Name = "MeniOdjava";
            this.MeniOdjava.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MeniOdjava.Size = new System.Drawing.Size(203, 45);
            this.MeniOdjava.TabIndex = 13;
            this.MeniOdjava.Text = "❌ Odjava";
            this.MeniOdjava.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MeniOdjava.UseVisualStyleBackColor = true;
            this.MeniOdjava.Click += new System.EventHandler(this.MeniOdjava_Click);
            // 
            // podmeniIzvestaji
            // 
            this.podmeniIzvestaji.BackColor = System.Drawing.Color.White;
            this.podmeniIzvestaji.Controls.Add(this.podmeniIzvZap);
            this.podmeniIzvestaji.Controls.Add(this.podmeniIzvNab);
            this.podmeniIzvestaji.Controls.Add(this.podmeniIzvPro);
            this.podmeniIzvestaji.Dock = System.Windows.Forms.DockStyle.Top;
            this.podmeniIzvestaji.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podmeniIzvestaji.Location = new System.Drawing.Point(0, 491);
            this.podmeniIzvestaji.Name = "podmeniIzvestaji";
            this.podmeniIzvestaji.Size = new System.Drawing.Size(203, 117);
            this.podmeniIzvestaji.TabIndex = 12;
            // 
            // podmeniIzvZap
            // 
            this.podmeniIzvZap.BackColor = System.Drawing.Color.LightBlue;
            this.podmeniIzvZap.Dock = System.Windows.Forms.DockStyle.Top;
            this.podmeniIzvZap.FlatAppearance.BorderSize = 0;
            this.podmeniIzvZap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.podmeniIzvZap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.podmeniIzvZap.ForeColor = System.Drawing.Color.Black;
            this.podmeniIzvZap.Location = new System.Drawing.Point(0, 80);
            this.podmeniIzvZap.Name = "podmeniIzvZap";
            this.podmeniIzvZap.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.podmeniIzvZap.Size = new System.Drawing.Size(203, 40);
            this.podmeniIzvZap.TabIndex = 2;
            this.podmeniIzvZap.Text = "Zaposleni";
            this.podmeniIzvZap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.podmeniIzvZap.UseVisualStyleBackColor = false;
            this.podmeniIzvZap.Click += new System.EventHandler(this.podmeniIzvZap_Click);
            // 
            // podmeniIzvNab
            // 
            this.podmeniIzvNab.BackColor = System.Drawing.Color.LightBlue;
            this.podmeniIzvNab.Dock = System.Windows.Forms.DockStyle.Top;
            this.podmeniIzvNab.FlatAppearance.BorderSize = 0;
            this.podmeniIzvNab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.podmeniIzvNab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.podmeniIzvNab.ForeColor = System.Drawing.Color.Black;
            this.podmeniIzvNab.Location = new System.Drawing.Point(0, 40);
            this.podmeniIzvNab.Name = "podmeniIzvNab";
            this.podmeniIzvNab.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.podmeniIzvNab.Size = new System.Drawing.Size(203, 40);
            this.podmeniIzvNab.TabIndex = 1;
            this.podmeniIzvNab.Text = "Nabavke";
            this.podmeniIzvNab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.podmeniIzvNab.UseVisualStyleBackColor = false;
            this.podmeniIzvNab.Click += new System.EventHandler(this.podmeniIzvNab_Click);
            // 
            // podmeniIzvPro
            // 
            this.podmeniIzvPro.BackColor = System.Drawing.Color.LightBlue;
            this.podmeniIzvPro.Dock = System.Windows.Forms.DockStyle.Top;
            this.podmeniIzvPro.FlatAppearance.BorderSize = 0;
            this.podmeniIzvPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.podmeniIzvPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.podmeniIzvPro.ForeColor = System.Drawing.Color.Black;
            this.podmeniIzvPro.Location = new System.Drawing.Point(0, 0);
            this.podmeniIzvPro.Name = "podmeniIzvPro";
            this.podmeniIzvPro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.podmeniIzvPro.Size = new System.Drawing.Size(203, 40);
            this.podmeniIzvPro.TabIndex = 0;
            this.podmeniIzvPro.Text = "Proizvodi";
            this.podmeniIzvPro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.podmeniIzvPro.UseVisualStyleBackColor = false;
            this.podmeniIzvPro.Click += new System.EventHandler(this.podmeniIzvPro_Click);
            // 
            // MeniIzvestaji
            // 
            this.MeniIzvestaji.Dock = System.Windows.Forms.DockStyle.Top;
            this.MeniIzvestaji.FlatAppearance.BorderSize = 0;
            this.MeniIzvestaji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MeniIzvestaji.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeniIzvestaji.ForeColor = System.Drawing.Color.White;
            this.MeniIzvestaji.Location = new System.Drawing.Point(0, 446);
            this.MeniIzvestaji.Name = "MeniIzvestaji";
            this.MeniIzvestaji.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MeniIzvestaji.Size = new System.Drawing.Size(203, 45);
            this.MeniIzvestaji.TabIndex = 11;
            this.MeniIzvestaji.Text = "📰 Izveštaji";
            this.MeniIzvestaji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MeniIzvestaji.UseVisualStyleBackColor = true;
            this.MeniIzvestaji.Click += new System.EventHandler(this.MeniIzvestaji_Click);
            // 
            // podmeniZaposljavanje
            // 
            this.podmeniZaposljavanje.BackColor = System.Drawing.Color.LightBlue;
            this.podmeniZaposljavanje.Controls.Add(this.podmeniVratiOtp);
            this.podmeniZaposljavanje.Controls.Add(this.podmeniOtpustiRad);
            this.podmeniZaposljavanje.Controls.Add(this.podmeniDodajRad);
            this.podmeniZaposljavanje.Dock = System.Windows.Forms.DockStyle.Top;
            this.podmeniZaposljavanje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podmeniZaposljavanje.Location = new System.Drawing.Point(0, 326);
            this.podmeniZaposljavanje.Name = "podmeniZaposljavanje";
            this.podmeniZaposljavanje.Size = new System.Drawing.Size(203, 120);
            this.podmeniZaposljavanje.TabIndex = 10;
            // 
            // podmeniVratiOtp
            // 
            this.podmeniVratiOtp.BackColor = System.Drawing.Color.LightBlue;
            this.podmeniVratiOtp.Dock = System.Windows.Forms.DockStyle.Top;
            this.podmeniVratiOtp.FlatAppearance.BorderSize = 0;
            this.podmeniVratiOtp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.podmeniVratiOtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.podmeniVratiOtp.ForeColor = System.Drawing.Color.Black;
            this.podmeniVratiOtp.Location = new System.Drawing.Point(0, 80);
            this.podmeniVratiOtp.Name = "podmeniVratiOtp";
            this.podmeniVratiOtp.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.podmeniVratiOtp.Size = new System.Drawing.Size(203, 40);
            this.podmeniVratiOtp.TabIndex = 2;
            this.podmeniVratiOtp.Text = "Vrati otpuštenog";
            this.podmeniVratiOtp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.podmeniVratiOtp.UseVisualStyleBackColor = false;
            this.podmeniVratiOtp.Click += new System.EventHandler(this.podmeniVratiOtp_Click);
            // 
            // podmeniOtpustiRad
            // 
            this.podmeniOtpustiRad.BackColor = System.Drawing.Color.LightBlue;
            this.podmeniOtpustiRad.Dock = System.Windows.Forms.DockStyle.Top;
            this.podmeniOtpustiRad.FlatAppearance.BorderSize = 0;
            this.podmeniOtpustiRad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.podmeniOtpustiRad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.podmeniOtpustiRad.ForeColor = System.Drawing.Color.Black;
            this.podmeniOtpustiRad.Location = new System.Drawing.Point(0, 40);
            this.podmeniOtpustiRad.Name = "podmeniOtpustiRad";
            this.podmeniOtpustiRad.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.podmeniOtpustiRad.Size = new System.Drawing.Size(203, 40);
            this.podmeniOtpustiRad.TabIndex = 1;
            this.podmeniOtpustiRad.Text = "Otpusti radnika";
            this.podmeniOtpustiRad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.podmeniOtpustiRad.UseVisualStyleBackColor = false;
            this.podmeniOtpustiRad.Click += new System.EventHandler(this.podmeniOtpustiRad_Click);
            // 
            // podmeniDodajRad
            // 
            this.podmeniDodajRad.BackColor = System.Drawing.Color.LightBlue;
            this.podmeniDodajRad.Dock = System.Windows.Forms.DockStyle.Top;
            this.podmeniDodajRad.FlatAppearance.BorderSize = 0;
            this.podmeniDodajRad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.podmeniDodajRad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.podmeniDodajRad.ForeColor = System.Drawing.Color.Black;
            this.podmeniDodajRad.Location = new System.Drawing.Point(0, 0);
            this.podmeniDodajRad.Name = "podmeniDodajRad";
            this.podmeniDodajRad.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.podmeniDodajRad.Size = new System.Drawing.Size(203, 40);
            this.podmeniDodajRad.TabIndex = 0;
            this.podmeniDodajRad.Text = "Dodaj radnika";
            this.podmeniDodajRad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.podmeniDodajRad.UseVisualStyleBackColor = false;
            this.podmeniDodajRad.Click += new System.EventHandler(this.podmeniDodajRad_Click);
            // 
            // MeniZaposljavanje
            // 
            this.MeniZaposljavanje.Dock = System.Windows.Forms.DockStyle.Top;
            this.MeniZaposljavanje.FlatAppearance.BorderSize = 0;
            this.MeniZaposljavanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MeniZaposljavanje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeniZaposljavanje.ForeColor = System.Drawing.Color.White;
            this.MeniZaposljavanje.Location = new System.Drawing.Point(0, 281);
            this.MeniZaposljavanje.Name = "MeniZaposljavanje";
            this.MeniZaposljavanje.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MeniZaposljavanje.Size = new System.Drawing.Size(203, 45);
            this.MeniZaposljavanje.TabIndex = 9;
            this.MeniZaposljavanje.Text = "👥 Zapošljavanje";
            this.MeniZaposljavanje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MeniZaposljavanje.UseVisualStyleBackColor = true;
            this.MeniZaposljavanje.Click += new System.EventHandler(this.MeniZaposljavanje_Click);
            // 
            // MeniKategorija
            // 
            this.MeniKategorija.Dock = System.Windows.Forms.DockStyle.Top;
            this.MeniKategorija.FlatAppearance.BorderSize = 0;
            this.MeniKategorija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MeniKategorija.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeniKategorija.ForeColor = System.Drawing.Color.White;
            this.MeniKategorija.Location = new System.Drawing.Point(0, 236);
            this.MeniKategorija.Name = "MeniKategorija";
            this.MeniKategorija.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MeniKategorija.Size = new System.Drawing.Size(203, 45);
            this.MeniKategorija.TabIndex = 5;
            this.MeniKategorija.Text = "🅱 Kategorija/Brend";
            this.MeniKategorija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MeniKategorija.UseVisualStyleBackColor = true;
            this.MeniKategorija.Click += new System.EventHandler(this.MeniKategorija_Click);
            // 
            // MeniDobavljaci
            // 
            this.MeniDobavljaci.Dock = System.Windows.Forms.DockStyle.Top;
            this.MeniDobavljaci.FlatAppearance.BorderSize = 0;
            this.MeniDobavljaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MeniDobavljaci.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeniDobavljaci.ForeColor = System.Drawing.Color.White;
            this.MeniDobavljaci.Location = new System.Drawing.Point(0, 191);
            this.MeniDobavljaci.Name = "MeniDobavljaci";
            this.MeniDobavljaci.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MeniDobavljaci.Size = new System.Drawing.Size(203, 45);
            this.MeniDobavljaci.TabIndex = 4;
            this.MeniDobavljaci.Text = "👤 Dobavljači";
            this.MeniDobavljaci.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MeniDobavljaci.UseVisualStyleBackColor = true;
            this.MeniDobavljaci.Click += new System.EventHandler(this.MeniDobavljaci_Click);
            // 
            // MeniNabavke
            // 
            this.MeniNabavke.Dock = System.Windows.Forms.DockStyle.Top;
            this.MeniNabavke.FlatAppearance.BorderSize = 0;
            this.MeniNabavke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MeniNabavke.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeniNabavke.ForeColor = System.Drawing.Color.White;
            this.MeniNabavke.Location = new System.Drawing.Point(0, 146);
            this.MeniNabavke.Name = "MeniNabavke";
            this.MeniNabavke.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MeniNabavke.Size = new System.Drawing.Size(203, 45);
            this.MeniNabavke.TabIndex = 3;
            this.MeniNabavke.Text = "📦 Nabavke";
            this.MeniNabavke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MeniNabavke.UseVisualStyleBackColor = true;
            this.MeniNabavke.Click += new System.EventHandler(this.MeniNabavke_Click);
            // 
            // MeniProizvodi
            // 
            this.MeniProizvodi.Dock = System.Windows.Forms.DockStyle.Top;
            this.MeniProizvodi.FlatAppearance.BorderSize = 0;
            this.MeniProizvodi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MeniProizvodi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeniProizvodi.ForeColor = System.Drawing.Color.White;
            this.MeniProizvodi.Location = new System.Drawing.Point(0, 101);
            this.MeniProizvodi.Name = "MeniProizvodi";
            this.MeniProizvodi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MeniProizvodi.Size = new System.Drawing.Size(203, 45);
            this.MeniProizvodi.TabIndex = 2;
            this.MeniProizvodi.Tag = "";
            this.MeniProizvodi.Text = "🎁 Proizvodi";
            this.MeniProizvodi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MeniProizvodi.UseVisualStyleBackColor = true;
            this.MeniProizvodi.Click += new System.EventHandler(this.MeniProizvodi_Click);
            // 
            // LogoPnl
            // 
            this.LogoPnl.Controls.Add(this.pictureBox5);
            this.LogoPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPnl.Location = new System.Drawing.Point(0, 0);
            this.LogoPnl.Name = "LogoPnl";
            this.LogoPnl.Size = new System.Drawing.Size(203, 101);
            this.LogoPnl.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(30, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(132, 77);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // Rukovodilac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1242, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlUnosProizvoda);
            this.Controls.Add(this.pnlOtpustiRadnika);
            this.Controls.Add(this.pnlDobavljac);
            this.Controls.Add(this.pnlZaposljavanje);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNabavke);
            this.Controls.Add(this.pnlNabavkeIzv);
            this.Controls.Add(this.pnlZaposleniIzv);
            this.Controls.Add(this.pnlProizvodIzv);
            this.Controls.Add(this.pnlKategorija);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1296, 640);
            this.MinimumSize = new System.Drawing.Size(1187, 640);
            this.Name = "Rukovodilac";
            this.Text = "Rukovodilac";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rukovodilac_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlUnosProizvoda.ResumeLayout(false);
            this.pnlUnosProizvoda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRENDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATEGORIJABindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorija)).EndInit();
            this.pnlZaposljavanje.ResumeLayout(false);
            this.pnlZaposljavanje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewZaposleniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodavnicaIgracakaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posao)).EndInit();
            this.pnlNabavke.ResumeLayout(false);
            this.pnlNabavke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAGACINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magacin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOBAVLJACBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).EndInit();
            this.pnlDobavljac.ResumeLayout(false);
            this.pnlDobavljac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazDobavljaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.pnlKategorija.ResumeLayout(false);
            this.pnlKategorija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).EndInit();
            this.pnlOtpustiRadnika.ResumeLayout(false);
            this.pnlOtpustiRadnika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).EndInit();
            this.pnlProizvodIzv.ResumeLayout(false);
            this.pnlProizvodIzv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazProizvoda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodavnicaIgracakaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poredjajOdNajprodavanijegBindingSource)).EndInit();
            this.pnlNabavkeIzv.ResumeLayout(false);
            this.pnlNabavkeIzv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNabavkeIzv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNabavkeBindingSource)).EndInit();
            this.pnlZaposleniIzv.ResumeLayout(false);
            this.pnlZaposleniIzv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPronadjiZap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtpusten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOtpusteniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodavnicaIgracakaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtpusteniR)).EndInit();
            this.panel2.ResumeLayout(false);
            this.podmeniOdjava.ResumeLayout(false);
            this.podmeniIzvestaji.ResumeLayout(false);
            this.podmeniZaposljavanje.ResumeLayout(false);
            this.LogoPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlUnosProizvoda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBrend;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Button btnUnesiPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivPro;
        private System.Windows.Forms.Label lblBrend;
        public System.Windows.Forms.TextBox txtCenaPro;
        private System.Windows.Forms.Panel pnlZaposljavanje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbPosao;
        private System.Windows.Forms.TextBox txtTelefonZ;
        private System.Windows.Forms.TextBox txtEmailZ;
        private System.Windows.Forms.TextBox txtAdresaZ;
        private System.Windows.Forms.TextBox txtPlata;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlNabavke;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbDobavljac;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlDobavljac;
        private System.Windows.Forms.Button btnDobavljac;
        private System.Windows.Forms.TextBox txtTelefonDob;
        private System.Windows.Forms.TextBox txtAdresaDob;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNazivDob;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private ProdavnicaIgracakaDataSet prodavnicaIgracakaDataSet;
        private ProdavnicaIgracakaDataSet prodavnicaIgracakaDataSet1;
        private System.Windows.Forms.DataGridView dgvProizvod;
        private ProdavnicaIgracakaDataSet prodavnicaIgracakaDataSet2;
        private System.Windows.Forms.ComboBox cbMagacin;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvPrikazDobavljaca;
        private System.Windows.Forms.DateTimePicker dtpZaposlenje;
        private System.Windows.Forms.Panel pnlKategorija;
        private System.Windows.Forms.DataGridView dgvKategorije;
        private System.Windows.Forms.Button btnKategorije;
        private System.Windows.Forms.TextBox txtNazivKat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnlOtpustiRadnika;
        private System.Windows.Forms.Button btnOtpustiZap;
        private System.Windows.Forms.TextBox txtIdZap;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView dgvZaposleni;
        private System.Windows.Forms.Button btnPronadjiZap;
        private System.Windows.Forms.TextBox txtImeZap;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dgvBrend;
        private System.Windows.Forms.Button btnBrend;
        private System.Windows.Forms.TextBox txtBrend;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel pnlProizvodIzv;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cbB;
        private System.Windows.Forms.ComboBox cbKat;
        private System.Windows.Forms.DataGridView dgvPrikazProizvoda;
        private System.Windows.Forms.Button btnPrikazPro;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProdavnicaIgracakaDataSet3 prodavnicaIgracakaDataSet3;
        private System.Windows.Forms.BindingSource poredjajOdNajprodavanijegBindingSource;
        private ProdavnicaIgracakaDataSet3TableAdapters.poredjajOdNajprodavanijegTableAdapter poredjajOdNajprodavanijegTableAdapter;
        private System.Windows.Forms.Panel pnlNabavkeIzv;
        private System.Windows.Forms.BindingSource viewNabavkeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nkolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvNabavkeIzv;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel pnlZaposleniIzv;
        private System.Windows.Forms.TextBox txtZapId;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView dgvPronadjiZap;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtZap;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridView dgvOtpusten;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DataGridView dgvZap;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.DataGridView dgvIzdati;
        private ProdavnicaIgracakaDataSet4 prodavnicaIgracakaDataSet4;
        private System.Windows.Forms.BindingSource viewZaposleniBindingSource;
        private ProdavnicaIgracakaDataSet4TableAdapters.view_ZaposleniTableAdapter view_ZaposleniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datZapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPoslaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivanDataGridViewCheckBoxColumn;
        private ProdavnicaIgracakaDataSet5 prodavnicaIgracakaDataSet5;
        private System.Windows.Forms.BindingSource viewOtpusteniBindingSource;
        private ProdavnicaIgracakaDataSet5TableAdapters.view_OtpusteniTableAdapter view_OtpusteniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn korImeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datZapDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaZDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailZDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonZDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPoslaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivanDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnPrikazRacuna;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private Kategorija kategorija;
        private KategorijaTableAdapters.KATEGORIJATableAdapter kATEGORIJATableAdapter;
        private Brend brend;
        private System.Windows.Forms.BindingSource bRENDBindingSource;
        private BrendTableAdapters.BRENDTableAdapter bRENDTableAdapter;
        private System.Windows.Forms.BindingSource kATEGORIJABindingSource2;
        private Posao posao;
        private System.Windows.Forms.BindingSource pOSAOBindingSource;
        private PosaoTableAdapters.POSAOTableAdapter pOSAOTableAdapter;
        private Dobavljac dobavljac;
        private System.Windows.Forms.BindingSource dOBAVLJACBindingSource;
        private DobavljacTableAdapters.DOBAVLJACTableAdapter dOBAVLJACTableAdapter;
        private Magacin magacin;
        private System.Windows.Forms.BindingSource mAGACINBindingSource;
        private MagacinTableAdapters.MAGACINTableAdapter mAGACINTableAdapter;
        private System.Windows.Forms.DataGridView dgvRadnici;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn korImeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datZapDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaZDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailZDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonZDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPoslaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivanDataGridViewCheckBoxColumn2;
        private System.Windows.Forms.Button btnIzmeniZap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtIdRadnika;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DataGridView dgvOtpusteniR;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn korImeDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn datZapDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaZDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailZDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonZDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPoslaDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivanDataGridViewCheckBoxColumn3;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnIzmeniPro;
        private System.Windows.Forms.Button btnIzmaniDob;
        private System.Windows.Forms.TextBox txtPib;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel LogoPnl;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button MeniKategorija;
        private System.Windows.Forms.Button MeniDobavljaci;
        private System.Windows.Forms.Button MeniNabavke;
        private System.Windows.Forms.Button MeniProizvodi;
        private System.Windows.Forms.Button MeniZaposljavanje;
        private System.Windows.Forms.Panel podmeniIzvestaji;
        private System.Windows.Forms.Button podmeniIzvZap;
        private System.Windows.Forms.Button podmeniIzvNab;
        private System.Windows.Forms.Button podmeniIzvPro;
        private System.Windows.Forms.Button MeniIzvestaji;
        private System.Windows.Forms.Panel podmeniZaposljavanje;
        private System.Windows.Forms.Button podmeniVratiOtp;
        private System.Windows.Forms.Button podmeniOtpustiRad;
        private System.Windows.Forms.Button podmeniDodajRad;
        private System.Windows.Forms.Panel podmeniOdjava;
        private System.Windows.Forms.Button podmeniOdjaviMe;
        private System.Windows.Forms.Button MeniOdjava;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}