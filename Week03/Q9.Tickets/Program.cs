using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 9.	Adult ticket cost $3.75 and child ticket cost $2.25. Write a program to prompt the user 
 *      for the amount of adult and child ticket that she needs. The program will display a user 
 *      friendly message of the number of tickets brought as well as the total cost. 
 *      (Use the "C" format-specifier for currency).
 */
namespace Q9.Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double adultCost = 3.75;
            double childCost = 2.25;
            double adult, child, totalTickets, totalCost;
            Console.Write("How many tickets for adult: ");
            adult = Convert.ToDouble(Console.ReadLine());
            Console.Write("How many tickets for child: ");
            child = Convert.ToDouble(Console.ReadLine());
            totalTickets = adult + child;
            totalCost = adultCost * adult + childCost * child;
            Console.WriteLine($"You will buy {totalTickets} tickets and final cost is {totalCost:C}");
        }
    }
}
