using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 2.	Write a program that prompts the user for the number of siblings his has. 
 *      The program should display a message, “I also have 4 siblings”
 *      (assuming that the user enters 4).
 * 
 *      In this question, you are not doing any arithmetic so you may use string type 
 *      for the input.
 */
namespace Q2.Siblings
{
    class Program
    {
        static void Main(string[] args)
        {
            string siblings;
            Console.Write("Enter how many siblings do you have: ");
            siblings = Console.ReadLine();
            Console.WriteLine($"I also have {siblings} siblings");
        }
    }
}