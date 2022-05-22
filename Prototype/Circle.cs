using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override Shape Clone()
        {
            //shallow clone
            //return (Circle)this.MemberwiseClone();

            //deep clone
            Circle cloneBase = (Circle)this.MemberwiseClone();
            cloneBase.Border = new Border()
            {
                Color = cloneBase.Border.Color,
                Size = cloneBase.Border.Size
            };

            return cloneBase;
        }

        public override void Render()
        {
            Console.WriteLine("Render circle");
        }
    }
}
