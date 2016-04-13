using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.Google.Maps.Geocode.Transformation
{
    class LocationTypeTransformation
        : IRestTransformation<GoogleGeocodeLocationTypes, string>
    {
        public string Transform(GoogleGeocodeLocationTypes input)
        {
            throw new NotImplementedException();
        }

        public GoogleGeocodeLocationTypes Revert(string input)
        {
            switch (input)
            {
                case "ROOFTOP":
                    return GoogleGeocodeLocationTypes.Rooftop;
                case "RANGE_INTERPOLATED":
                    return GoogleGeocodeLocationTypes.RangeInterpolated;
                case "GEOMETRIC_CENTER":
                    return GoogleGeocodeLocationTypes.GeometricCenter;
                case "APPROXIMATE":
                    return GoogleGeocodeLocationTypes.Approximate;
                default :
                    throw new ArgumentException("location_type");
            };
        }
    }
}
