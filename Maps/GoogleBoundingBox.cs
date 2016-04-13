using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Google.Maps
{
    using Attributes;

    public class GoogleBoundingBox
    {

        [RestContent("northeast")]
        public GoogleLatLng NorthEast { get; internal set; }

        [RestContent("southwest")]
        public GoogleLatLng SouthWest { get; internal set; }

        internal GoogleBoundingBox() { }
    }
}
