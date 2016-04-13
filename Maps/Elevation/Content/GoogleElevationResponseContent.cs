using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Google.Maps.Elevation.Content
{
    using Attributes; 

    public class GoogleElevationResponseContent
        : GoogleResponseContent
    {

        [RestContent("results")]
        public GoogleElevationResult[] Results { get; internal set; }

        internal GoogleElevationResponseContent() : base() { }
    }
}
