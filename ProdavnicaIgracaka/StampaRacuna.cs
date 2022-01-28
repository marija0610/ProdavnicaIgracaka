using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdavnicaIgracaka
{
    public partial class StampaRacuna : Form
    {
        public StampaRacuna()
        {
            InitializeComponent();
        }

        private void StampaRacuna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RStampa.racun_report' table. You can move, or remove it, as needed.
            this.racun_reportTableAdapter.Fill(this.RStampa.racun_report);
            // TODO: This line of code loads data into the 'SRStampa.stavkeRacuna_report' table. You can move, or remove it, as needed.
            this.stavkeRacuna_reportTableAdapter.Fill(this.SRStampa.stavkeRacuna_report);

            this.reportViewer1.RefreshReport();
        }

    }
}
