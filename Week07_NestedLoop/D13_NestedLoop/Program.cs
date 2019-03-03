using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * output the following:
 * ******
 * ***** *
 * **** **
 * *** ***
 * ** ****
 * * *****
 *  ******
 */
namespace D13_NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 8; row++)
            {
                for (int col = 1; col <= 8; col++)
                {
                    if (row + col == 9)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write($"*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
