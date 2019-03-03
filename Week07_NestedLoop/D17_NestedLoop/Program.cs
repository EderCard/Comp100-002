using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * output the following:
 *     *
 *    ***
 *   *****
 *  *******
 * *********
 *  *******
 *   *****
 *    ***
 *     *
 */
namespace D17_NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 9; row++)
            {
                for (int col = 1; col <= 9; col++)
                {
                    if (row + col == 6 && row <= 5)
                    {
                        for (int i = 1; i <= (row * 2 - 1); i++)
                        {
                            Console.Write("*");
                        }
                    }
                    else if (row - 4 == col)
                    {
                        for (int j = 1; j <= (15 - (row + col)) ; j++)
                        {
                            Console.Write("*");
                        }
                    }
                    else
                    {
                        Console.Write($" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
