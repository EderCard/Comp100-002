using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * =========================      Test #1 Fall 2018      =========================
 * 
 * Name:
 * Student ID:
 *
 * Question 3.
 * 14 Marks.
 *
 * Write a program that prompt the user for a single integer. 
 * The program will display if the number is a multiple of
 * 2 or 3 or both or neither 2 nor 3. Use the modulus (%) to check
 * for divisibility
 * 
 * You must use an if statement for this solution
 * 
 * [Solution: Question3.exe]
 */
namespace Q3_Multiplus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int value = Convert.ToInt32(Console.ReadLine());
            if (value % 2 == 0 && value % 3 == 0)
            {
                Console.WriteLine($"{value} is disible by both 2 and 3");
            }
            else if (value % 2 == 0)
            {
                Console.WriteLine($"{value} is disible only by 2");
            }
            else if (value % 3 == 0)
            {
                Console.WriteLine($"{value} is disible only by 3");
            }
            else
            {
                Console.WriteLine($"{value} is disible neither by 2 nor by 3");
            }

        } 
    }
}