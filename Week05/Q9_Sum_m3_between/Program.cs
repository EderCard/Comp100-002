using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 9.	To display the sum of all the multiples of 3 between 1000000 and 2000000. 
 *      (Answer = 499, 999, 500, 000). If you suspect (as it is in this case) 
 *      that a value might be larger than 2billion (as is the case here) then 
 *      the type of sum should be a long and not an int. 
 *      [Hint: like the C (currency) and the F (decimal) format specifiers, 
 *      there is also a N specifier]
  */
namespace Q9_Sum_m3_between
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1000000, end = 2000000;
            long sum = 0;
            do
            {
                if (start % 3 == 0)
                {
                    //sum = sum + start;
                    sum += start;
                }
                start = start + 1; 
            } while (start <= end);
            Console.WriteLine($"The sum of multiples of 3 between 1,000,000 end 2,000,000 is: {sum:N0}");
        }
    }
}
