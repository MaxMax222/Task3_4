using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q26
{
    class Program
    {
        static void UpdateGrades(double[] grades)
        {
            double grade;
            for (int i = 0; i < grades.Length; i++)
            {
                grade = grades[i] + grades[i] * 0.1;
                if (grade < 101)
                {
                    grades[i] = grade;
                }
                else
                {
                    grade -= grade - 100;
                    grades[i] = grade;
                }

            }
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
        static double[] InputGrades(int students)
        {
            double[] grades = new double[students];
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"enter the grade of the {i+1} student: ->");
                grades[i] = double.Parse(Console.ReadLine());
            }

            return grades;
        }

        static void Main(string[] args)
        {
            int students;
            double[] grades;
            Console.Write($"enter how many students in your class: ->");
            students = int.Parse(Console.ReadLine());
            grades = InputGrades(students);
            PrintArr(grades);
            UpdateGrades(grades);
            PrintArr(grades);
            
        }
    }
}
