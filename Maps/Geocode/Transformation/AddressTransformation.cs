using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.Google.Maps.Geocode.Transformation
{
    class AddressTransformation
        : IRestTransformation<string, string>
    {

        public string Transform(string input)
        {
            return string.Join<string>("+", input.Split(new string[] {",", " "}, StringSplitOptions.RemoveEmptyEntries));
        }

        public string Revert(string input)
        {
            throw new NotImplementedException();
        }
    }
}
