using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * When Jacob Steinberg began his trip to California, he filled his car’s tank with gas 
 * and reset his trip meter to zero. After traveling some distance (324 miles), 
 * Jacob stopped at a gas station to refuel; the gas tank required fuel (17 gallon). 
 * Create a program that Jacob can use to display his car gas mileage – the number of miles
 * his can be driven per gallon of gas. 
 */
namespace Q2_Mileage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double fuel;
            double distance;
            //Processing
            //Output
            double mileage;
            //Algorithm
            Console.Write("Enter the amount of fuel (gallon): ");
            fuel = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the distance travelled (miles): ");
            distance = Convert.ToDouble(Console.ReadLine());
            mileage = distance / fuel;
           //Console.WriteLine($"The mileage of yor car is: {mileage}");
            Console.WriteLine("The mileage of yor car is (miles/gallon) : " + mileage);
        }
    }
}
