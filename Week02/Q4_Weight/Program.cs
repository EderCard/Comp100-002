using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Othello’s Grocery would like a program that will prompt the user for the weight and price of the produce, 
 * the price and capacity of plastic bag and then calculates and displays the total cost of the sale. 
 * You may assume that all customers will require bags. You may use the following sample inputs 
 * (price 11₵ per kg, weight 25kg and capacity of bag is 5 (one bag is able to hold 5 kg of produce), 
 * price of a plastic bag 5₵. The total cost is 300₵)
 */
namespace Q4_Weight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double weight;
            double priceOfProduce;
            double priceOfBag;
            double capacityOfBag;
            //Processing
            //Output
            double cost;
            //Algorithm
            Console.Write("Enter the weight: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the price per kilo: ");
            priceOfProduce = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the price of bag: ");
            priceOfBag = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the capacity of bag: ");
            capacityOfBag = Convert.ToDouble(Console.ReadLine());
            cost = (weight * priceOfProduce) + (weight / capacityOfBag * priceOfBag);
            Console.WriteLine($"Total cost is {cost,10:C}");
            //{cost,10:C} ---> 10 gives the number os characters used
        }
    }
}
