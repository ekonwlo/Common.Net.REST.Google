using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Google.Maps.Elevation
{
    using Attributes;
    using Content;

    public class GoogleElevationResponse
        : GoogleResponse
    {

        [RestContent("content")]
        public GoogleElevationResponseContent Content { get; internal set; }

        internal GoogleElevationResponse() : base() { }
    }
}
