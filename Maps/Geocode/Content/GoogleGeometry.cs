using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Attributes;

namespace Common.Net.REST.Google.Maps.Geocode.Content
{
    using Attributes;
    using Transformation;

    public class GoogleGeometry
    {

        [RestContent("location")]
        public GoogleLatLng Location { get; internal set; }

        [RestContent("location_type")]
        [PropertyTransformation(typeof(LocationTypeTransformation))]
        public GoogleGeocodeLocationTypes LocationType { get; internal set; }

        [RestContent("viewport")]
        public GoogleBoundingBox Viewport { get; internal set; }

        [RestContent("bounds", Mandatory = false)]
        public GoogleBoundingBox Bounds { get; internal set; }
        
        internal GoogleGeometry() { }
    }
}
