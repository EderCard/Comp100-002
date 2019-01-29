using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *10.	Write a console-based program that prompts a user for an hourly pay rate. 
 *      If the user enters values less than $7.50 or greater than $49.99, prompt the user again. 
 *      If the user enters an invalid value again, display an appropriate error message. 
 *      If the user enters a valid value on either the first or second attempt, 
 *      display the pay rate as well as the weekly rate, which is calculated as 40 times the hourly rate.  
 */
namespace Q10_HourlyRate_Nested
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your hourly pay rate: "); //TO DO*********************
            double rate = Convert.ToDouble(Console.ReadLine());
            if (rate < 7.5 || rate > 49.55)
            {
                Console.WriteLine($"ERROR: Pay rate must be between 7.5 and 49.55");
                Console.Write("Enter your hourly pay rate: ");
                double rate = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
