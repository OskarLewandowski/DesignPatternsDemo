using System;
using System.Collections.Generic;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new InvoiceBuilder();

            builder.SetDate(new DateTime(2022, 5, 4));
            builder.SetInvoiceNumber("202200001");
            builder.SetVendor("Google..");
            builder.SetVendee("BankABC");
            builder.SetLineItems(new List<string>()
            {
                "Line item1",
                "Line item2",
                "Line item3",
                "Line item4",
                "Line item5",
                "Line item6"
            });

            var invoice = builder.Build();

            Console.WriteLine(invoice.Number);
            foreach (var item in invoice.LineItems)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
