using System;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            Console.WriteLine(1);
            context.EjectCard();
            context.InsertPin(9999);
            context.InsertCard();
            context.WithdrawCash(222);

            Console.WriteLine(2);
            context.InsertCard();
            context.InsertPin(1111);
            context.WithdrawCash(5000);

            Console.WriteLine(3);
            context.InsertCard();
            context.InsertPin(8888);
            context.WithdrawCash(5000);

            Console.WriteLine(4);
            context.EjectCard();
            context.InsertCard();
            context.InsertPin(1111);
            context.InsertCard();
            context.InsertPin(8888);
            context.WithdrawCash(5000);
            context.InsertCard();

            Console.ReadLine();
        }
    }
}
