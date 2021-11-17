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


namespace Prolab1
{
    public partial class Harita : Form
    {
        
        private List<Kargo> kargos;
        private List<Kargo> sirali;
        Kargocu kargocu;
        public Harita()
        {
            InitializeComponent();
            
        }
        private void Harita_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = "AIzaSyBBvXJdF7o1mRmozWjoTcXb0REfblkfkik";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;
            map.SetPositionByKeywords("İzmit, Turkey");
            sirali = new List<Kargo>();
            kargos = new List<Kargo>();
            kargocu = new Kargocu();
            var point = new PointLatLng(40.800180, 29.954833);
            kargocu.point = point;
            KargolarıGetir();
            RotaCiz(EnKisaYolBul());
        }
        public void HaritaYenile()
        {

            RotaVeMakerTemizle();
            sirali.Clear();
            kargos.Clear();
            KargolarıGetir();
            RotaCiz(EnKisaYolBul());
        }

        GMapOverlay rotalar = new GMapOverlay("rotalar");
        GMapOverlay markers = new GMapOverlay("markers");
        private void RotaVeMakerTemizle()
        {
            rotalar.Routes.Clear();
            markers.Markers.Clear();
            map.Refresh();
        }
        private void rotaSilButton_Click(object sender, EventArgs e)
        {
            if (rotalar.Routes.Count > 0)
            {
                kargocu.point = sirali[0].point;
                KargoVeritabaniGuncelle(sirali[0].kargoId);
                sirali.RemoveAt(0);
                rotalar.Routes.RemoveAt(0);
                markers.Markers[0].Position = kargocu.point;
                markers.Markers.RemoveAt(1);
                map.Refresh();
                
            }
            else
            {
                MessageBox.Show("kargolar teslim edilmiştir");
            }


            YenileMap();
        }


