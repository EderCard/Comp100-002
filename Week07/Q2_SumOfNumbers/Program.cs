using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 2.	Write a Program to compute the sum of eight numbers. 
 *      You will prompt the user for each number. 
 *      Your prompt should also indicate which number is currently being accepted 
 *      e.g. your prompt can be "Please enter value #5: "
 */
namespace Q2_SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int start = 0, end = 8, i = 1;
            //do
            //{
            //    Console.Write($"Please enter value #{i}: ");
            //    int value = Convert.ToInt32(Console.ReadLine());
            //    start = start + value;
            //    i++;
            //} while (i <= end);
            //Console.WriteLine($"The sum is {start} ");

            //int start = 0, end = 8, i = 1;
            //while (i <= end)
            //{
            //    Console.Write($"Please enter value #{i}: ");
            //    int value = Convert.ToInt32(Console.ReadLine());
            //    start = start + value;
            //    i++;
            //} 
            //Console.WriteLine($"The sum is {start} ");

            int start = 0;
            for (int end = 8, i = 1 ; i <= end; i++)
            {
                Console.Write($"Please enter value #{i}: ");
                int value = Convert.ToInt32(Console.ReadLine());
                start = start + value;
            }
            Console.WriteLine($"The sum is {start} ");
        }
    }
}
