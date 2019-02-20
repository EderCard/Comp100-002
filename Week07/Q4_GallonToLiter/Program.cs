using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 4.	Write a C# program that displays a conversion table from gallons to liters. 
 *      The program should display gallons from 10 to 20 in one-gallon increments 
 *      and the corresponding liter equivalents. 
 *      Use the relationship that 1 gallon contains 3.785 liters. Your table must look professional!
 */
namespace Q4_GallonToLiter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("   Gallons     Liters");
            Console.WriteLine("---------------------");

            //int start = 10, end = 20, i = 1;
            //do
            //{
            //    double liter = start * 3.785;
            //    Console.WriteLine($"{start,10} {liter,10:N2}");
            //    start += i;
            //} while (start <= end);

            //int start = 10, end = 20, i = 1;
            //while (start <= end)
            //{
            //    double liter = start * 3.785;
            //    Console.WriteLine($"{start,10} {liter,10:N2}");
            //    start += i;
            //}

            for (int start = 10, end = 20, i = 1; start <= end; start += i)
            {
                double liter = start * 3.785;
                Console.WriteLine($"{start,10} {liter,10:N2}");
            }

            Console.WriteLine("---------------------");
        }
    }
}
