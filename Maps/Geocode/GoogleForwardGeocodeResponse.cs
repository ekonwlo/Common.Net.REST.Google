using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Google.Maps.Geocode
{
    using Attributes;
    using Content;

    public class GoogleForwardGeocodeResponse
        : GoogleResponse
    {
        [RestContent("content")]
        public GoogleGeocodeResponseContent Content { get; internal set; }

        internal GoogleForwardGeocodeResponse() : base() { }
    }
}
