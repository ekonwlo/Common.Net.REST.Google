using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Attributes;

namespace Common.Net.REST.Google.Maps.Geocode.Content
{
    using Attributes;
    using Transformation;

    public class GoogleGeocodeResult
    {

        [RestContent("address_components")]
        public GoogleAddressComponent[] AddressComponents { get; internal set; }

        [RestContent("geometry")]
        public GoogleGeometry Geometry { get; internal set; }

        [RestContent("formatted_address")]
        public string FormattedAddres { get; internal set; }

        [RestContent("place_id")]
        public string PlaceId { get; internal set; }

        [RestContent("partial_match", Mandatory = false)]
        public bool IsPartialMatch { get; internal set; }

        [RestContent("types")]
        [PropertyTransformation(typeof(AddressTypeTransformation))]
        public GoogleGeocodeAdressTypes Type { get; internal set; }

        internal GoogleGeocodeResult() { }
    }
}
