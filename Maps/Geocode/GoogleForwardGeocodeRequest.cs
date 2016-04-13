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
    public class GoogleForwardGeocodeRequest
        : GoogleRequest<GoogleForwardGeocodeResponse>
    {

        [RestUrlParameter("address")]
        [PropertyTransformation(typeof(AddressTransformation))]
        public string Address { get; set; }

        [RestUrlParameter("components", Mandatory = false)]
        public string Components { get; set; }



        internal GoogleForwardGeocodeRequest() : base() { }
    }
}
