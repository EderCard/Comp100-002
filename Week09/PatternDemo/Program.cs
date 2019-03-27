using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 22; row++)
            {
                for (int col = 0; col < 70; col++)
                {
                    if (col % 10 == 0||row %5 == 0)
                    {
                        Console.Write("o");
                    }
                    else
                    {
                        Console.Write("+");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
