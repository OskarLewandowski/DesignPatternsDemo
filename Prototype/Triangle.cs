using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Triangle : Shape
    {
        public override Shape Clone()
        {
            //shallow clone
            return (Triangle)this.MemberwiseClone();
        }

        public override void Render()
        {
            Console.WriteLine("Render triangle");
        }
    }
}
