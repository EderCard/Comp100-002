using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * output the following:
 * *       *
 *  *     *
 *   *   *
 *    * *
 *     *
 *    * *
 *   *   *
 *  *     *
 * *       *
 */
namespace D10_NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 9; row++)
            {
                for (int col = 1; col <= 9; col++)
                {
                    if (row == col || row + col == 10)
                    {
                        Console.Write("*");
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
