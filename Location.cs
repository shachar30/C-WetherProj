using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetherapp
{
    public class Location
    {
        public double lat { get; set; }
        public double lng { get; set; }


        //Constractor
        public Location(double lat, double lng)
        {
            this.lat = lat;
            this.lng = lng;
        }
    }
}


