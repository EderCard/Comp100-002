using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
4.	Write a program that prompts the user for a day of the week. 
    The program will display a message based on the following table:
    Choice	Message
    Sun	    "Home"
    Mon	    "Work"
    Tue	    "Work"
    Wed	    "Home"
    Thu	    "Work"
    Fri	    "Work"
    Sat	    "Work"
 */
namespace Q4_WeekDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 . Sunday");
            Console.WriteLine("2 . Monday");
            Console.WriteLine("3 . Tuesday");
            Console.WriteLine("4 . Wednesday");
            Console.WriteLine("5 . Thursday");
            Console.WriteLine("6 . Friday");
            Console.WriteLine("7 . Saturday");
            Console.Write("Enter a day of the week? ");
            int day = Convert.ToInt32(Console.ReadLine());
            string home = "Home";
            string work = "Work";
            switch (day)
            {
                case 1:
                case 4:
                    Console.WriteLine($"Your destination is {home}");
                    break;
                case 2:
                case 3:
                case 5:
                case 6:
                case 7:
                    Console.WriteLine($"Your destination is {work}");
                    break;
            }

        }
    }
}
