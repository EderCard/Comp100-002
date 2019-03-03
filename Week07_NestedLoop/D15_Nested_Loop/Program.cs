using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * output the following:
 * ********
 *  ********
 *   ********
 *    ********
 *     ********
 */
namespace D15_Nested_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= 12; col++)
                {
                    if (row == col)
                    {
                        for (int i = 1; i <= 8; i++)
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
