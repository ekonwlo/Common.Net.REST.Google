using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Google
{
    using Attributes;

    public abstract class GoogleRequest<T> 
        : RestRequest<T> where T : GoogleResponse
    {

        [RestUrlParameter("key")]
        public string TokenKey { get; set; }

        protected internal GoogleRequest() : base() { }
    }
}
