using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 3.	Write a Program to compute the average of ten numbers which will be entered by the user.
 */
namespace Q3_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1, end = 10;
            double sum = 0;

            //do
            //{
            //    Console.Write("Enter a number: ");
            //    double value = Convert.ToDouble(Console.ReadLine());
            //    sum = sum + value;
            //    start ++;
            //} while (start <= end);
            //Console.WriteLine($"Agerage is {sum / end}");

            //while (start <= end)
            //{
            //    Console.Write("Enter a number: ");
            //    double value = Convert.ToDouble(Console.ReadLine());
            //    sum = sum + value;
            //    start++;
            //}
            //Console.WriteLine($"Agerage is {sum / end}");

            for (; start <= end; start++)
            {
                Console.Write("Enter a number: ");
                double value = Convert.ToDouble(Console.ReadLine());
                sum = sum + value;
            }
            Console.WriteLine($"Agerage is {sum / end}");

        }
    }
}
