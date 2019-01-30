using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    3.	Write a program that prompts the user for the number of courses and residency status 
        (domestic or international) and calculates tuition cost. 
        Cost is calculated based on the table below.
            Domestic	    $325 per course
            International	$1375 per course
        You decide how you want the user to enter her/his residency status and prompt accordingly, 
        also you should use named constants for the cost per course
 */
namespace Q3_TuitionCost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"How many courses do you need? ");
            int courses = Convert.ToInt32(Console.ReadLine());
            Console.Write($"What is your residency status: (D)omestic/(I)nternational)? ");
            string status = Console.ReadLine();
            const double COST_DOMESTIC = 325;
            const double COST_INTERNATIONAL = 1375;
            double totalCost;
            switch (status)
            {
                case "D":
                    totalCost = courses * COST_DOMESTIC;
                    Console.WriteLine($"Your total cost is {totalCost:C}");
                    break;
                case "I":
                    totalCost = courses * COST_INTERNATIONAL;
                    Console.WriteLine($"Your total cost is {totalCost:C}");
                    break;
            }
        }
    }
}
