using System;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle()
            {
                Radius = 5,
                X = 1,
                Y = 2,
                Border = new Border()
                {
                    Color = "red",
                    Size = "2px"
                }
            };

            Circle circle2 = (Circle)circle1.Clone();

            bool referenceEquals = ReferenceEquals(circle1, circle2);
            Console.WriteLine($"referenceEquals: {referenceEquals}");

            bool borderReferenceEquals = ReferenceEquals(circle1.Border, circle2.Border);
            Console.WriteLine($"borderReferenceEquals: {borderReferenceEquals}");

            Console.ReadLine();
        }
    }
}
