using System;

namespace HW1_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Homework (10%): ");
            double HW = Convert.ToDouble(Console.ReadLine());
            Console.Write("Projects (25%): ");
            double Proj = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quizzes (20%): ");
            double Quiz = Convert.ToDouble(Console.ReadLine());
            Console.Write("Exams (20%): ");
            double Exam= Convert.ToDouble(Console.ReadLine());
            Console.Write("Final (25%): ");
            double Final = Convert.ToDouble(Console.ReadLine());

            double total = Math.Round( HW * .1 + Proj * .25 + Quiz * .2 + Exam * .2 + Final * .25,2);
            Console.WriteLine("Total Grade: {0}", total);
        }
    }
}
