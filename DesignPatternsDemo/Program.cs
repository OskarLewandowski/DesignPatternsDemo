using System;
using System.Collections.Generic;

namespace DesignPatternsDemo
{
    internal class Program
    {
        public static void Display(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"\n{list[i].ToUpper()}:");
                }
                else
                {
                    Console.WriteLine($"{i}) {list[i]}");
                }
            }
        }

        static void Main(string[] args)
        {
            List<List<string>> designPatternsList = new List<List<string>>();

            List<string> creationalDesignPatternsItems = new List<string>()
            {
                "creational", "Builder", "Factory", "Abstract factory", "Prototype", "Singleton",
            };
            designPatternsList.Add(creationalDesignPatternsItems);

            List<string> behavioralDesignPatternsItems = new List<string>()
            {
                "behavioral", "Strategy", "Observer", "Mediator", "Chain of responsibility",
                "Template method", "State"
            };
            designPatternsList.Add(behavioralDesignPatternsItems);

            List<string> structuralDesignPatternsItems = new List<string>()
            {
                "structural", "Adapter", "Facade", "Decorator", "Proxy"
            };
            designPatternsList.Add(structuralDesignPatternsItems);

            Console.WriteLine("Design Patterns:");

            for (int i = 0; i < designPatternsList.Count; i++)
            {
                Display(designPatternsList[i]);
            }


            Console.ReadLine();
        }
    }
}
