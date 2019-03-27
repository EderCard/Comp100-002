using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * =========================    Test #2 Winter 2019  =========================
 * 
 * Name: Ederson Cardoso
 * Student ID: 301033332
 *
 * Question 1g.
 * 10 Marks.
 *
 * Write a program that displays a conversion table of cm to inches. The program
 * prompts the user for the start cm and the end cm value. The table must be in 
 * 4cm decrements. You must match the format exactly.
 * 
 * Type of loop-> do-while
 * 1 cm = 0.39 inches
 * [Solution: Question1G]
 ---------------------------------------------------------------------------- */
namespace Question_1g
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start cm value: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the end value: ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"   cm       inch");
            do
            {
                double inch = start * 0.39;
                Console.WriteLine($"{start,5:N0} {inch,10:N2}");
                start -= 4;
            }
            while (end <= start);
        }
    }
}


