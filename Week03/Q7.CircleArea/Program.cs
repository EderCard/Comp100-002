using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 7.	Write a program to calculate the area of a circle. 
 *      The user will enter the radius of the circle and the program will calculate and display 
 *      the area according to the formula (area = 3.14 * radius * radius). 
 *      You must accept fractions as the input. 
 *      If the user enters 1.2 for the radius then the area will be 4.52. . 
 *      (Use the "F" format-specifier for floating point values).
 * 
 *      Use the Convert.ToDouble() method to obtain a double from an input.
 */
namespace Q7.CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area;
            Console.Write("Enter the radius of a circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = 3.14 * radius * radius;
            Console.WriteLine($"The circle area is {area:F4}");
        }
    }
}
