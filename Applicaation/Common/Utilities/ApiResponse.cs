using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Utilities
{
    public class ApiResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorMessages { get; set; } = new ();
        public object? result { get; set; }
        // result has data if any data were to send back from server
        // and better to send a message inside the result object in case of successfull comunication with db
    }
}
