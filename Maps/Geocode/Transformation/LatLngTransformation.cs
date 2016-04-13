using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.Google.Maps.Geocode.Transformation
{
    class LatLngTransformation
        : IRestTransformation<GoogleLatLng, string>
    {
        private static readonly CultureInfo _cultureInfo;

        static LatLngTransformation()
        {
            _cultureInfo = new CultureInfo("en-US");
        }

        public string Transform(GoogleLatLng input)
        {
            return string.Format("{0},{1}", input.Latitude.ToString(_cultureInfo), input.Longitude.ToString(_cultureInfo));
        }

        public GoogleLatLng Revert(string input)
        {
            throw new NotImplementedException();
        }

        //internal LatLngTransformation() { }
    }
}
