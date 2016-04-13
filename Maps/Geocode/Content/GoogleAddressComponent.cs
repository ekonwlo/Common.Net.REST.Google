using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Attributes;

namespace Common.Net.REST.Google.Maps.Geocode.Content
{
    using Attributes;
    using Transformation;

    public class GoogleAddressComponent
    {

        [RestContent("long_name")]
        public string LongName { get; internal set; }

        [RestContent("short_name")]
        public string ShortName { get; internal set; }

        [RestContent("types")]
        [PropertyTransformation(typeof(AddressTypeTransformation))]
        public GoogleGeocodeAdressTypes Type { get; internal set; }

        internal GoogleAddressComponent() { }
    }
}
