using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 6.	Write a console-based program that prompts the user for an hourly pay rate and hours worked. 
 *      Compute gross pay (hours times pay rate), withholding tax, and net pay 
 *      (gross pay minus withholding tax). 
 *      Withholding tax is computed as a percentage of gross pay based on the following:
 *      
 *      Gross Pay	            Withholding     Percentage
        Up to and including     300.00	        10%
        More than               300.00	        12%

 */
namespace Q6_GrossPay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your hourly pay rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your how many hours of work: ");
            double hoursTime = Convert.ToDouble(Console.ReadLine());
            double grossPay = rate * hoursTime;
            double withholding;
            double netPay;
            if (grossPay <= 300)
            {
                withholding = grossPay * 0.1;
             }
            else
            {
                withholding = grossPay * 0.12;
            }
            netPay = grossPay - withholding;
            Console.WriteLine($"Withholding tax {withholding:C}");
            Console.WriteLine($"Net pay {netPay:C}");

        }
    }
}
