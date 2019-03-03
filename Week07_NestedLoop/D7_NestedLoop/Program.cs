using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  output the following:
 *  *
 *   *
 *    *
 *     *
 *      *
 *       *
 *        *
 */
namespace D7_NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 7; row++)
            {
                for (int col = 1; col <= 7; col++)
                {
                    if (row == col)
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
