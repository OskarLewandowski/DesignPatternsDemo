using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var requestContext = new RequestContext()
            {
                Request = new Request()
                {
                    EntityId = 100,
                    UserId = 01,
                    UserRole = "Admin"
                },

                Response = new Response()
            };

            var resultHandler = new ResultHandler(null);
            var validationHadler = new ValidationHandler(resultHandler);
            var authorizationHandler = new AuthorizationHandler(validationHadler);

            authorizationHandler.Handle(requestContext);

            Console.WriteLine($"IsSuccessful: {requestContext.Response.IsSuccessful}");
            Console.WriteLine($"Message: {requestContext.Response.Message}");
            Console.WriteLine($"Data:");

            List<string> data = (List<string>)requestContext.Response.Data;
            if (data is not null)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    Console.WriteLine(data[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
