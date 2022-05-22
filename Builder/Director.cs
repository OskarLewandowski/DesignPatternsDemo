using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        private IInvoiceBuilder _invoiceBuilder { get; set; }

        public Director(IInvoiceBuilder builder)
        {
            this._invoiceBuilder = builder;
        }

        public Invoice createMonthlyInvoice()
        {
            var currentDate = DateTime.UtcNow;
            var invoiceMonthly = _invoiceBuilder.SetDate(new DateTime(currentDate.Year, currentDate.Month, 1))
                 .Build();

            return invoiceMonthly;
        }

        public Invoice createBlankInvoice()
        {
            var currentDate = DateTime.UtcNow;
            var blankInvoce = _invoiceBuilder.SetDate(new DateTime(currentDate.Year, currentDate.Month, 1))
                 .SetInvoiceNumber("-")
                 .SetVendor("-")
                 .SetVendee("-")
                 .SetLineItems(new List<string>()
                 {
                    "-",
                 })
                 .Build();

            return blankInvoce;
        }
    }
}
