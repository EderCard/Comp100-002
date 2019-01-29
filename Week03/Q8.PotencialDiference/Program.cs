using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 8.	Write a program to calculate and display the potential difference between the ends of a wire. 
 *      The program will prompt the user for the current flowing and the resistance of the wire. 
 *      (Potential difference is the product of the current and the resistance of the wire and may
 *      include a fractional part).
 */
namespace Q8.PotencialDiference
{
    class Program
    {
        static void Main(string[] args)
        {
            double currente, resistence, potDiferencial;
            Console.Write("Enter the currente: ");
            currente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the resistance: ");
            resistence = Convert.ToDouble(Console.ReadLine());
            potDiferencial = currente * resistence;
            Console.WriteLine($"The potencial difference is {potDiferencial}");

        }
    }
}
