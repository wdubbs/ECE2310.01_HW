using System;

namespace HW2_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            String N = "";
            bool negative = false;

            if (num < 0)
            {
                negative = true;
                num *= -1;
            }

            while (num > 0)
            {
                N = Convert.ToString(num % 10) + "   " + N;
                num /= 10;
            }

            if (negative)
            {
                N = "-   " + N;
            }

            Console.WriteLine(N);
        }
    }
}
