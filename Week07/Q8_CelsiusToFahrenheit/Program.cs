using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 8.	Write a program that displays a conversion table from Fahrenheit to Celsius. 
 *      The program must request the starting Fahrenheit value, the ending Fahrenheit value, 
 *      and the increment. 
 *      Thus, instead of the condition checking for a fixed count, the condition checks for 
 *      the ending Fahrenheit value. 
 *      Your table must look professional!
 */
namespace Q8_CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the initial Fahrenheit: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the final Fahrenheit: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the increment: ");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"--------------------------");
            Console.WriteLine($"Fahrenheit         Celsius");
            Console.WriteLine($"--------------------------");

            //while (start <= end)
            //{
            //    double cValue = 5.0 / 9.0 * (start - 32);
            //    Console.WriteLine($"{start,10:N0} {cValue,15:N2}");
            //    start += i;
            //}

            for (; start <= end; start += i)
            {
                double cValue = 5.0 / 9.0 * (start - 32);
                Console.WriteLine($"{start,10:N0} {cValue,15:N2}");
            }

            Console.WriteLine($"--------------------------");
        }
    }
}
