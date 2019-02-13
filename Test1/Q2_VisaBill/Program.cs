using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * ==================      Test #1 Winter 2019      ==================
 * 
 * Name: Ederson Cardoso
 * Student ID: 301033332
 *
 * Question 2a.
 * 12 Marks.
 *
 * Write a program that prompts the user for his name and average monthly 
 * visa bill. The program displays his name and his annual visa bill. You 
 * must match the format exactly.
 * 
 * Hint: annual bill = monthly bill * 12
 * [Solution: Question2A]
 */
namespace Q2_VisaBill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your average monthly bill: ");
            double bill = Convert.ToDouble(Console.ReadLine());
            double annualBill = 12 * bill;
            Console.WriteLine($"Hi {name} I have estimated your annual visa bill to be {annualBill:C}");
        }
    }
}
