using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 6.	Write a program to produce a table of the numbers 0 through 20 in increments of 2, with their squares and cubes. 
 *      Your table must look professional!
 */
namespace Q6_Table2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    Number     Square       Cube");
            Console.WriteLine("--------------------------------");

            //int start = 0, end = 20, i = 2;
            //do
            //{
            //    Console.WriteLine($"{start,10} {start * start,10} {start * start * start,10}");
            //    start += i;
            //} while (start <= end);

            //int start = 0, end = 20, i = 2;
            //while (start <= end)
            //{
            //    Console.WriteLine($"{start,10} {start * start,10} {start * start * start,10}");
            //    start += i;
            //}

            for (int start = 0, end = 20, i = 2; start <= end; start += i)
            {
                Console.WriteLine($"{start,10} {start * start,10} {start * start * start,10}");
            }

            Console.WriteLine("--------------------------------");
        }
    }
}
