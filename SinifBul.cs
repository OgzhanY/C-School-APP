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

namespace Gazi.KazanMYO.OkulAPP
{
    public partial class SinifBul : Form
    {
        public SinifBul()
        {
            InitializeComponent();
        }

        private void btnSinifAdBul_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = null;
            try
            {
                using (con2 = new SqlConnection(@"Data Source=.;Initial Catalog=OkulDB;Integrated Security=true"))
                {
                    using (SqlCommand cmd2 = new SqlCommand("Select SinifAd,Kontenjan from tblSinif where sinifad=@SinifAd2", con2))
                    {
                        SqlParameter[] p2 = { new SqlParameter("@SinifAd2", txtSinifAdBul.Text.Trim()) };
                        cmd2.Parameters.AddRange(p2);
                        con2.Open();
                        SqlDataReader okuyucu = cmd2.ExecuteReader();
                        if (okuyucu.Read())
                        {
                            Kayit frm2 = new Kayit(okuyucu["SinifAd"].ToString(), okuyucu["Kontenjan"].ToString());
                            frm2.Show();
                            this.Close();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası.");
            }
            finally
            {
                if (con2 != null && con2.State != ConnectionState.Closed)
                {
                    con2.Close();
                }
            }
        }
    }
}
