using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q25
{
    class Program
    {
        static void PrintEvenOrOddIndexes(int[] arr, int digit)
        {
            if (digit % 2 == 0)
            {
                for (int i = 0; i < arr.Length; i+= 2)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            else
            {
                for (int i = 1; i < arr.Length; i+=2)
                {
                    Console.Write(arr[i] + " ");
                }
            }
           
        }
        static void PrintArr(int[] arr)
        {
            Console.Write(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write(", " + arr[i]);
            }
            Console.WriteLine("\n");
        }
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] arr = new int[30];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1000);
            }
            PrintArr(arr);
            int digit = rnd.Next(1, 11);
            Console.WriteLine("the random digit: {0}", digit);
            PrintEvenOrOddIndexes(arr, digit);
        }
    }
}
