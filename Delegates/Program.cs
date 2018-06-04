using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {

            AnotherClass ac = new AnotherClass();
            DelegateExample de = new DelegateExample();
            SampleDelegate sd = new SampleDelegate(ac.Method1);
            sd += de.DellMethod;
            sd.Invoke();
            Console.ReadLine();
        }
    }
}
