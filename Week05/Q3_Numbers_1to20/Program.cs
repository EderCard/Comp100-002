using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 3.	To display the numbers 1 … 20 on separate lines
 */
namespace Q3_Numbers_1to20
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializarer
            int start = 1, end = 20;
            do
            {
                Console.WriteLine($"{start}");
                start = start + 1; //updater
            } while (start <= end); //checker
        }
    }
}
