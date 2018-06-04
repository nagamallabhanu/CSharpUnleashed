using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricky
{
    public class RefOutParameters
    {
        public void PassByValue(string s)
        {
            s = "is";
        }

        public void PassByReference(ref string r)
        {
            r = "interesting";
        }

        public void PassByOutput(out string s)
        {
            s = "language";
        }
    }
}
