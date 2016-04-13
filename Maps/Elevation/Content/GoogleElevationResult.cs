using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Google.Maps.Elevation.Content
{
    using Attributes;
    
    public class GoogleElevationResult
    {

        [RestContent("elevation")]
        public double Elevation { get; internal set; }

        [RestContent("location")]
        public GoogleLatLng Location { get; internal set; }

        [RestContent("resolution")]
        public double Resolution { get; internal set; }
        
        internal GoogleElevationResult() { }
    }
}
