using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDiameter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int diameter;
            int price;
            //Processing
            //Output
            int circumference;
            int cost;
            //Algorithm
            Console.WriteLine("Enter diameter:");
            diameter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price:");
            price = Convert.ToInt32(Console.ReadLine());
            circumference = 3 * diameter;
            cost = circumference * price;
            Console.WriteLine(circumference);
            Console.WriteLine(cost);
        }
    }
}
