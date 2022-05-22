using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MacTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Render Mac textbox");
        }

        public void HandleClick()
        {
            Console.WriteLine("Handle Mac textbox input");
        }
    }
}
