using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Google
{
    using Attributes;

    public class GoogleResponseContent
    {

        [RestContent("status")]
        public string Status { get; internal set; }

        [RestContent("error_message", Mandatory = false)]
        public string ErrorMessage { get; internal set; }

        internal protected GoogleResponseContent() { }
    }
}
