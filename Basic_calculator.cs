using System;

namespace _3_number_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string input;

            Console.WriteLine("Welcome to the program!");

            Console.Write("Please Enter Number 1: ");
            
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease Enter Number 2: ");
            
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPLease Enter Number 3: ");
            
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\t 1.Addition");
            Console.WriteLine("\t 2.Substraction");
            Console.WriteLine("\t 3.Multiplication");
            Console.WriteLine("\t 4.Division");
            Console.Write("Enter Option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("\nAnswer is: " + (num1 + num2 + num3));
                    break;

                case "2":
                    Console.WriteLine("\nAnswer is: " + (num1 - num2 - num3));
                    break;

                case "3":
                    Console.WriteLine("\nAnswer is: " + (num1 * num2 * num3));
                    break;

                case "4":
                    Console.WriteLine("\nAnswer is: " + (num1 / num2 / num3));
                    break;

                default:
                    Console.WriteLine("\n Wrong Input Please try again!");
                    break;
            }
            Console.WriteLine("Code Created By Avin");
            Console.ReadLine();
        }
    }
}
