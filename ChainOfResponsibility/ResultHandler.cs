using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ResultHandler : BaseHandler
    {
        public ResultHandler(IHandler next) : base(next)
        {

        }

        public override void Handle(RequestContext requestContext)
        {
            Console.WriteLine("ResultHandler\n");
            requestContext.Response.IsSuccessful = true;
            requestContext.Response.Message = "Correctly request";
            requestContext.Response.Data = new List<string>()
            {
                "----------------------",
                "This is number 1",
                "This is example value",
                "----------------------",
            };
        }
    }
}
