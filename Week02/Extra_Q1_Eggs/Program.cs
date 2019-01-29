using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program that declares four variables to hold the number of eggs produced in a month by each of four hens. 
 * Your program should sum the eggs, and then display the total in dozens. For example, a total of 127 eggs is 10 dozens and 7 eggs.
 */
namespace Extra_Q1_Eggs 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int hen1;
            int hen2;
            int hen3;
            int hen4;
            //Processing
            //Output
            int dozens;
            int dozensRemaining;
            //Algorithm
            Console.Write("Enter number of eggs by hen1: ");
            hen1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of eggs by hen2: ");
            hen2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of eggs by hen3: ");
            hen3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of eggs by hen4: ");
            hen4 = Convert.ToInt32(Console.ReadLine());
            dozens = (hen1 + hen2 + hen3 + hen4) / 12;
            dozensRemaining = (hen1 + hen2 + hen3 + hen4) % 12;
            Console.WriteLine($"Total of eggs is {dozens} dozens and {dozensRemaining} eggs");

        }
    }
}