        private void IsaretEkle(PointLatLng pointekle)
        {

            var marker = new GMarkerGoogle(pointekle, GMarkerGoogleType.red);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);

        }
        private void KargocuIsaretEkle(PointLatLng pointekle)
        {

            var marker = new GMarkerGoogle(pointekle, GMarkerGoogleType.arrow);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);

        }

        private void YenileMap()
        {
            map.Zoom++;
            map.Zoom--;
        }

        private double MesafeBul(PointLatLng point1, PointLatLng point2)
        {
            var rota = GoogleMapProvider.Instance.GetRoute(point1, point2, false, false, 14);
            //  MessageBox.Show(rota.Distance+"");
            return rota.Distance;
        }



        
        private void KargolarıGetir()
        {
            string mysqlBaglantisi = "SERVER=34.69.96.204;DATABASE=Kargo;UID=root;PWD=1234";
            using (var baglan = new MySqlConnection(mysqlBaglantisi))
            {
                try
                {
                    baglan.Open();
                    MySqlDataReader oku;
                    MySqlCommand komut = new MySqlCommand("SELECT kargo_id,kargo_konumx,kargo_konumy FROM kargolar WHERE kargo_teslim ='edilmedi'", baglan);
                    oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        Kargo kargo = new Kargo();
                        kargo.kargoId = oku.GetInt32(0);
                        kargo.point = new PointLatLng(oku.GetDouble(1), oku.GetDouble(2));
                        kargos.Add(kargo);
                    }

                }


                catch (Exception hata)
                {
                    MessageBox.Show("baglantı olmadı nedeni \n " + hata.ToString());
                    throw;
                }


            }
        }
        private List<string> YolHazirla()
        {
            Random rand = new Random();
            List<string> yollar = new List<string>();
            List<int> randomList = new List<int>();
            string temp = "";
            int MyNumber = 0;
            int faktoriyel = 1;
            for (int i = 0; i < kargos.Count + 1; i++)
                faktoriyel = faktoriyel * (i + 1);
            while (yollar.Count != faktoriyel / (kargos.Count + 1))
            {
                randomList.Add(0);
                while (randomList.Count != kargos.Count + 1)
                {
                    MyNumber = rand.Next(1, kargos.Count + 1);
                    if (!randomList.Contains(MyNumber))
                    {
                        randomList.Add(MyNumber);
                        
                    }
                }
                for (int i = 0; i < kargos.Count + 1; i++)
                {
                    temp = temp + Convert.ToString(randomList[i]);
                }
                randomList.Clear();
                if (!yollar.Contains(temp))
                {
                    yollar.Add(temp);
                }
                temp = "";
            }
            return yollar;
        }
        private int[] EnKisaYolBul()
        {
            List<string> yolSecenekleri = YolHazirla();
            int[,] yollar = new int[yolSecenekleri.Count, kargos.Count + 1];
            int[] enKisaRota = new int[kargos.Count + 1];
            for (int i = 0; i < yolSecenekleri.Count; i++)
            {
                for (int j = 0; j < kargos.Count + 1; j++)
                {
                    yollar[i, j] = Convert.ToInt32(yolSecenekleri[i].Substring(j, 1));
                }
            }
            double toplamYol = 0;
            double enKısaYol = 0;
            for (int i = 0; i < yolSecenekleri.Count; i++)
            {
                for (int j = 0; j < kargos.Count; j++)
                {
                    if (j == 0)
                    {
                        toplamYol += MesafeBul(kargocu.point, kargos[yollar[i, j + 1] - 1].point);
                    }
                    else
                    {
                        toplamYol += MesafeBul(kargos[yollar[i, j] - 1].point, kargos[yollar[i, j + 1] - 1].point);
                    }
                }
                if (i == 0)
                    enKısaYol = toplamYol;
                if (toplamYol <= enKısaYol)
                {
                    for (int k = 0; k < kargos.Count + 1; k++)
                    {
                        enKisaRota[k] = yollar[i, k];
                    }
                    enKısaYol = toplamYol;
                }

                
                toplamYol = 0;
            }
            return enKisaRota;

        }
        private void RotaCiz(int[] enKisaRota)
        {
            for (int i = 0; i < kargos.Count; i++)
            {
                if (i == 0)
                {
                    var rotas = GoogleMapProvider.Instance.GetRoute(kargocu.point, kargos[enKisaRota[i + 1] - 1].point, false, false, 14);
                    var rr = new GMapRoute(rotas.Points, "benim rotam")
                    {
                        Stroke = new Pen(Color.Red, 5)
                    };
                    KargocuIsaretEkle(kargocu.point);
                    sirali.Add(kargos[enKisaRota[i + 1] - 1]);
                    IsaretEkle(kargos[enKisaRota[i + 1] - 1].point);
                    rotalar.Routes.Add(rr);
                    map.Overlays.Add(rotalar);
                }
                else
                {
                    var rota = GoogleMapProvider.Instance.GetRoute(kargos[enKisaRota[i] - 1].point, kargos[enKisaRota[i + 1] - 1].point, false, false, 14);
                    var r = new GMapRoute(rota.Points, "benim rotam")
                    {
                        Stroke = new Pen(Color.Red, 5)
                    };
                    sirali.Add(kargos[enKisaRota[i + 1] - 1]);
                    IsaretEkle(kargos[enKisaRota[i + 1] - 1].point);
                    rotalar.Routes.Add(r);
                    map.Overlays.Add(rotalar);
                }
            }



            YenileMap();
        }
        private void KargoVeritabaniGuncelle(int kargoId)
        {
            string mysqlBaglantisi = "SERVER=34.69.96.204;DATABASE=Kargo;UID=root;PWD=1234";
            using (var baglan = new MySqlConnection(mysqlBaglantisi))
            {
                try
                {
                    baglan.Open();
                    String sorgu = "UPDATE kargolar SET kargo_teslim=@kargo_teslim WHERE kargo_id=@kargo_id";
                    MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                    komut.Parameters.AddWithValue("@kargo_id", kargoId);
                    komut.Parameters.AddWithValue("@kargo_teslim", "edildi");
                    komut.ExecuteNonQuery();



                }


                catch (Exception hata)
                {
                    MessageBox.Show("baglantı olmadı nedeni \n " + hata.ToString());
                    throw;
                }
            }

        }

        private void Harita_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
