using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 2.	To display the numbers 1 … 5 on separate lines
 */
namespace Q2_Numbers_1to5
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializarer
            int start = 1, end = 6;
            do
            {
                Console.WriteLine($"{start}");
                start = start + 1; //updater
            } while (start < end); //checker
        }
    }
}
