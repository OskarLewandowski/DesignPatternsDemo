using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WindowsTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Render Windows textbox");
        }

        public void HandleClick()
        {
            Console.WriteLine("Handle Windows textbox input");
        }
    }
}
