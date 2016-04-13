using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Attributes;

namespace Common.Net.REST.Google.Maps.Elevation
{
    using Attributes;
    using Transformation;

    [RestRequest("maps/api/elevation/json")]
    public class GoogleElevationRequest
        : GoogleRequest<GoogleElevationResponse> 
    {

        [RestUrlParameter("locations", Mandatory = false)]
        [PropertyTransformation(typeof(EncodedPolylineTransformator))]
        public GoogleLatLng[] Locations { get; set; }

        [RestUrlParameter("path", Mandatory = false)]
        [PropertyTransformation(typeof(EncodedPolylineTransformator))]
        public GoogleLatLng[] Path { get; set; }

        [RestUrlParameter("samples", Mandatory = false)]
        public int? Samples { get; set; }

        internal GoogleElevationRequest() : base() { }
    }
}
