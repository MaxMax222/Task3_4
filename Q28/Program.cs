using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q28
{
    class Program
    {
        static int LongestStreak(int[] arr)
        {
            int streak = 1;
            int longestStreak = streak;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i-1] == arr[i])
                {
                    streak++;
                }
                else
                {
                    if (streak > longestStreak)
                    {
                        longestStreak = streak;
                    }
                    streak = 1;
                }
            }
            return longestStreak;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 4, 4, 5, 5, 6, 2, 1, 1, 1, 1, 5, 4 };
            Console.WriteLine($"The length of the longest streak in the array: {LongestStreak(arr)}");
        }
    }
}
