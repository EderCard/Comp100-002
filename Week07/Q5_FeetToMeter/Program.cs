using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 5.	Write a C# program that converts feet to meters. 
 *      The program should display feet from 3 to 30 in three-foot increments and the corresponding meter equivalents.
 *      Use the relationship that 1 meter is equivalent to 3.28 feet. Your table must look professional!
 */
namespace Q5_FeetToMeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("       Feet     Meter");
            Console.WriteLine("---------------------");

            //int start = 3, end = 30, i = 3;
            //do
            //{
            //    double meter = start * 3.28;
            //    Console.WriteLine($" {start,10}{meter,10:N2}");
            //    start += i;
            //} while (start <= end);

            //int start = 3, end = 30, i = 3;
            //while (start <= end)
            //{
            //    double meter = start * 3.28;
            //    Console.WriteLine($" {start,10}{meter,10:N2}");
            //    start += i;
            //}

            for (int start = 3, end = 30, i = 3; start <= end; start += i)
            {
                double meter = start * 3.28;
                Console.WriteLine($" {start,10}{meter,10:N2}");
            }

            Console.WriteLine("---------------------");
        }
    }
}
