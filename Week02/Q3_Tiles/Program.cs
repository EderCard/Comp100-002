using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Tile Limited wants a program allows its salesclerk to enter the length and
 * width (in meters) of a rectangle and the price of a square meter of tile. 
 * The program should display the area of the rectangle and the total cost of the tile.
 */
namespace Q3_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double length;
            double width;
            double price;
            //Processing
            //Output
            double area;
            double cost;
            //Algorithm
            Console.Write("Enter the length of rectagle (m): ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width of rectagle (m): ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the price per square meter: ");
            price = Convert.ToDouble(Console.ReadLine());
            area = length * width;
            cost = area * price;
            Console.WriteLine($"The area is (m2): {area}");
            Console.WriteLine($"Total cost is: {cost:C}");

        }
    }
}
