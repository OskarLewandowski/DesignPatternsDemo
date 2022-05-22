using System;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application windowsApplication = new Application(new WindowsFactory());
            windowsApplication.RenderUI();

            Application macApplication = new Application(new MacFactory());
            macApplication.RenderUI();
            Console.ReadLine();
        }
    }
}
