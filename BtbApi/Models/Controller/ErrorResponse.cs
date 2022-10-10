using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbDomain.Controller
{
    public class ErrorResponse
    {
        public string Message { get; set; }

        public string Detailed { get; set; }

        public ErrorResponse()
        {

        }

        public ErrorResponse(Exception e)
        {
            this.Message = e.Message;
            this.Detailed = e.ToString();
        }
    }
}
