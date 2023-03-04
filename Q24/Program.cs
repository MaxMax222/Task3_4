using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q24
{
    class Program
    {
        static void PrintArr(int[] arr)
        {
            Console.Write(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write($", {arr[i]}");
            }
            Console.WriteLine("\n");
        }
        static bool IsPreviousSmaller(int currentIndex, int PrevIndex)
        {
            return PrevIndex > currentIndex;
        }
        static void PrintSmallerIndex(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (IsPreviousSmaller(arr[i], arr[i - 1]))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n");
        }
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(11);
            }
            PrintArr(arr);
            PrintSmallerIndex(arr);
        }
    }
}
