using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 5.	To display the numbers 10 … 40 on separate lines with an asterisk before each multiples of 7. 
 *      (asterisk besides multiples)
 */
namespace Q5_Numbers_10to40_m7
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializarer
            int start = 10, end = 40;
            do
            {
                if (start % 7 == 0)
                {
                    Console.WriteLine($"*{start}");
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
