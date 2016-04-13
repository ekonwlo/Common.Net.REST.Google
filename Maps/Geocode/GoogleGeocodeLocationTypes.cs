using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Google.Maps.Geocode
{
    public enum GoogleGeocodeLocationTypes : byte
    {
        Unknown = 0,
        Rooftop = 1,            // restricts the results to addresses for which we have location information accurate down to street address precision. 
        RangeInterpolated = 2,  // restricts the results to those that reflect an approximation (usually on a road) interpolated between two precise points (such as intersections). An interpolated range generally indicates that rooftop geocodes are unavailable for a street address.
        GeometricCenter = 4,    // restricts the results to geometric centers of a location such as a polyline (for example, a street) or polygon (region).
        Approximate = 8         // restricts the results to those that are characterized as approximate.

    }
}
