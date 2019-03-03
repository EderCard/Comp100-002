using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  output the following:
 *  ********
 *  ********
 *  ********
 */
namespace D6_NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int start = 1, end = 8; start <= end; start++)
                {
                    Console.Write($"*");
                }
                Console.WriteLine();
            }
        }
    }
}
