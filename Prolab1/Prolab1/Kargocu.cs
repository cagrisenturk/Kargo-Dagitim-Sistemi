using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;

namespace Prolab1
{
    class Kargocu
    {
        public Kargocu()
        {

        }


        public double x { get; set; }
        public double y { get; set; }
        public PointLatLng point { get; set; }

        private void KargocuIlerle(PointLatLng yeniKonum)
        {
            point = yeniKonum;
        }
    }
}
