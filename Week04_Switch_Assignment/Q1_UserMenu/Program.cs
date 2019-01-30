using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1.	Write a program that prompts the user for a menu choice. 
    The program will display a message based on the following table:
    Choice	                Message
    1	                    "Calculate area"
    2	                    "Calculate volume"
    3	                    "Calculate surface area"
    0	                    "Exit the program"
    << any other input>>	"ERROR: Invalid choice "

 */
namespace Q1_UserMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Options available are:");
            Console.WriteLine("1 . Area");
            Console.WriteLine("2 . Volume");
            Console.WriteLine("3 . Surface area");
            Console.WriteLine("0 . Exit program");
            Console.Write("Enter your option: ");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine($"Calculate area");
                    break;
                case 2:
                    Console.WriteLine($"Calculate volume");
                    break;
                case 3:
                    Console.WriteLine($"Surface area");
                    break;
                case 0:
                    Console.WriteLine($"Exit program");
                    break;
                default:
                    Console.WriteLine($"ERROR: Invalid choice ");
                    break;
             }
        }
    }
}
