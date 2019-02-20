using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 7.	Write a program to produce a table of numbers from 10 to 1, with their squares and cubes. 
 *      Again, your table must look professional!
 */
namespace Q7_Table2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    Number     Square       Cube");
            Console.WriteLine("--------------------------------");

            //int start = 10, end = 1;
            //while (start >= end)
            //{
            //    Console.WriteLine($"{start,10} {start * start,10} {start * start * start,10}");
            //    start--;
            //}

            for (int start = 10, end = 1; start >= end; start--)
            {
                Console.WriteLine($"{start,10} {start * start,10} {start * start * start,10}");
            }

            Console.WriteLine("--------------------------------");
        }
    }
}
