using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Maps.Utils;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.Google.Maps.Transformation
{
    class EncodedPolylineTransformator
        : IRestTransformation<GoogleLatLng[], string>
    {
        public string Transform(GoogleLatLng[] points)
        {
            if (points == null)
                return null;

            if (points.Length < 1)
                throw new ArgumentException("Points array must contain at least one element.", "points");

            double lat = 0, lng = 0;
            string polyline = string.Empty;

            for (int i = 0; i < points.Length; i++)
            {
                polyline += string.Format("{0}{1}", EncodedPolyline.Encode(points[i].Latitude - lat), EncodedPolyline.Encode(points[i].Longitude - lng));

                lat = points[i].Latitude;
                lng = points[i].Longitude;
            }

            return string.Format("enc:{0}", polyline);
        }

        public GoogleLatLng[] Revert(string input)
        {
            throw new NotImplementedException();
        }
    }
}
