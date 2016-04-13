using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Net.REST.Attributes;

namespace Common.Net.REST.Google.Maps.Geocode.Content
{
    public class GoogleGeocodeResponseContent
        : GoogleResponseContent
    {

        [RestContent("results")]
        public GoogleGeocodeResult[] Results
        {
            get;
            internal set;
        }

        internal GoogleGeocodeResponseContent() : base() { }
    }
}
