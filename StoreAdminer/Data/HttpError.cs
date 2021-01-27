using System;
using System.Net;

namespace StoreAdminer.Data
{
    public class HttpError : Exception
    {
        public HttpStatusCode StatusCode { get; set; }

        public HttpError(HttpStatusCode statusCode, string msg) : base(msg)
        {
            StatusCode = statusCode;
        }
    }
}