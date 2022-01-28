namespace ProdavnicaIgracaka
{
    partial class DobavljenaRoba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DobavljenaRoba));
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnStavkeNabavke = new System.Windows.Forms.Button();
            this.dgvStavkeNabavke = new System.Windows.Forms.DataGridView();
            this.btnZavrsiNabavku = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtStavka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.prikazProizvoda1 = new ProdavnicaIgracaka.PrikazProizvoda();
            this.prikazProizvodaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prikazProizvodaTableAdapter = new ProdavnicaIgracaka.PrikazProizvodaTableAdapters.prikazProizvodaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNabavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikazProizvoda1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikazProizvodaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(16, 42);
            this.dgvProizvodi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.RowHeadersWidth = 51;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(670, 154);
            this.dgvProizvodi.TabIndex = 0;
            this.dgvProizvodi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProizvodi_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dobavljena količina:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(232, 239);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(241, 35);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStavkeNabavke
            // 
            this.btnStavkeNabavke.BackColor = System.Drawing.Color.LightBlue;
            this.btnStavkeNabavke.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStavkeNabavke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStavkeNabavke.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStavkeNabavke.Location = new System.Drawing.Point(486, 204);
            this.btnStavkeNabavke.Margin = new System.Windows.Forms.Padding(4);
            this.btnStavkeNabavke.Name = "btnStavkeNabavke";
            this.btnStavkeNabavke.Size = new System.Drawing.Size(200, 70);
            this.btnStavkeNabavke.TabIndex = 3;
            this.btnStavkeNabavke.Text = "Sačuvaj stavku";
            this.btnStavkeNabavke.UseVisualStyleBackColor = false;
            this.btnStavkeNabavke.Click += new System.EventHandler(this.btnStavkeNabavke_Click);
            // 
            // dgvStavkeNabavke
            // 
            this.dgvStavkeNabavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeNabavke.Location = new System.Drawing.Point(17, 282);
            this.dgvStavkeNabavke.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStavkeNabavke.Name = "dgvStavkeNabavke";
            this.dgvStavkeNabavke.RowHeadersWidth = 51;
            this.dgvStavkeNabavke.Size = new System.Drawing.Size(456, 181);
            this.dgvStavkeNabavke.TabIndex = 4;
            this.dgvStavkeNabavke.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvStavkeNabavke_MouseDoubleClick);
            // 
            // btnZavrsiNabavku
            // 
            this.btnZavrsiNabavku.BackColor = System.Drawing.Color.LightBlue;
            this.btnZavrsiNabavku.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnZavrsiNabavku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZavrsiNabavku.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZavrsiNabavku.Location = new System.Drawing.Point(17, 486);
            this.btnZavrsiNabavku.Margin = new System.Windows.Forms.Padding(4);
            this.btnZavrsiNabavku.Name = "btnZavrsiNabavku";
            this.btnZavrsiNabavku.Size = new System.Drawing.Size(669, 46);
            this.btnZavrsiNabavku.TabIndex = 5;
            this.btnZavrsiNabavku.Text = "Završi unos";
            this.btnZavrsiNabavku.UseVisualStyleBackColor = false;
            this.btnZavrsiNabavku.Click += new System.EventHandler(this.btnZavrsiNabavku_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Izaberite proizvod:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Izabran proizvod:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(232, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(241, 30);
            this.textBox1.TabIndex = 8;
            // 
            // txtStavka
            // 
            this.txtStavka.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStavka.Location = new System.Drawing.Point(486, 357);
            this.txtStavka.Name = "txtStavka";
            this.txtStavka.ReadOnly = true;
            this.txtStavka.Size = new System.Drawing.Size(200, 30);
            this.txtStavka.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 54);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stavka za uklanjanje\r\niz nabavke:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(486, 394);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 70);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ukloni stavku nabavke";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prikazProizvoda1
            // 
            this.prikazProizvoda1.DataSetName = "PrikazProizvoda";
            this.prikazProizvoda1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prikazProizvodaBindingSource
            // 
            this.prikazProizvodaBindingSource.DataMember = "prikazProizvoda";
            this.prikazProizvodaBindingSource.DataSource = this.prikazProizvoda1;
            // 
            // prikazProizvodaTableAdapter
            // 
            this.prikazProizvodaTableAdapter.ClearBeforeFill = true;
            // 
            // DobavljenaRoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(699, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtStavka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZavrsiNabavku);
            this.Controls.Add(this.dgvStavkeNabavke);
            this.Controls.Add(this.btnStavkeNabavke);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProizvodi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DobavljenaRoba";
            this.Text = "Dobavljena roba";
            this.Load += new System.EventHandler(this.DobavljenaRoba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNabavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikazProizvoda1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikazProizvodaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnStavkeNabavke;
        private System.Windows.Forms.DataGridView dgvStavkeNabavke;
        private System.Windows.Forms.Button btnZavrsiNabavku;
        private ProdavnicaIgracakaDataSet prodavnicaIgracakaDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtStavka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private PrikazProizvoda prikazProizvoda1;
        private System.Windows.Forms.BindingSource prikazProizvodaBindingSource;
        private PrikazProizvodaTableAdapters.prikazProizvodaTableAdapter prikazProizvodaTableAdapter;
    }
}