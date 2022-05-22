using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class InvoiceBuilder
    {
        private Invoice _invoice = new Invoice();

        public Invoice Build()
        {
            return _invoice;
        }

        public void SetVendor(string vendor)
        {
            _invoice.Vendor = vendor;
        }

        public void SetVendee(string vendee)
        {
            _invoice.Vendee = vendee;
        }

        public void SetNote(string note)
        {
            _invoice.Note = note;
        }

        public void SetLineItems(IEnumerable<string> lineItems)
        {
            _invoice.LineItems = lineItems;
        }

        public void SetInvoiceNumber(string number)
        {
            _invoice.Number = number;
        }

        public void SetDate(DateTime date)
        {
            _invoice.Date = date;
        }
    }
}
