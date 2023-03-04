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
        static bool IsSpecial(int[] arr)
        {
            bool check;
            for (int i = 1; i < arr.Length; i++)
            {
                check = arr[i - 1] % 10 == ReturnMostLeftDigit(arr[i]);
            }
            return check;
        }
        static void Main(string[] args)
        {

        }
    }
}
