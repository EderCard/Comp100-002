using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * =========================    Test #2 Winter 2019    =========================
 * 
 * Name: Ederson Cardoso
 * Student ID: 301033332
 *
 * Question 2g.
 * 8 Marks.
 *
 * Write a program that prints multiples of 3 in ascending order on a single 
 * line. The program prompts the user for the end value. 
 * 
 * Type of loop-> while
 * [Solution: Question2G]
 ---------------------------------------------------------------------------- */
namespace Question_2g
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter end value: ");
            int end = Convert.ToInt32(Console.ReadLine());

            int start = 3;
            while(start < end)
            {
                if (start % 3 == 0)
                {
                    Console.Write($"{start} ");
                }
                start += 1;
            } 
        }
    }
}
