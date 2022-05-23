using System;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pdfGenerator = new PdfGenerator();
            var csvGenerator = new CsvGenerator();
            var excelGenerator = new ExcelGenrator();

            Console.WriteLine("|--- PDF ---|");
            pdfGenerator.GenerateReport();

            Console.WriteLine("\n|--- CSV ---|");
            csvGenerator.GenerateReport();

            Console.WriteLine("\n|--- EXCEL ---|");
            excelGenerator.GenerateReport();

            Console.ReadLine();
        }
    }
}
