using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 5.	Write an application that asks a user to enter an IQ score. 
 *      If the score is a number less than 0 or greater than 200, issue an error message; 
 *      otherwise, issue an “above average”, “average”, or “below average” message for scores over, 
 *      at, or under 100, respectively
 */
namespace Q9_IQScore_Nested
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the IQ score: ");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score <= 0 || score > 200)
            {
                Console.WriteLine($"ERROR: Your score is out of range");
            }
            else if (score > 0)
                {
                    if (score < 100)
                    {
                    Console.WriteLine($"Your score is below avarage");
                    }
                }
            
            if (score == 100)
            {
                Console.WriteLine($"Your score is in avarage");
            }
            else if (score > 100)
            {
                if (score <= 200)
                {
                    Console.WriteLine($"Your score is above average");
                }
            }
            
        }
    }
}
