using System;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var scan = new ScanFacade();

            scan.Scan("http://github.com//oskarlewandowski/somerepo");

            Console.ReadLine();
        }
    }
}
