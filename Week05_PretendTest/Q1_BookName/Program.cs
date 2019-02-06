using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * =========================      Test #1 Fall 2018      =========================
 * 
 * Name:
 * Student ID:
 *
 * Question 1.
 * 16 Marks.
 *
 * Write a program that prompts the user for the name of a book 
 * and the number of books and then displays the following: 
 * "4 copies Introduction to Programming will cost $479.96"
 * [Assuming the inputs are "Introduction to Programming" and 4]
 * 
 * The cost of a book is $119.99 and it must be declared as a named constant
 * [Solution: Question1.exe]
 */
namespace Q1_BookName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the title of the book? ");
            string title = Console.ReadLine();
            Console.Write("How many books do you like? ");
            int number = Convert.ToInt32(Console.ReadLine());
            const double COST_OF_BOOK = 119.99;
            double finalCost = number * COST_OF_BOOK;
            Console.WriteLine($"{number} copies of {title} will cost {finalCost:C}");
        }
    }
}
