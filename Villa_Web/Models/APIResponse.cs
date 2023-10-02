using System.Net;

namespace Villa_Web.Models
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; }  = true;
        public List<string> ErrorsMessage { get; set; }
        public object Result { get; set; }
    }
}
