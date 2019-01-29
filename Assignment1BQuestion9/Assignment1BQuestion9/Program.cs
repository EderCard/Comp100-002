using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1BQuestion9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int price;
            int cashAvailable;
            //Processing
            //Output
            int amountOfCandies;
            int moneyRemaining;
            //Algorithm
            Console.WriteLine("Enter price:");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter cash available:");
            cashAvailable = Convert.ToInt32(Console.ReadLine());
            amountOfCandies = cashAvailable / price;
            Console.WriteLine(amountOfCandies);
            moneyRemaining = cashAvailable - amountOfCandies * price;
            Console.WriteLine(moneyRemaining);
        }
    }
}
