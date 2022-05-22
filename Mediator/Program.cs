using System;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Button submitButton = new Button();
            CheckBox clientType = new CheckBox();

            new RegisterClientView(clientType, submitButton);

            submitButton.Click();
            clientType.Select();

            Console.ReadLine();
        }
    }
}