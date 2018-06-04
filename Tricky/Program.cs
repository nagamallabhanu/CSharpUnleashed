using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricky
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Circle(10, 10);
            //Implicit or upcasting
            s.Draw();
            s.ShapeMet();

            Shape r = new Rectangle(20, 1);
            r.Draw();
            
            //Downcasting or Explicit
            Circle c = (Circle)s;
            c.CircleFillColor();
            c.ShapeMet();
            Console.ReadLine();
        }

        
    }
}
