using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 10.	A conversion table of Celsius to Fahrenheit temperature. 
 *      The table must start with 100 Celsius and end at 0 Celsius with decrements of 10. 
 *      (Fahrenheit = Celsius * 9/5 + 32). 
 *      Your table must have a suitable header and the values in the table must be right-align.
 */
namespace Q10_Conversion_C_F
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"".PadRight(26, '-'));
            Console.WriteLine($"   Celsius \tFahrenheit");
            Console.WriteLine($"".PadRight(26, '-'));
            double cStart = 100, cEnd = 0, fValue = 0;
            do
            {
                fValue = (cStart * 9 / 5) + 32;
                Console.WriteLine($"{cStart,10:N0}\t{fValue,10:N0}");
                cStart = cStart - 10;
            } while (cStart >= cEnd);
            Console.WriteLine($"".PadRight(26, '-'));
        }
    }
}