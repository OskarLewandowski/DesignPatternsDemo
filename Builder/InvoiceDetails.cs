using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class InvoiceDetails
    {
        public void Display(Invoice invoice)
        {
            Console.WriteLine($"Invoice number: {invoice.Number}");
            Console.WriteLine($"Invoice date: {invoice.Date}");
            Console.WriteLine($"Invoice vendor: {invoice.Vendor}");
            Console.WriteLine($"Invoice vendee: {invoice.Vendee}");
            Console.WriteLine(invoice.Note != null ? "Invoice note: " + invoice.Note : "Invoice note: -");

            if (invoice.LineItems != null)
            {
                Console.WriteLine($"Invoice list item: ");
                int i = 1;
                foreach (var item in invoice.LineItems)
                {
                    Console.WriteLine($"{i}) {item}");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Invoice list item: -");
            }
            Console.WriteLine("\n");
        }
    }
}
