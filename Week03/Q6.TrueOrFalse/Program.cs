using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 6.	Write a program to ask the user about the validity of a simple statement. 
 *      The program should accept the response then display the statement as well as the response. 
 *      The response should be true or false. For this question, you must use a variable of type bool.
 * 
 *      Use the Convert.ToBoolean() method to obtain a bool from an input.
 */
namespace Q6.TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bValue;
            Console.Write("Is that true or false? ");
            bValue = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"{bValue}");
        }
    }
}
