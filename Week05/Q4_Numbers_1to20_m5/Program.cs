using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 4.	To display the numbers 1 … 20 on separate lines with an asterisk after each multiples of 5. 
 *      (multiples besides asterisk) 
 */
namespace Q4_Numbers_1to20_m5
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializarer
            int start = 1, end = 20;
            do
            {
                if (start % 5 == 0)
                {
                    Console.WriteLine($"{start}*");
                }
                else
                {
                    Console.WriteLine($"{start}");
                }
                start = start + 1; //updater
            } while (start <= end); //checker
        }
    }
}
