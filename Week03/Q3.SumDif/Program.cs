using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * 3.	Write a program that prompts the user for two integers. 
        The program will display the result of summing and finding the difference. 
        (If the user enters 8 and 3, the display should be 8 + 3 = 11 and 8 – 3 = 5).
        
        Use the Convert.ToInt32() method to obtain an int from an input.
 */
namespace Q3.SumDif
{
    class Program
    {
        static void Main(string[] args)
        {
            int Factor1, Factor2, Sum, Dif; 
            Console.Write("Enter the first integer number: ");
            Factor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second integer number: ");
            Factor2 = Convert.ToInt32(Console.ReadLine());
            Sum = Factor1 + Factor2;
            Dif = Factor1 - Factor2;
            Console.WriteLine($"{Factor1} + {Factor2} = {Sum}");
            Console.WriteLine($"{Factor1} - {Factor2} = {Dif}");
        }
    }
}
