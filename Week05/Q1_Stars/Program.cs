using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 1.	To display five asterisks on a single line. Each asterisk must be separated by a space. 
 *      You must use a do-while loop to solve this program
 */
namespace Q1_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializarer
            int start = 0, end = 5;
            do
            {
                Console.Write("* ");
                start = start + 1; //updater
            } while (start < end); //checker
            Console.WriteLine();
        }
    }
}
