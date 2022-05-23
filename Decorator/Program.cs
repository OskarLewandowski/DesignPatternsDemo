using System;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pizzaBase = new MediumPizza();

            var mediumPizzaWithCheese = new CheesePizzaDecorator(pizzaBase);
            Console.WriteLine($"mediumPizzaWithCheese: {mediumPizzaWithCheese.CalculatePrice()} pln");

            var mediumPizzaWithCheeseAndSalami = new SalamiPizzaDecorator(mediumPizzaWithCheese);
            Console.WriteLine($"mediumPizzaWithCheeseAndSalami: {mediumPizzaWithCheeseAndSalami.CalculatePrice()} pln");

            var pizzaNumberTwo = new HamPizzaDecorator(mediumPizzaWithCheeseAndSalami);
            Console.WriteLine($"pizzaNumberTwo: {pizzaNumberTwo.CalculatePrice()} pln");

            var pizzaNumberTwoX2Salami = new SalamiPizzaDecorator(pizzaNumberTwo);
            Console.WriteLine($"pizzaNumberTwoX2Salami: {pizzaNumberTwoX2Salami.CalculatePrice()} pln");

            Console.ReadLine();
        }
    }
}
