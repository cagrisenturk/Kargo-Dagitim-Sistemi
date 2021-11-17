using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Prolab1
{
    public partial class AnaSayfa : Form
    {
        private List<PointLatLng> _points;
        private List<Kargo> kargos;
        public AnaSayfa()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
            kargos = new List<Kargo>();
        }
        Harita harita;
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = "AIzaSyBBvXJdF7o1mRmozWjoTcXb0REfblkfkik";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;
            map.SetPositionByKeywords("İzmit, Turkey");
            string mysqlBaglantisi = "SERVER=34.69.96.204;DATABASE=Kargo;UID=root;PWD=1234";
            harita = new Harita();
            harita.Show();

            VeriGetir(mysqlBaglantisi);

        }

        private void VeriGetir(string mysqlBaglantisi)
        {
            using (var baglan = new MySqlConnection(mysqlBaglantisi))
            {
                try
                {
                    baglan.Open();
                    MySqlCommand komut = new MySqlCommand("SELECT * FROM kargolar", baglan);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = komut;
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
                catch (Exception hata)
                {
                    MessageBox.Show("baglantı olmadı nedeni \n " + hata.ToString());
                    throw;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(xTextBox1.Text.Trim().Equals("") && yTextBox.Text.Trim().Equals("")))
            {
                var point = new GMap.NET.PointLatLng(Convert.ToDouble(xTextBox1.Text), Convert.ToDouble(yTextBox.Text));
                LoadMap(point);
                //IsaretEkle(point);
            }
            else
            {

                if (!(adresText.Text.Trim().Equals("")))
                {
                    GeoCoderStatusCode statusCode;
                    var pointLatLng = GoogleMapProvider.Instance.GetPoint(adresText.Text.Trim(), out statusCode);
                    xTextBox1.Text = pointLatLng?.Lat.ToString();
                    yTextBox.Text = pointLatLng?.Lng.ToString();
                    button1.PerformClick();
                }
                else
                {
                    MessageBox.Show("adres boş");
                }
            }




            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 15;

        }

        private void LoadMap(PointLatLng point)
        {
            map.Position = point;
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBoxTiklama.Checked == true && e.Button == MouseButtons.Left)
            {
                var point = map.FromLocalToLatLng(e.X, e.Y);
                double x = point.Lat;
                double y = point.Lng;

                xTextBox1.Text = x + "";
                yTextBox.Text = y + "";

                map.Position = point;
                LoadMap(point);
                // IsaretEkle(point);

                var adres = AdresGetir(point);
                if (adres != null)
                    adresText.Text = ("adres: " + adres[0]);

                else
                    adresText.Text = "adres bulunamadı";
            }
        }
        private void buttonKargoEkle_Click(object sender, EventArgs e)
        {
            string mysqlBaglantisi = "SERVER=34.69.96.204;DATABASE=Kargo;UID=root;PWD=1234";
            using (var baglan = new MySqlConnection(mysqlBaglantisi))
            {
                try
                {
                    baglan.Open();
                    MySqlCommand komut = new MySqlCommand("insert into kargolar (kargo_konumx,kargo_konumy,kargo_teslim,kargo_sahibi) values (@p1,@p2,@p3,@p4)", baglan);
                    komut.Parameters.AddWithValue("@p1", (Convert.ToDouble(xTextBox1.Text)));
                    komut.Parameters.AddWithValue("@p2", (Convert.ToDouble(yTextBox.Text)));
                    komut.Parameters.AddWithValue("@p3", "edilmedi");
                    komut.Parameters.AddWithValue("@p4", textBoxSahibi.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("eklendi");
                    var point = new GMap.NET.PointLatLng(Convert.ToDouble(xTextBox1.Text), Convert.ToDouble(yTextBox.Text));
                    Kargo kargo = new Kargo();
                    kargo.x = Convert.ToDouble(xTextBox1.Text);
                    kargo.y = Convert.ToDouble(yTextBox.Text);
                    IsaretEkle(point);
                    LoadMap(point);
                    YenileMap();


                }

                catch (Exception hata)
                {
                    MessageBox.Show("baglantı olmadı nedeni \n " + hata.ToString());
                    throw;
                }

            }
            VeriGetir(mysqlBaglantisi);
            harita.HaritaYenile();
            

        }

        private void buttonKargolariGetir_Click(object sender, EventArgs e)
        {
            string mysqlBaglantisi = "SERVER=34.69.96.204;DATABASE=Kargo;UID=root;PWD=1234";
            using (var baglan = new MySqlConnection(mysqlBaglantisi))
            {
                try
                {
                    baglan.Open();
                    MySqlDataReader oku;
                    MySqlCommand komut = new MySqlCommand("SELECT kargo_konumx,kargo_konumy FROM kargolar WHERE kargo_teslim ='edilmedi'", baglan);
                    oku = komut.ExecuteReader();
                    while (oku.Read())
                    { 
                        Kargo kargo = new Kargo();

                        kargo.point = new PointLatLng(oku.GetDouble(0), oku.GetDouble(1));
                        kargos.Add(kargo);
                    }

                }


                catch (Exception hata)
                {
                    MessageBox.Show("baglantı olmadı nedeni \n " + hata.ToString());
                    throw;
                }
                MarkerTemizle();
                for (int i = 0; i < kargos.Count; i++)
                {
                    IsaretEkle(kargos[i].point);
                }
                YenileMap();
            }
        }




        private void MarkerTemizle()
        {
            for (int i = 0; i < markers.Markers.Count(); i++)
            {
                markers.Markers.RemoveAt(0);
            }
        }
        GMapOverlay markers = new GMapOverlay("markers");
        private void IsaretEkle(PointLatLng pointekle)
        {
           
            var marker = new GMarkerGoogle(pointekle, GMarkerGoogleType.red);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);

        }
        private List<string> AdresGetir(PointLatLng point)
        {
            List<Placemark> placemarks = null;
            var statusCode = GMapProviders.GoogleMap.GetPlacemarks(point, out placemarks);
            if (placemarks != null)
            {
                List<string> adresler = new List<string>();
                foreach (var placemark in placemarks)
                {
                    adresler.Add(placemark.Address);
                }
                return adresler;
            }
            return null;
        }
        private void YenileMap()
        {
            map.Zoom++;
            map.Zoom--;
        }

        private void buttonKargoSil_Click(object sender, EventArgs e)
        {
            string mysqlBaglantisi = "SERVER=34.69.96.204;DATABASE=Kargo;UID=root;PWD=1234";
            using (var baglan = new MySqlConnection(mysqlBaglantisi))
            {
                try
                {
                    baglan.Open();

                    MySqlCommand komut = new MySqlCommand("DELETE  FROM kargolar WHERE kargo_id ='" + dataGridView1.CurrentRow.Cells["kargo_id"].Value.ToString() + "'", baglan);
                    komut.ExecuteNonQuery();



                }


                catch (Exception hata)
                {
                    MessageBox.Show("baglantı olmadı nedeni \n " + hata.ToString());
                    throw;
                }
            }
            VeriGetir(mysqlBaglantisi);
            harita.HaritaYenile();
        }

        private void buttonKargoGuncelle_Click(object sender, EventArgs e)
        {
            string mysqlBaglantisi = "SERVER=34.69.96.204;DATABASE=Kargo;UID=root;PWD=1234";
            using (var baglan = new MySqlConnection(mysqlBaglantisi))
            {
                try
                {
                    baglan.Open();
                    string sorgu = "UPDATE kargolar SET kargo_konumx=@kargo_konumx,kargo_konumy=@kargo_konumy,kargo_sahibi=@kargo_sahibi WHERE kargo_id=@kargo_id";
                    MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                    komut.Parameters.AddWithValue("@kargo_id", dataGridView1.CurrentRow.Cells["kargo_id"].Value);
                    komut.Parameters.AddWithValue("@kargo_konumx", Convert.ToDouble(xTextBox1.Text));
                    komut.Parameters.AddWithValue("@kargo_konumy", Convert.ToDouble(yTextBox.Text));
                    komut.Parameters.AddWithValue("@kargo_sahibi", (textBoxSahibi.Text));
                    komut.ExecuteNonQuery();



                }


                catch (Exception hata)
                {
                    MessageBox.Show("baglantı olmadı nedeni \n " + hata.ToString());
                    throw;
                }
            }
            VeriGetir(mysqlBaglantisi);
            harita.HaritaYenile();
        }

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
