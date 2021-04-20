using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Imba.Core.Helpers
{
    public class ServiceException : Exception
    {
        public ServiceException(HttpStatusCode status, string message) : base(message)
        {
            Status = status;
        }

        public HttpStatusCode Status { get; set; }

        public JsonResult JsonResult
        {
            get => new JsonResult(new ServiceExceptionJson(this))
            {
                StatusCode = (int)Status
            };
        }
    }
}
