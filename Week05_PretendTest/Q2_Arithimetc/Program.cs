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
 * Question 2.
 * 16 Marks.
 *
 * Write a program that prompt the user for two numbers and a letter. 
 * If the letter is a "+" then it display the message 
 * "The sum of 5 and 2 is 7" otherwise it displays the 
 * message "The difference between 5 and 2 is 3"
 * 
 * [Solution: Question2.exe]
 */
namespace Q2_Arithimect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int N1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int N2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a letter for the operation: ");
            string operation = Console.ReadLine();
            if (operation == "+")
                {
                    Console.WriteLine($"The sum of {N1} and {N2} is {N1 + N2}");
                }
            else
                {
                    Console.WriteLine($"The difference between {N1} and {N2} is {N1 - N2}");
                }           
        }
    }
}