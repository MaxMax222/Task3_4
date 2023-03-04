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

        }
    }
}
