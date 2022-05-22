using System;
using System.Collections.Generic;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var displayInvoiceDetails = new InvoiceDetails();
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
            displayInvoiceDetails.Display(invoice);

            var builder2 = new InvoiceBuilder();
            var invoice2 = builder2.SetDate(new DateTime(2022, 5, 4))
                 .SetInvoiceNumber("202200002")
                 .SetVendor("Google..")
                 .SetVendee("BankABC")
                 .SetLineItems(new List<string>()
                 {
                    "Line item11",
                    "Line item22",
                    "Line item33",
                    "Line item44",
                    "Line item55",
                    "Line item66"
                 })
                 .Build();

            displayInvoiceDetails.Display(invoice2);

            var director = new Director(builder2);

            var monthlyInvoice = director.createMonthlyInvoice();
            displayInvoiceDetails.Display(monthlyInvoice);

            var blankInvoice = director.createBlankInvoice();
            displayInvoiceDetails.Display(blankInvoice);


            Console.ReadLine();
        }
    }
}
