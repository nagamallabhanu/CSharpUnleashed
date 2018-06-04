using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricky
{
    public class Rectangle : Shape
    {
        public Rectangle(int x, int y) : base(x, y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle Draw at {0},{1}",XDim,YDim);
        }


        
    }
}
