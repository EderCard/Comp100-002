using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * ========================      Test #2 Winter 2019    ========================
 * 
 * Name: Ederson Cardoso
 * Student ID: 301033332
 *
 * Question 3g.
 * 10 Marks.
 *
 * Write a program that subtracts the user input from a target. When the target
 * is 0 or just becomes negative, the program prints the final target value and
 * the number of user inputs
 * 
 * Type of loop-> for
 * [Solution: Question3G]
 ---------------------------------------------------------------------------- */
namespace Question_3g
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter target value: ");
            int target = Convert.ToInt32(Console.ReadLine());
            int i = 1;
             
            for (;  target > 0 ; i++)
            {
                Console.Write($"Enter #{i}: ");
                int value = Convert.ToInt32(Console.ReadLine());
                target = target - value;
            }
            Console.WriteLine($"It took {i - 1} inputs to reduce the target to {target} ");
        }
    }
}
