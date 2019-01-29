using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Write a program that prompts the user for a name , Social Insurance Number, 
 * hourly pay rate and the number of hours worked.
 * In an attractive format display all the input data as well as the following:

Gross pay is hourly pay rate times hours worked
Federal tax is 15 percent of gross pay
Provincial tax is 10 percent of gross pay
Net pay is gross minus federal and provincial taxes

Enter your name: Stephen Harper
Social Insurance Number: 123-456-789
Hourly pay rate: 11:50
Hours worked: 40

Payroll Summary for Stephen Harper
SIN: 123-456-789
You worked 40 hours at $11.50 per hour

Gross pay:                       $460.00
Federal Tax:                      $69.00
Provincial Tax:                   $46.00
----------------------------------------
Net pay:                         $345.00

 */
namespace Extra_Q2_NetPay   
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string name;
            string socialNumber;
            double hourlyPayRate;
            double hoursWorked;
            //Output
            double grossPay;
            double federalTax;
            double provincialTax;
            double netPay;
            //Processing
            //Algorithm
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Social Insurance Number: ");
            socialNumber = Console.ReadLine();
            Console.Write("Hourly pay rate: ");
            hourlyPayRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hours worked: ");
            hoursWorked = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Payroll Summary for {name}");
            Console.WriteLine($"SIN: {socialNumber}");
            Console.WriteLine($"You worked {hoursWorked} hours at {hourlyPayRate:C} per hour");
            Console.WriteLine();
            grossPay = hourlyPayRate * hoursWorked;
            federalTax = grossPay * .15;
            provincialTax = grossPay * .1;
            netPay = grossPay - federalTax - provincialTax;
            Console.WriteLine($"Gross pay:\t{grossPay,22:C}");
            Console.WriteLine($"Federal Tax:\t{federalTax,22:C}");
            Console.WriteLine($"Provincial Tax:\t{provincialTax,22:C}");
            //Console.WriteLine($"--------------------------------------");
            Console.WriteLine($"".PadRight(38,'-'));
            Console.WriteLine($"Net pay:\t{netPay,22:C}");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Another way of coding table in single WriteLine statement");
            Console.WriteLine();
            Console.WriteLine(
                "Gross pay:\t{0,22:C}\n" +
                "Federal Tax:\t{1,22:C}\n" +
                "Provincial Tax:\t{2,22:C}\n" +
                "".PadRight(38, '-') + "\n" +
                "Net pay:\t{3,22:C}\n",
                grossPay, federalTax, provincialTax, netPay);
        }
    }
}
