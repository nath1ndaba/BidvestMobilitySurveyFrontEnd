using System;
using System.Net;

namespace BidvestMobilitySurveyFrontEnd.Models
{
    public class Response
    {
#nullable enable
        public object? Data { get; set; }
#nullable disable
        public HttpStatusCode StatusCode { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }
    }

    public class Response<TData> : Response
    {
#nullable enable
        public new TData? Data { get => (TData?)base.Data; set => base.Data = value; }
#nullable disable
    }

}
