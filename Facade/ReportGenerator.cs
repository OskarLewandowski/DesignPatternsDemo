using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ReportGenerator
    {
        public void GenerateReport(IEnumerable<string> qualityScanErrors,
            IEnumerable<string> securityScanErrors, IEnumerable<string> dependencyScanErrors)
        {
            Console.WriteLine("\nQuality Scan Errors");
            Console.WriteLine(string.Join(", ", qualityScanErrors));

            Console.WriteLine("\nSecurity Scan Errors");
            Console.WriteLine(string.Join(", ", securityScanErrors));

            Console.WriteLine("\nDependency Scan Errors");
            Console.WriteLine(string.Join(", ", dependencyScanErrors));
        }
    }
}
