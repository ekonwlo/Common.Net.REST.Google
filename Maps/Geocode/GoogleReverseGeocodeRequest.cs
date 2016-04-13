using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Attributes;

namespace Common.Net.REST.Google.Maps.Geocode
{
    using Attributes;
    using Transformation;

    [RestRequest("maps/api/geocode/json")]
    public class GoogleReverseGeocodeRequest
        : GoogleRequest<GoogleReverseGeocodeResponse>
    {

        [RestUrlParameter("latlng")]
        [PropertyTransformation(typeof(LatLngTransformation))]
        public GoogleLatLng Coordinates { get; set; }

        [RestUrlParameter("location_type", Mandatory = false)]
        public string LocationType { get; set; }

        [RestUrlParameter("result_type", Mandatory = false)]
        public string ResultType { get; set; }
        
        internal GoogleReverseGeocodeRequest() : base() { }
    }
}
