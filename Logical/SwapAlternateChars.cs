using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace Logical
{
    public class SwapAlternateChars
    {

        public void SwapChars()
        {
            string strToSwap = Console.ReadLine();
            char[] charArr = strToSwap.ToCharArray();
            StringBuilder swappedStr = new StringBuilder();
            for(int i=0;i<strToSwap.Length;i=i+2)
            {
                if (i % 2 == 0 && i< strToSwap.Length-1)
                {
                    swappedStr.Append(charArr[i + 1]).Append(charArr[i]);
                }
                else
                {
                    swappedStr.Append(charArr[i]);
                }
            }
            WriteLine(swappedStr);
            ReadLine();

        }
    }
}
