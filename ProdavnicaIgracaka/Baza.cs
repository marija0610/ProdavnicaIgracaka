using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProdavnicaIgracaka
{
    class Baza
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-HVNRPOE\SQLEXPRESS;Initial Catalog=ProdavnicaIgracaka;Integrated Security=True");

        public SqlConnection Sqlcon { get => sqlcon; set => sqlcon = value; }

        public void otvoriKonekciju()
        {
            Sqlcon.Open();
        }
        public void zatvoriKonekciju()
        {
            Sqlcon.Close();
        }
    }
}
