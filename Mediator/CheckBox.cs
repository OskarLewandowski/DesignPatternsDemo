using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class CheckBox : Component
    {
        public void Select()
        {
            Console.WriteLine("CheckBox selected");

            this._mediator.Notify(this, "checkboxselected");
        }

        public void SaveValue()
        {
            Console.WriteLine("CheckBox value saved");
        }
    }
}
