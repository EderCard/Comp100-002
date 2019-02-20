using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 1.	Write a program to print the numbers 2 to 10 in increments of two on the same line. 
 *      The output of your program should be 2 4 6 8 10 
 */
namespace Q1_Numbers2to10
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializer
            int start = 2, end = 10;
            do
            {
                Console.Write($"{start} ");
                start += 2;//updater
            } while (start <= end); //checker
            Console.WriteLine();

            //int start = 2, end = 10;
            //while (start <= 10)
            //{
            //    Console.Write($"{start} ");
            //    start += 2;
            //}
            //Console.WriteLine();

            //for (int start = 2, end = 10; start <= end; start += 2 )
            //{
            //    Console.Write($"{start} ");
            //}
            //Console.WriteLine();
        }
    }
}
