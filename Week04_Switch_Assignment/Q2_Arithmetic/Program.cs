using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 2.	Write a program that allows the user to enter two integers and a character 
 *      If the character is A, add the two integers 
 *      If it is S, subtract the second integer from the first 
 *      else multiply the integers 
 *      Display the results of the arithmetic
 */
namespace Q2_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Write($"What operation you would like to perform? (A/S/M): ");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "A":
                    Console.WriteLine($"{first} + {second} = {first + second}");
                    break;
                case "S":
                    Console.WriteLine($"{first} - {second} = {first - second}");
                    break;
                default:
                    Console.WriteLine($"{first} * {second} = {first * second}");
                    break;
            }
        }
    }
}
