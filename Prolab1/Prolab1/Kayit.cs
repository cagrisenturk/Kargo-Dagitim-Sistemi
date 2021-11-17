using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prolab1
{
    public partial class Kayit : Form
    {
        
        public Kayit()
        {
            InitializeComponent();
        }

        private void Kayit_Load(object sender, EventArgs e)
        {

        }

        private void kayitOlButton_Click(object sender, EventArgs e)
        {
            string mysqlBaglantisi = "SERVER=34.69.96.204;DATABASE=Kargo;UID=root;PWD=1234";
            using (var baglan = new MySqlConnection(mysqlBaglantisi))
            {
                try
                {
                    baglan.Open();
                    if (kontrol()) {
                        MySqlCommand komut = new MySqlCommand("insert into kullanici (kullanici_adi,kullanici_email,kullanici_sifre) values (@p1,@p2,@p3)", baglan);
                        komut.Parameters.AddWithValue("@p1", kullaniciAdiTextBox.Text);
                        komut.Parameters.AddWithValue("@p2", mailTextBox.Text);
                        komut.Parameters.AddWithValue("@p3", sifreTextBox.Text);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("KAYIT OLUNDU");
                    }
                }
                    
                catch (Exception hata)
                {
                    MessageBox.Show("baglantı olmadı nedeni \n " + hata.ToString());
                    throw;
                }
            }
        }
        public bool kontrol()
        {
            String kullaiciadi = kullaniciAdiTextBox.Text;
            String kullaniciEmail = mailTextBox.Text;
            String sifre1 = sifreTextBox.Text;
            String sifre2 = sifre2TextBox.Text;

            if (kullaiciadi.Equals("") ||
                     kullaniciEmail.Equals("") || sifre1.Equals("")
                    || sifre2.Equals(""))
            {
                MessageBox.Show("Bir Veya Birden fazla alan boş bırakıldı");
                return false;
            }
            else if (!sifre1.Equals(sifre2))
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
