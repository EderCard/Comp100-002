using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 7.	The average cost of a college textbook is $125. 
 *      There is a premium of 20% on hardcover text and a discount of 5% on sales of more than 4 textbooks. 
 *      Write a program to prompt the user for the appropriate inputs and compute and display 
 *      the before-tax cost of the textbooks.
 *
 *       Sample calculation: 
 *       price of 10 hardcover text = 10 * 125 + premium –discount
 *       price = 1250 + 20% of 1250 – 5% of 1250
 *       price = $1437.50
 *   
 *       price of 8 softcover text = 8 * 125 –discount
 *       price = 1000  – 5% of 1000
 *       price = $950
 *
 *       price of 2 softcover text = 2 * 125
 *       price = $250
 *
 */
namespace Q7_Textbook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Do you want a Hardcover or Softcover book (H/S)? ");
            string cover = Console.ReadLine();
            Console.Write($"How many books do you need? ");
            int books = Convert.ToInt32(Console.ReadLine());
            double price = 125;
            double cost = 0;
            if (cover == "H" && books > 4) //check for hardcover
            {
                cost = books * price * 1.2 - (books * price * .05);
            }
            else if (cover == "H" && books <= 4)
            {
                cost = books * price * 1.2;
            }

            else if (cover == "S" && books > 4) //check for softcover
            {
                cost = books * price - (books * price * .05);
            }
            else if (cover == "S" && books <= 4)
            {
                cost = books * price;
            }
            Console.WriteLine($"Total cost is {cost:C}");
//using nested if
/*  
            if (cover == "H") //check for hardcover
            {
                if (books > 4)
                {
                    cost = books * price * 1.2 - (books * price * .05);
                }
                else
                {
                    cost = books * price * 1.2;
                }
            }
            if (cover == "S") //check for softcover
            {
                if (books > 4)
                {
                    cost = books * price - (books * price * .05);
                }
                else
                {
                    cost = books * price;
                }
            }
*/
        }
    }
}
