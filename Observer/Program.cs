using System;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subscriber1 = new Subscriber("Oskar");
            var subscriber2 = new Subscriber("Kasia");

            var publisher = new Publisher();

            publisher.Subscribe(subscriber1);
            publisher.Subscribe(subscriber2);

            publisher.Notify("test message ąćżź");

            publisher.UnSubscribe(subscriber1);

            publisher.Notify("second test message ąćżź");


            Console.ReadLine();
        }
    }
}
