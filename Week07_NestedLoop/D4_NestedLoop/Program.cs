using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * output the following:
 *    01 02 03 04 05 06 07 08 09
 * 10    12 13 14 15 16 17 18 19
 * 20 21    23 24 25 26 27 28 29
 * 30 31 32    34 35 36 37 38 39
 * 40 41 42 43    45 46 47 48 49
 * 50 51 52 53 54    56 57 58 59
 * 60 61 62 63 64 65    67 68 69
 * 70 71 72 73 74 75 76    78 79
 * 80 81 82 83 84 85 86 87    89
 * 90 91 92 93 94 95 96 97 98
 */
namespace D4_nested_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    if (row == col)
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

