using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 5.	Write a program to prompt the user to enter a single character. 
 *      The program should display a message like “Your response was y”. 
 *      For this question, you must use a variable of type char.
 * 
 *      Use the Convert.ToChar() method to obtain a char from an input.
 */
namespace Q5.Char
{
    class Program
    {
        static void Main(string[] args)
        {
            char cValue;
            Console.Write("Enter a letter: ");
            cValue = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Your response was {cValue}");
        }
    }
}
