using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOperation
{
    public class BitOperation
    {
        static void Main(string[] args)
        {
            int v = 35, p = 6, i = 1, mask = i << p;
            bool isOne = (v & mask) != 0;
            if ((v & mask) != 0)
            {
                Console.WriteLine("Third bit is 1");
            }
            else
            {
                Console.WriteLine("Third bit is 0");
            }
        }
    }
}
