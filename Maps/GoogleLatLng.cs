using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Google.Maps
{
    using Attributes;

    public class GoogleLatLng
    {

        [RestContent("lng")]
        public double Longitude { get; set; }

        [RestContent("lat")]
        public double Latitude { get; set; }

        internal GoogleLatLng() { }

        public GoogleLatLng(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
