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
            //return (Triangle)this.MemberwiseClone();

            //deep clone
            var cloneBase = (Triangle)this.MemberwiseClone();
            cloneBase.Border = new Border()
            {
                Color = cloneBase.Border.Color,
                Size = cloneBase.Border.Size
            };

            return cloneBase;
        }

        public override void Render()
        {
            Console.WriteLine("Render triangle");
        }
    }
}
