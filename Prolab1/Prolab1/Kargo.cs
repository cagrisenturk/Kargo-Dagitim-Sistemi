using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET;


namespace Prolab1
{
    class Kargo
    {
        public Kargo()
        {

        }

        
        public double x { get; set; }
        public double y { get; set; }
        public PointLatLng point { get; set; }
        public string kargoSahibi { get; set; }
        public int kargoId { get; set; }
    }
}
