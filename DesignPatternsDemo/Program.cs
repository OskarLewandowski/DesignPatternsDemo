using System;
using System.Collections.Generic;

namespace DesignPatternsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> designPatternsItems = new List<string>()
            {
                "Builder"
            };

            Console.WriteLine("Design Patterns");
            for (int i = 0; i < designPatternsItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {designPatternsItems[i]}");
            }
            Console.ReadLine();
        }
    }
}
