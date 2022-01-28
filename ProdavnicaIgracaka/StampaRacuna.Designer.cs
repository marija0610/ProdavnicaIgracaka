namespace ProdavnicaIgracaka
{
    partial class StampaRacuna
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StampaRacuna));
            this.racun_reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RStampa = new ProdavnicaIgracaka.RStampa();
            this.stavkeRacuna_reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SRStampa = new ProdavnicaIgracaka.SRStampa();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.racun_reportTableAdapter = new ProdavnicaIgracaka.RStampaTableAdapters.racun_reportTableAdapter();
            this.stavkeRacuna_reportTableAdapter = new ProdavnicaIgracaka.SRStampaTableAdapters.stavkeRacuna_reportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.racun_reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RStampa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeRacuna_reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SRStampa)).BeginInit();
            this.SuspendLayout();
            // 
            // racun_reportBindingSource
            // 
            this.racun_reportBindingSource.DataMember = "racun_report";
            this.racun_reportBindingSource.DataSource = this.RStampa;
            // 
            // RStampa
            // 
            this.RStampa.DataSetName = "RStampa";
            this.RStampa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stavkeRacuna_reportBindingSource
            // 
            this.stavkeRacuna_reportBindingSource.DataMember = "stavkeRacuna_report";
            this.stavkeRacuna_reportBindingSource.DataSource = this.SRStampa;
            // 
            // SRStampa
            // 
            this.SRStampa.DataSetName = "SRStampa";
            this.SRStampa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "RStampa";
            reportDataSource1.Value = this.racun_reportBindingSource;
            reportDataSource2.Name = "SRStampa";
            reportDataSource2.Value = this.stavkeRacuna_reportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProdavnicaIgracaka.IzvestajRacun.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(561, 409);
            this.reportViewer1.TabIndex = 0;
            // 
            // racun_reportTableAdapter
            // 
            this.racun_reportTableAdapter.ClearBeforeFill = true;
            // 
            // stavkeRacuna_reportTableAdapter
            // 
            this.stavkeRacuna_reportTableAdapter.ClearBeforeFill = true;
            // 
            // StampaRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(585, 433);
            this.Controls.Add(this.reportViewer1);
            this.Name = "StampaRacuna";
            this.Text = "StampaRacuna";
            this.Load += new System.EventHandler(this.StampaRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racun_reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RStampa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeRacuna_reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SRStampa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource racun_reportBindingSource;
        private RStampa RStampa;
        private System.Windows.Forms.BindingSource stavkeRacuna_reportBindingSource;
        private SRStampa SRStampa;
        private RStampaTableAdapters.racun_reportTableAdapter racun_reportTableAdapter;
        private SRStampaTableAdapters.stavkeRacuna_reportTableAdapter stavkeRacuna_reportTableAdapter;
    }
}