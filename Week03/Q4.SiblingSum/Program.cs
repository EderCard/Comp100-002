using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 4.	Write a program that prompts the user for the number of siblings his has. 
 *      The program should display a message, “I have 4 siblings” (assuming that the user enters 3).
 */
namespace Q4.SiblingSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int siblings;
            Console.Write("Enter how many siblings do you have: ");
            siblings = Convert.ToInt32(Console.ReadLine()) + 1;
            Console.WriteLine($"I also have {siblings} siblings");
        }
    }
}
