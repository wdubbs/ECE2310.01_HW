using System;

namespace HW1_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input number of miles: ");
            double mi = Convert.ToDouble(Console.ReadLine());
            double km = mi * 1.60934;
            Console.WriteLine($"{mi} miles in kilometers is: {km}");
        }
    }
}
