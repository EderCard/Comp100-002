using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 1.	Write a console-based program that prompts the user for an hourly pay rate. 
 *      If the value entered is less than $7.50, display an error message
 */
namespace Q1_HourlyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your hourly pay rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            if (rate < 7.5)
            {
                Console.WriteLine($"ERROR: {rate} is too low");
            }
        }
    }
}
