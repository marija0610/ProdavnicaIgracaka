namespace ProdavnicaIgracaka
{
    partial class Racun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Racun));
            this.txtUkupanIznos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStorniraj = new System.Windows.Forms.Button();
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProizvod = new System.Windows.Forms.TextBox();
            this.txtStorniranje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.kATEGORIJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorija = new ProdavnicaIgracaka.Kategorija();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStampaj = new System.Windows.Forms.Button();
            this.kATEGORIJATableAdapter = new ProdavnicaIgracaka.KategorijaTableAdapters.KATEGORIJATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATEGORIJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorija)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUkupanIznos
            // 
            this.txtUkupanIznos.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUkupanIznos.ForeColor = System.Drawing.Color.Blue;
            this.txtUkupanIznos.Location = new System.Drawing.Point(170, 549);
            this.txtUkupanIznos.Name = "txtUkupanIznos";
            this.txtUkupanIznos.ReadOnly = true;
            this.txtUkupanIznos.Size = new System.Drawing.Size(414, 34);
            this.txtUkupanIznos.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 552);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ukupan iznos:";
            // 
            // btnStorniraj
            // 
            this.btnStorniraj.BackColor = System.Drawing.Color.LightBlue;
            this.btnStorniraj.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStorniraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStorniraj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorniraj.Location = new System.Drawing.Point(611, 347);
            this.btnStorniraj.Name = "btnStorniraj";
            this.btnStorniraj.Size = new System.Drawing.Size(267, 49);
            this.btnStorniraj.TabIndex = 32;
            this.btnStorniraj.Text = "Storniraj stavku";
            this.btnStorniraj.UseVisualStyleBackColor = false;
            this.btnStorniraj.Click += new System.EventHandler(this.btnSacuvajRacun_Click);
            // 
            // dgvStavkeRacuna
            // 
            this.dgvStavkeRacuna.AllowUserToAddRows = false;
            this.dgvStavkeRacuna.AllowUserToDeleteRows = false;
            this.dgvStavkeRacuna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(12, 264);
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            this.dgvStavkeRacuna.ReadOnly = true;
            this.dgvStavkeRacuna.RowHeadersWidth = 51;
            this.dgvStavkeRacuna.RowTemplate.Height = 24;
            this.dgvStavkeRacuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(572, 262);
            this.dgvStavkeRacuna.TabIndex = 31;
            this.dgvStavkeRacuna.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvStavkeRacuna_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 35);
            this.label3.TabIndex = 30;
            this.label3.Text = "Stavke računa:";
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.BackColor = System.Drawing.Color.LightBlue;
            this.btnDodajProizvod.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodajProizvod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajProizvod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProizvod.Location = new System.Drawing.Point(729, 167);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(145, 39);
            this.btnDodajProizvod.TabIndex = 29;
            this.btnDodajProizvod.Text = "Dodaj";
            this.btnDodajProizvod.UseVisualStyleBackColor = false;
            this.btnDodajProizvod.Click += new System.EventHandler(this.btnDodajProizvod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(729, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Količina:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(731, 121);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(145, 30);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(238, 12);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.RowHeadersWidth = 51;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.Size = new System.Drawing.Size(459, 194);
            this.dgvProizvodi.TabIndex = 24;
            this.dgvProizvodi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProizvodi_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(726, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "Izabran proizvod:";
            // 
            // txtProizvod
            // 
            this.txtProizvod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProizvod.Location = new System.Drawing.Point(730, 64);
            this.txtProizvod.Name = "txtProizvod";
            this.txtProizvod.ReadOnly = true;
            this.txtProizvod.Size = new System.Drawing.Size(144, 30);
            this.txtProizvod.TabIndex = 36;
            // 
            // txtStorniranje
            // 
            this.txtStorniranje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStorniranje.Location = new System.Drawing.Point(609, 311);
            this.txtStorniranje.Name = "txtStorniranje";
            this.txtStorniranje.ReadOnly = true;
            this.txtStorniranje.Size = new System.Drawing.Size(267, 30);
            this.txtStorniranje.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(606, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 52);
            this.label2.TabIndex = 37;
            this.label2.Text = "Izabran proizvod\r\nza storniranje:";
            // 
            // cbKategorija
            // 
            this.cbKategorija.DataSource = this.kATEGORIJABindingSource;
            this.cbKategorija.DisplayMember = "nazivKat";
            this.cbKategorija.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(12, 89);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(200, 30);
            this.cbKategorija.TabIndex = 39;
            this.cbKategorija.ValueMember = "nazivKat";
            this.cbKategorija.SelectedIndexChanged += new System.EventHandler(this.cbKategorija_SelectedIndexChanged);
            // 
            // kATEGORIJABindingSource
            // 
            this.kATEGORIJABindingSource.DataMember = "KATEGORIJA";
            this.kATEGORIJABindingSource.DataSource = this.kategorija;
            // 
            // kategorija
            // 
            this.kategorija.DataSetName = "Kategorija";
            this.kategorija.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 27);
            this.label6.TabIndex = 40;
            this.label6.Text = "Izaberite kategoriju:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(611, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 64);
            this.button1.TabIndex = 41;
            this.button1.Text = "SAČUVAJ RAČUN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStampaj
            // 
            this.btnStampaj.BackColor = System.Drawing.Color.LightBlue;
            this.btnStampaj.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStampaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStampaj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStampaj.Location = new System.Drawing.Point(611, 450);
            this.btnStampaj.Name = "btnStampaj";
            this.btnStampaj.Size = new System.Drawing.Size(271, 50);
            this.btnStampaj.TabIndex = 42;
            this.btnStampaj.Text = "Štampaj račun";
            this.btnStampaj.UseVisualStyleBackColor = false;
            this.btnStampaj.Click += new System.EventHandler(this.btnStampaj_Click);
            // 
            // kATEGORIJATableAdapter
            // 
            this.kATEGORIJATableAdapter.ClearBeforeFill = true;
            // 
            // Racun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(894, 619);
            this.Controls.Add(this.btnStampaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.txtStorniranje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProizvod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUkupanIznos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStorniraj);
            this.Controls.Add(this.dgvStavkeRacuna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodajProizvod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dgvProizvodi);
            this.MinimizeBox = false;
            this.Name = "Racun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Racun";
            this.Load += new System.EventHandler(this.Racun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATEGORIJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUkupanIznos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStorniraj;
        private System.Windows.Forms.DataGridView dgvStavkeRacuna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodajProizvod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProizvod;
        private System.Windows.Forms.TextBox txtStorniranje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStampaj;
        private Kategorija kategorija;
        private System.Windows.Forms.BindingSource kATEGORIJABindingSource;
        private KategorijaTableAdapters.KATEGORIJATableAdapter kATEGORIJATableAdapter;
    }
}