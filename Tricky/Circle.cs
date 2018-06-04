using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricky
{
    public class Circle:Shape
    {

        public Circle(int x, int y) :base(x,y)
        {
        }


        public void CircleFillColor()
        {
            Console.WriteLine("Circle CircleFillColor method");
        }

        public override void Draw()
        {
            Console.WriteLine("Draw circle at {0},{1}",XDim,YDim);
        }

        public new void ShapeMet()
        {
            Console.WriteLine("Shape Method In Circle Class");
        }
    }
}
