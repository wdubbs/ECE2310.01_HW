using System;

namespace HW3_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while (input != "q")
            {
                Console.Write("Please enter a number grade between 0-100, q to quit: ");
                input = Console.ReadLine();

                if (input == "q")
                {
                    Console.WriteLine("Bye!");
                }

                else if(!Double.TryParse(input,out double num))
                {
                    Console.WriteLine("Error: Please enter a number\n");
                }

                else if (num < 0 || num > 100)
                {
                    Console.WriteLine("Error: Please enter a number between 0-100\n");
                }

                else
                {
                    int n = (int)num;
                    n /= 10;
                    char grade;
                    switch (n)
                    {
                        case 10:
                        case 9:
                            grade = 'A';
                            break;
                        case 8:
                            grade = 'B';
                            break;
                        case 7:
                            grade = 'C';
                            break;
                        case 6:
                            grade = 'D';
                            break;
                        default:
                            grade = 'F';
                            break;
                    }
                    Console.WriteLine(grade+"\n");
                }
            }
        }
    }
}
