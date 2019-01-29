using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 8.	Write a program that allows the user to enter two integers and a character 
 *      If the character is A, add the two integers 
 *      If it is S, subtract the second integer from the first 
 *      if it is M, multiply the integers Display the results of the arithmetic
 */
namespace Q8_Arithmetic
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
            if (operation == "A") //check for addition
            {
                Console.WriteLine($"{first} + {second} = {first + second}");
            }
            if (operation == "S") //check for subtraction
            {
                Console.WriteLine($"{first} - {second} = {first - second}");
            }
            if (operation == "M") //check for multiplication
            {
                Console.WriteLine($"{first} * {second} = {first * second}");
            }
        }
    }
}