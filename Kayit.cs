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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        public Kayit(string snfad,string kont)
        {
            MessageBox.Show("Güncellemek icin bilgileri doldurunuz.");
            InitializeComponent();
            this.txtSinifAd.Text = snfad;
            this.txtKontenjan.Text = kont;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(@"Data Source=.;Initial Catalog=OkulDB;Integrated Security=true"))
                {
                    using (SqlCommand cmd = new SqlCommand("Insert into tblSinif values (@SinifAd,@Kontenjan)", con))
                    {
                        SqlParameter[] p = { new SqlParameter("@SinifAd", txtSinifAd.Text.Trim()), new SqlParameter("@Kontenjan", txtKontenjan.Text.Trim()) };
                        cmd.Parameters.AddRange(p);
                        con.Open();
                        int sonuc = cmd.ExecuteNonQuery();
                        if (sonuc > 0)
                        {
                            MessageBox.Show("Kayıt Başarılı!");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    if (ex.Message.Contains("SinifAd"))
                    {
                        MessageBox.Show("Güncelleniyor");

                        using (con = new SqlConnection(@"Data Source=.;Initial Catalog=OkulDB;Integrated Security=true"))
                        {
                            using (SqlCommand cmd2 = new SqlCommand("Update tblSinif Set Kontenjan=@Kontenjan2 Where SinifAd=@SinifAd2", con))
                            {
                                SqlParameter[] p2 = { new SqlParameter("@Kontenjan2", txtKontenjan.Text.Trim()), new SqlParameter("@SinifAd2", txtSinifAd.Text.Trim()) };
                                cmd2.Parameters.AddRange(p2);
                                con.Open();
                                int sonuc2 = cmd2.ExecuteNonQuery();
                                if (sonuc2>0)
                                {
                                    MessageBox.Show("Güncelleme Yapıldı :)");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veritabanı hatası.");
                }
                
            }
            finally
            {
                if (con != null && con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        private void btnSinifBul_Click(object sender, EventArgs e)
        {
      
                SinifBul frm = new SinifBul();
                frm.Show();
                this.Hide();
        }
    }
}
