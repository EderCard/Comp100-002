using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    6.	Saturdays and Wednesdays are Narendra’s days off. 
        Write a program to prompt the user for the day of the week. 
        The program will display “Home day” or “Work day” depending on the input. 
        You and must use the following enum declaration: enum Days { Mon, Tue, Wed, Thu, Fri, Sat, Sun }
 */
namespace Q5_WeekDayEnum
{
    class Program
    {
        enum Days { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
        static void Main(string[] args)
        {
            Console.WriteLine("1 . Sun");
            Console.WriteLine("2 . Mon");
            Console.WriteLine("3 . Tue");
            Console.WriteLine("4 . Wed");
            Console.WriteLine("5 . Thu");
            Console.WriteLine("6 . Fri");
            Console.WriteLine("7 . Sat");
            Console.Write("Enter a day of the week? ");
            //int day = Convert.ToInt32(Console.ReadLine());
            string home = "Home day";
            string work = "Work day";
            int day = Days.0;
            switch (day)
            {
                case (Days.Mon):
                    Console.WriteLine($"{Days.Sun} is {work}");
                    break;
                case 2:
                    Console.WriteLine($"{Days.Mon} is {work}");
                    break;
                case 3:
                    Console.WriteLine($"{Days.Tue} is {work}");
                    break;
                case 4:
                    Console.WriteLine($"{Days.Wed} is {home}");
                    break;
                case 5:
                    Console.WriteLine($"{Days.Thu} is {work}");
                    break;
                case 6:
                    Console.WriteLine($"{Days.Fri} is {home}");
                    break;
                case 7:
                    Console.WriteLine($"{Days.Sat} is {work}");
                    break;
            }
        }
    }
}
