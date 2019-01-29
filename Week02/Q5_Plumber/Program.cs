using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Gerard-The Plumber bills customers by the length of the pipe as well as the number of joins that is needed. 
 * Write a program that prompts the user for the length of the pipe, the number of joins and the unit price per 
 * length and joins. 
 * The program calculates and displays the total cost of the job. You may use the inputs in checking your program.
 * (length of pipe = 4m, price per meter = $1.25, number of joins = 5, price per join = $1.20. 
 * The total cost of the job will be $11.00)
 */
namespace Q5_Plumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double length;
            double joins;
            double pricePerLength;
            double pricePerJoin;
            //Processing
            //Output
            double cost;
            //Algorithm
            Console.Write("Enter the total lenght: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the price per lenght: ");
            pricePerLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the number os joins: ");
            joins = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the price per join: ");
            pricePerJoin = Convert.ToDouble(Console.ReadLine());
            cost = length * pricePerLength + joins * pricePerJoin;
            Console.WriteLine($"Your total cost will be {cost:C}");
        }
    }
}
