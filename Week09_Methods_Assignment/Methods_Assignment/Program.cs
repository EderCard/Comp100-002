using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "validValue";

            while (menu != "0" )
            {
                DisplayMenu();
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "3":
                        Console.WriteLine($"The sum is: {CalculateSum(5)}");
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.Write("How many values for sum of squares? ");
                        int numberOfValues = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"The sum of squares is: {CalculateSumOfSquares(numberOfValues)}");
                        Console.WriteLine();
                        break;
                    case "5":
                        Console.WriteLine($"The sum of cubes is: {CalculateSumOfCubes()}");
                        Console.WriteLine();
                        break;
                    case "6":
                        Console.WriteLine($"The average is: {CalculateAverage()}");
                        Console.WriteLine();
                        break;
                    case "7":
                        DisplayEquation();
                        Console.WriteLine();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine($"ERROR: Invalid choice");
                        Console.WriteLine();
                        break;
                }
            } //Console.WriteLine($"ERROR: Invalid choice ");
        }
        /*
         * 1.	Write a method with the following specifications:
         *      name: DisplayMenu
         *      arguments: none
         *      return value: none
         *      tasks: display the following menu choice on the screen
         *      
         *      Calculation Menu
         *      3) Calculate Sum 
         *      4) Calculate Sum of Squares
         *      5) Calculate Sum of Cubes
         *      0) To Exit
         *         
         *      Enter the number that corresponds to your choice: 
         *      You may beautify the output to your own likings. 
         *      You don’t have to implement the functionalities of the various menu choices at this stage
         *      Call this method from your main.
         */
        static void DisplayMenu()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("      Calculation Menu");
            Console.WriteLine("******************************");
            Console.WriteLine("[ 3 ] Calculate Sum");
            Console.WriteLine("[ 4 ] Calculate Sum of Squares");
            Console.WriteLine("[ 5 ] Calculate Sum of Cubes");
            Console.WriteLine("[ 6 ] Calculate Average");
            Console.WriteLine("[ 7 ] Show Equation");
            Console.WriteLine("[ 0 ] To Exit");
            Console.WriteLine("******************************");
            Console.WriteLine();
            Console.Write("Enter the number that corresponds to your choice: ");
        }
        /*
         * 2.	Modify your main so that the above method is call repeatedly. 
         *      The program will terminate when the user enters 0. 
         *      Any other choice should produce an error message. 
         *      Because you will not be doing any arithmetic you may accept the user response either 
         *      as an int, or a char or a string.
         */

        /*
         * 3.	Write a method with the following specifications:
         *      name: CalculateSum
         *      arguments: int representing the number of inputs that will constitute the sum
         *      return value: int representing the sum of its inputs
         *      displays: only the prompt for the user inputs, but does not display the sum 
         *      tasks: prompt and accepts inputs (as many as specified by the argument), 
         *      and sum them, Finally the method will return the sum of all the inputs (the sum) 
         *
         *      In your main you will call this method when the user enters 3 in response to the menu choices. 
         *      You will invoke this method with argument 5 and then display the resulting value from the method.
         */
        static int CalculateSum(int numberOfValues)
        {
            int sum = 0;
            for (int end = numberOfValues, i = 1; i <= end; i++)
            {
                Console.Write($"Please enter value #{i}: ");
                int value = Convert.ToInt32(Console.ReadLine());
                sum += value;
            } 
            return sum;
        }
        /*
         * 4.	Write a method with the following specifications:
         *      name: CalculateSumOfSquares
         *      arguments: int representing the number of input that will constitute the sum
         *      return value: int representing the sum of the squares of its input
         *      displays: the user prompts but NOT the sum of the squares
         *      tasks: prompt the user for inputs and accumulates the sum of the squares of the input. 
         *      This is repeated as specified by the argument. Returns the final sum 
         *
         *      In your main when the user enters 4 in response to the menu choices, 
         *      you will prompt the user for the number of inputs that she will be working with. 
         *      You will invoke this method with this value and display the resulting value.
         */
        static int CalculateSumOfSquares(int numberOfValues)
        {
            int sum = 0;
            for (int end = numberOfValues, i = 1; i <= end; i++)
            {
                Console.Write($"Please enter value #{i}: ");
                int value = Convert.ToInt32(Console.ReadLine());
                sum += value * value;
            }
            return sum;
        }
        /*
         * 5.	Write a method with the following specifications:
         *      name: CalculateSumOfCubes
         *      arguments: none
         *      return value: int representing the sum of the cubes of its input
         *      displays: the user prompts but NOT the sum of the cubes 
         *      tasks: 
         *      •	prompt the user for the number of inputs that she will be working with
         *      •	Prompts the user for their input
         *      •	Accumulates the sum of the cubes input
         *      •	Repeat the above two steps are many times as required
         *      •	Returns the final sum 
         *      
         *      In your main when the user enters 5 in response to the menu choices, 
         *      you will invoke this method and display the resulting value.
         */
        static int CalculateSumOfCubes()
        {
            Console.Write("How many values for sum of cubes? ");
            int numberOfValues = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int end = numberOfValues, i = 1; i <= end; i++)
            {
                Console.Write($"Please enter value #{i}: ");
                int value = Convert.ToInt32(Console.ReadLine());
                sum += value * value * value;

            }
            return sum;
        }
        /*
         * 6.	Write a method with the following specifications:
         *      name: CalculateAverage
         *      arguments: none
         *      return value: double representing the mathematical average of its inputs
         *      displays: the user prompts but NOT the average
         *      tasks: prompt the user for the number of inputs that she will be working with. 
         *      Prompts the user for the required number of inputs. 
         *      Calculate and return the average of the inputs. 
         *
         *      Modify your DisplayMenu method by adding another choice below CalculateSumOfCubes. 
         *      In your main when the user enters the appropriate choice in response to the menu choices, 
         *      you will invoke this method and display the resulting value.
         */
        static double CalculateAverage()
        {
            Console.Write("How many values for average? ");
            int numberOfValues = Convert.ToInt32(Console.ReadLine());

            double sum = 0;
            for (int end = numberOfValues, i = 1; i <= end; i++)
            {
                Console.Write("Enter a number: ");
                double value = Convert.ToDouble(Console.ReadLine());
                sum += value;
            }
            double average = sum / numberOfValues;
            return average;
        }
        /*
         * 7.	Write a method with the following specifications:
         *      name: DisplayEquation
         *      arguments: none
         *      return value: nothing
         *      displays: the following table:
         *
         *       x     5     3x   -2x^2  y
         *       0.0   5.0   0.0   0.0   5.0
         *       0.3   5.0   0.8  -0.1   5.6
         *       0.5   5.0   1.5  -0.5   6.0
         *       0.8   5.0   2.3  -1.1   6.1
         *       1.0   5.0   3.0  -2.0   6.0
         *       1.3   5.0   3.8  -3.1   5.6
         *       1.5   5.0   4.5  -4.5   5.0
         *       1.8   5.0   5.3  -6.1   4.1
         *       2.0   5.0   6.0  -8.0   3.0
         *
         *      This table is calculated using the quadratic equation y = 5 + 3x -2x2
         *      The value of x starts at 0 and moves in increments of 0.25 to 2.0. 
         *      (The first column is misleading because the last digit is rounded up 
         *      i.e. 0.25 is displayed as 0.3 and. 0.75 is displayed as 0.8)
         *
         *      Modify your DisplayMenu method by adding another choice below the last item. 
         *      In your main when the user enters the appropriate choice in response to the menu choices, 
         *      you will invoke this method and to display the above values
         */
        static void DisplayEquation()
        {
            Console.WriteLine("x      5      3x    -2x^2   y");
            for (double x = 0; x <= 2; x += 0.25)
            {
                double col1 = x;
                double col2 = 5;
                double col3 = 3 * x;
                double col4 = -2 * x * x;
                double col5 = 5 + 3 * x - 2 * x * x;
                Console.WriteLine($"{col1,3:N1}   {col2,4:N1}   {col3,4:N1}   {col4,4:N1}   {col5,4:N1}");
            }
        }
    }
}
