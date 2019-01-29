using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int side1;
            int side2;
            int side3;
            int side4;
            //Processing
            //Output
            int perimeter;
            //Algorithm
            Console.Write("Enter the first side: ");
            side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second side: ");
            side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third side: ");
            side3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the fourth side: ");
            side4 = Convert.ToInt32(Console.ReadLine());
            perimeter = side1 + side2 + side3 + side4;
            //string interpolation
            //must start with a dollar symbol
            //variable is enclosed by a pair os braces
            Console.WriteLine($"The perimeter is {perimeter}");

        }
    }
}
