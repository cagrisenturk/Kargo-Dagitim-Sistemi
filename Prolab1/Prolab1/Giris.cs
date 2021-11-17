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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.Show();
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            string mysqlBaglantisi = "SERVER=34.69.96.204;DATABASE=Kargo;UID=root;PWD=1234";
            if (kullaniciAdiTextBox.Text.Equals(""))
            {
                MessageBox.Show("Lütfen Kullanıcı Adı Giriniz");
            }
            else if (sifreTextBox.Text.Equals(""))
            {
                MessageBox.Show("Lütfen Şifre Giriniz");
            }
            else
            {
                using (var baglan = new MySqlConnection(mysqlBaglantisi))
                {
                    try
                    {
                        baglan.Open();
                        MySqlDataReader oku;
                        MySqlCommand komut = new MySqlCommand("SELECT * FROM kullanici WHERE kullanici_adi ='"+kullaniciAdiTextBox.Text+"' AND kullanici_sifre ='"+ sifreTextBox.Text+"'", baglan);
                        oku = komut.ExecuteReader();
                        if (oku.Read())
                        {
                            MessageBox.Show("Giriş Başarılı.");
                            AnaSayfa anaSayfa = new AnaSayfa();
                            this.Hide();
                            anaSayfa.Show();
                            


                            
                            
                        }
                        else
                        {
                            MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
                        }

                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("baglantı olmadı nedeni \n " + hata.ToString());
                        throw;
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SifreDegistirme sifreDegistirme = new SifreDegistirme();
            sifreDegistirme.Show();
        }

       
    }
}
