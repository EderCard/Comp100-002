using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 6.	To display numbers 20 … 60 on separate lines skipping the multiple of 3. 
 *      You must print a blank line for each multiple.
 */
namespace Q6_Numbers_20to60_skip_m3
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializarer
            int start = 20, end = 60;
            do
            {
                if (start % 3 == 0)
                {
                    Console.WriteLine();
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
