using System;
using System.Net.Http;

namespace FunkoFinder.Api.Common
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class SwaggerIgnoreAttribute : Attribute
    {

        public HttpMethod HttpMethod { get; set; }

        public SwaggerIgnoreAttribute(HttpMethod httpMethod)
        {
            HttpMethod = httpMethod;
        }
    }
}