using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1BQuestion10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int costPerKm;
            int distance;
            int flatFee;
            //Processing
            //Output
            int finalCost;
            //Algorithm
            Console.WriteLine("Enter cost per quilometer:");
            costPerKm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter distance:");
            distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter flat fee:");
            flatFee = Convert.ToInt32(Console.ReadLine());
            finalCost = costPerKm * distance + flatFee;
            Console.WriteLine(finalCost);

        }
    }
}
