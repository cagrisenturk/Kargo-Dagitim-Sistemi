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
    public partial class SifreDegistirme : Form
    {
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void degistirButton_Click(object sender, EventArgs e)
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
                        MySqlDataReader oku;
                        MySqlCommand komut = new MySqlCommand("SELECT kullanici_id FROM kullanici WHERE kullanici_adi ='" + kullaniciAdiTextBox.Text + "' AND kullanici_sifre ='" + sifreTextBox.Text + "'", baglan);
                        oku = komut.ExecuteReader();
                        if (oku.Read())
                        {
                            MessageBox.Show("Profil bulundu.");
                            string id = oku[0].ToString();
                            oku.Close();
                            MySqlCommand komutGuncelle = new MySqlCommand("Update kullanici Set kullanici_sifre=@p1 WHERE kullanici_id ='" + id + "' ", baglan);
                            komutGuncelle.Parameters.AddWithValue("@p1", yeniSifreTextBox.Text);
                            komutGuncelle.ExecuteNonQuery();
                            MessageBox.Show("Sifre basari ile değişti.");
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
    }
}
