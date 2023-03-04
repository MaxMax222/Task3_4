using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q23
{
    class Program
    {
        static double GetAverege(double[] arr)
        {
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                avg += arr[i];
            }
            avg /= arr.Length;
            return avg;
        }

        static bool IsBalanced(double[] arr, double avg)
        {
            int belowAvg = 0;
            int aboveAvg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > avg)
                {
                    aboveAvg++;
                }
                else if (arr[i] < avg)
                {
                    belowAvg++;
                }
            }

            return belowAvg == aboveAvg;
        }

        static void PrintArr(double[] arr)
        {
            Console.Write(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write(", " + arr[i]);
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            double[] arr = new double[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"enter the value of the {i} index: ->");
                arr[i] = double.Parse(Console.ReadLine());
            }



            PrintArr(arr);

            Console.WriteLine($"the averege value in the array is: {GetAverege(arr)}");

            if (IsBalanced(arr, GetAverege(arr)))
            {
                Console.WriteLine("the array balanced");
            }
            else
            {
                Console.WriteLine("the array is not balanced");
            }
        }
    }
}
