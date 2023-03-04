using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q27
{
    class Program
    {
        static int ReturnMostLeftDigit(int num)
        {
            while (num > 0)
            {
                num /= 10;
            }
            return num;
        }

        static void Main(string[] args)
        {

        }
    }
}
