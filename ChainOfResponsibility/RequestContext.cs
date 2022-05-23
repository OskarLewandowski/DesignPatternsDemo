using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class RequestContext
    {
        public Request Request { get; set; }
        public Response Response { get; set; }
    }
}
