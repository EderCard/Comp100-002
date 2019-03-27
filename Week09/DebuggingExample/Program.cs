using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = CalculateSquares(3);
            Console.WriteLine($"The sum is {result}");
        }
        #region Question 1
        /*
         * Write a method so sum the square of user inputs
         * This method will take a single argument that represents the
         * number of input to work with.
         * 
         * From the main, class this method with argument 3 and display
         * the resulting value
         */
        static int CalculateSquares(int numberOfInputs)
        {
            int sum = 0, counter = 0;

            while (counter++ < numberOfInputs)
            {
                Console.Write($"Enter number {counter} of {numberOfInputs}: ");
                int input = Convert.ToInt32(Console.ReadLine());
                sum += input * input;
                //counter++;
            }
            return sum;
        }
        #endregion
    }
}
