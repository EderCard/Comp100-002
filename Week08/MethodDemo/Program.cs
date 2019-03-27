using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DisplayPersonalInfo();
            //DisplayAreaOfCircle(1);
            //DisplayAreaOfCircle(10);
            Console.Write("Enter the purchase price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            double tax = CalculateTax(price);
            double cost = price + tax;
            Console.WriteLine($"Price: {price:C}, tax: {tax:C} total: {cost:C} ");
        }
        /*
         * Write a method that takes the price of an
         * article and calculates and return the tax (13%)
         * 
         * In your main method prompt the user for the 
         * price of a purchase and then display the cost
         * of that purchase.
         */
        static double CalculateTax(double price)
        {
            return 0.13 * price;
        }
        /*
         * Write a method to take the radius of a circle
         * and calculate and display the area.
         * 
         * In your main method call this method twice
         * with argument 1 and 10.
         */
        static void DisplayAreaOfCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"A circle of radius {radius:f2} will have an area of {area:f2}");
        }
        /*
         * Write a method to display your personal information
         */
        static void DisplayPersonalInfo()
        {
            Console.WriteLine("Ederson");
            Console.WriteLine("Student");
            Console.WriteLine("Centennial College");
        }
    }
}
