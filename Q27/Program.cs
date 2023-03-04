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
            while (num > 10)
            {
                num /= 10;
            }
            return num % 10;
        }
        static bool IsSpecial(int[] arr)
        {
            bool check = false;
            for (int i = 1; i < arr.Length; i++)
            {
                check = arr[i - 1] % 10 == ReturnMostLeftDigit(arr[i]);
            }
            return check;
        }
        static void Main(string[] args)
        {
            int[] arr = { 544, 41, 1, 1462, 243, 320 };
            if (IsSpecial(arr))
            {
                Console.WriteLine("the array is special");
            }
            else
            {
                Console.WriteLine("the array is not special");
            }
        }
    }
}
