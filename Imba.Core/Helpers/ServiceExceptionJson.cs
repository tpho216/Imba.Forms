using System;
using Microsoft.OpenApi.Extensions;
using Newtonsoft.Json;

namespace Imba.Core.Helpers
{
    public class ServiceExceptionJson
    {
        public ServiceExceptionJson(ServiceException exception)
        {
            StatusCode = (int)exception.Status;
            StatusType = exception.Status.GetDisplayName();
            Message = exception.Message;
#if DEBUG
            StackTrace = exception.StackTrace;
#endif
        }

        public ServiceExceptionJson(int statusCode, string statusType, string message)
        {
            StatusCode = statusCode;
            StatusType = statusType;
            Message = message;
        }

        [JsonProperty("code")]
        public int StatusCode { get; set; }

        [JsonProperty("type")]
        public string StatusType { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
#if DEBUG
        [JsonProperty("stack_trace")]
        public string StackTrace { get; set; }
#endif
    }

}
