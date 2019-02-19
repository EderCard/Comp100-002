using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 8.	Same as the previous question but additionally displays the average of the numbers when the loop terminates. 
 *      You will need a counter but not as a loop terminator.
 */
namespace Q8_SumAverageUntil_100
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, counter = 0;
            do
            {
                Console.Write("Enter a number: ");
                double value = Convert.ToInt32(Console.ReadLine());
                sum = sum + value;
                counter++;
            } while (sum <= 100);
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {sum / counter}");

        }
    }
}
