using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricky
{
    public class Shape
    {
        public int XDim { get; set; }
        public int YDim { get; set; }
        static Shape()
        {
           // Console.WriteLine("Parent Class Static Constructor Called");
        }

        protected Shape(int x, int y)
        {
            XDim = x;
            YDim = y;
        }

        public virtual void ShapeMet()
        {
            Console.WriteLine("Shape Method In Shape Class");
        }

        public void MM()
        {
            Console.WriteLine("MM ");
        }

        public  virtual void Draw()
        {
            Console.WriteLine("Draw Shape Method");
        }

        
    }
}
