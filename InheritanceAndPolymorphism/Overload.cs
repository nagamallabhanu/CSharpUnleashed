using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class Overload
    {
        public void Met()
        {
            Console.WriteLine("Met One");
        }

        protected void Met()
        {
            Console.WriteLine("Met Two");
        }

    }
}
