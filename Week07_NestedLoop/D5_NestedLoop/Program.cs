using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 01 02 03 04 05 06 07 08
 * 10    12 13 14 15 16 17    19
 * 20 21    23 24 25 26    28 29
 * 30 31 32    34 35    37 38 39
 * 40 41 42 43       46 47 48 49
 * 50 51 52 53       56 57 58 59
 * 60 61 62    64 65    67 68 69
 * 70 71    73 74 75 76    78 79
 * 80    82 83 84 85 86 87    89
 *    91 92 93 94 95 96 97 98
 */
namespace D5_nested_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    if (row == col || row + col == 9)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write($"{row}{col} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}