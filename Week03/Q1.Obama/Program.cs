using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 1.	Create a program that prompts the user for her first name, middle initial and last name. 
 *      The program will display the user name three times using the following three formats: 
 *      first name and last name
 *      first name middle initial and last name
 *      last name, first name and middle initial
 *      For inputs Barack H Obama
 *      Barack Obama
 *      Barack H Obama
 *      Obama, Barack H
 *       
 * 
 *      Remember to insert the dollar symbol ($) before your double quotes in the Console.
 *      Write/WriteLine
 */
namespace Q1.Obama
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName, mName, lName;
            Console.Write("Enter your first name: ");
            fName = Console.ReadLine();
            Console.Write("Enter your midle name: ");
            mName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lName = Console.ReadLine();
            Console.WriteLine($"{fName} {lName}");
            Console.WriteLine($"{fName} {mName} {lName}");
            Console.WriteLine($"{lName}, {fName} {mName}");
        }
    }
}
