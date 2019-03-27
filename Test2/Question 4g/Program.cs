using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * =======================      Test #2 Winter 2019      =======================
 * 
 * Name: Ederson Cardoso
 * Student ID: 301033332:
 *
 * Question 4g.
 * 12 Marks.
 *
 * Write a program that displays the table shown in the sample executable.
 * 
 * the relationship is given by the quadratic equation
 *             y = 3x^2 + x - 2
 *             
 * Type of loop-> your favorite (you MUST use a loop)
 * Hints:
 *  1) Generate the first column using a place holder (decrement = 0.15)
 *  2) Generate successive columns one at a time by adding another placeholder
 *  3) Format using column specifier (do not use tabs)
 *     
 * [Solution: Question4G]
 ---------------------------------------------------------------------------- */
namespace Question_4g
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    x    3x^2      +x      -2       y");
            Console.WriteLine(" ----    ----    ----    ----    ----");
            for (double x = 0.8; x >= -1.15; x -= 0.15)
            {
                double col1 = x;
                double col2 = 3 * x * x;
                double col3 = x;
                double col4 = -2;
                double col5= 3 * x * x + x - 2;
                Console.WriteLine($"{col1,5:N2} {col2,7:N2} {col3,7:N2} {col4,7:N2} {col5,7:N2}");
            }
        }
    }
}
