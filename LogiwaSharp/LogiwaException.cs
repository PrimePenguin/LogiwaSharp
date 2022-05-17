using System;
using System.Net;

namespace LogiwaSharp
{
    public class LogiwaException : Exception
    {
        public override string Message => ApiResponse;

        public string ApiResponse { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }
}
