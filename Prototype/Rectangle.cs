using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Rectangle : Shape
    {
        public override Shape Clone()
        {
            //shallow clone
            //return (Rectangle)this.MemberwiseClone();

            //deep clone
            var cloneBase = (Rectangle)this.MemberwiseClone();
            cloneBase.Border = new Border()
            {
                Color = cloneBase.Border.Color,
                Size = cloneBase.Border.Size
            };

            return cloneBase;
        }

        public override void Render()
        {
            Console.WriteLine("Render rectangle");
        }
    }
}
