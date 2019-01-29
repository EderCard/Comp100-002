using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 2.	Write a console-based program that prompts a user for an hourly pay rate. 
 *      If the value entered is less than $7.50 or greater than $49.99, display an error message; 
 *      otherwise, display a message indicating that the rate is okay.
 */
namespace Q2_HourlyRateBetween
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your hourly pay rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            if (rate < 7.5 || rate > 49.55)
            {
                Console.WriteLine($"ERROR: Pay rate must be between 7.5 and 49.55");
            }
            else
            {
                Console.WriteLine($"Your pay rate is ok");
            }

        }
    }
}
