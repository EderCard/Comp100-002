using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * A confectionary store wants a program that will prompt
 * the user for the price of the candy and the amount of 
 * money she would like to spend and then calculates and 
 * display the amount of candies that can be purchased.
*/

namespace Q1_Candies
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double price;
            double budget;
            //Processing
            //Output
            double numberOfCandies;
            //Algorithm
            Console.Write("Enter the price of candie: ");
            price = Convert.ToDouble(Console.ReadLine());
            Console.Write("How much money do you have? ");
            budget = Convert.ToDouble(Console.ReadLine());
            numberOfCandies = budget / price;
            Console.WriteLine($"With {budget:C}, you can get {numberOfCandies:N0} candies");
        }
    }
}
