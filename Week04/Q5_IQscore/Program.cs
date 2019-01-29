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
namespace Q5_IQscore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ënter the IQ score: ");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score <= 0 || score > 200)
            {
                Console.WriteLine($"ERROR: Your score is out of range");
            }
            else if (score < 100)
            {
                Console.WriteLine($"Your score is below average");
            }
            else if (score == 100)
            {
                Console.WriteLine($"Your score is in average");
            }
            else if (score > 100)
            {
                Console.WriteLine($"Your score is above average");
            }
        }
    }
}
