using System;

namespace HW3_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 1;
            while (!(selection > 3) && !(selection < 1))
            {
                Console.WriteLine("Please enter the number of the shape you wish to calculate the area/volume of: \n1.Circle\n2.Rectangle\n3.Cylinder\nInput any other value to quit");

                if(!Int32.TryParse(Console.ReadLine(),out selection))
                {
                    selection = 0;
                }

                if (selection == 1)
                {
                    Console.Write("Please enter radius: ");
                    Double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The area of your circle is: " + Math.Round(Math.PI * Math.Pow(radius,2),3) + "\n");
                }
                else if (selection == 2)
                {
                    Console.Write("Please enter height: ");
                    Double height = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter width: ");
                    Double width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The area of your square is: " + Math.Round(height*width,3) + "\n");
                }
                else if (selection == 3)
                {
                    Console.Write("Please enter radius: ");
                    Double radius = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter height: ");
                    Double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The volume of your cylinder is: " + Math.Round(Math.PI * Math.Pow(radius, 2)*height,3) +"\n");
                }
            }
            

        }
    }
}
