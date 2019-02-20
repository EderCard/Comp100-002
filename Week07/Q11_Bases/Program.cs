using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 11.	Print the decimal, octal, and hexadecimal values of all characters between the start and 
 *      stop characters entered by a user. 
 *      For example, if the user enters an a and a z, the program should print all the characters 
 *      between a and z and their respective numerical values. Make sure that the second character 
 *      entered by the user occurs later in the alphabet than the first character. If it does not, 
 *      write a loop that repeatedly asks the user for a valid second character until one is entered.
 *      Your output should be formatted as shown below
 *      Letter	Decimal	Octal	Hex
 *	        a	    97	  141    61
 *	        b	    98	  142	 62
 *	        c	    99	  143	 63
 *	        d	   100	  144	 64
 *	        e	   101	  145	 65
 *  to obtain an int from a char use an explicit cast
 *  to obtain an octal from an int use Convert.ToString(«number_value», 8)
 *  to obtain a hexadecimal from an int use Convert.ToString(«number_value», 16)
 */
namespace Q11_Bases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a initial letter: ");
            char start = Convert.ToChar(Console.ReadLine());
            
            Console.Write("Enter a final letter: ");
            char end = Convert.ToChar(Console.ReadLine());

            if (end < start)
            {
                while (end < start)
                {
                    Console.Write($"Enter a final letter equal or greater than {start}: ");
                    end = Convert.ToChar(Console.ReadLine());
                }
            }

            Console.WriteLine($"---------------------------------------");
            Console.WriteLine($"Letter    Decimal      Octal        Hex");
            Console.WriteLine($"---------------------------------------");

            //while (start <= end)
            //{
            //    int number = (int)start;
            //    Console.WriteLine($"{start,6} {number,10} {Convert.ToString(number, 8),10} {Convert.ToString(number, 16),10}");
            //    start++;
            //}

            for (; start <= end; start++)
            {
                int number = (int)start;
                Console.WriteLine($"{start,6} {number,10} {Convert.ToString(number, 8),10} {Convert.ToString(number, 16),10}");

            }

            Console.WriteLine($"---------------------------------------");

        }
    }
}
