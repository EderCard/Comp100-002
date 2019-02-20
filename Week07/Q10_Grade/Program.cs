using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 10.	Write a C program that continuously requests a grade.
 *      If the grade is 999, the program should exit the loop and display the sum, 
 *      number of valid grades and the average of the valid grades entered. 
 *      (You must NOT display an invalid message)
 *      If the grade is less than 0 or greater than 100, your program should print 
 *      an appropriate message informing the user that an invalid grade has been entered,
 *      else the grade should be added to a total.
 *      P.S. The value 999 is use to terminate the cycle and should not be used in any of the calculation. 
 *      You must not display an “Invalid grade”
  */
namespace Q10_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            //double sum = 0, counter = 0, grade;
            //while (true)
            //{
            //    Console.Write($"Enter grade #{counter + 1}: ");
            //    grade = Convert.ToInt32(Console.ReadLine());

            //    if (grade == 999)
            //        break;

            //    if (grade < 0 || grade > 100)
            //    {
            //        Console.WriteLine("Invalid grade.");
            //    }
            //    else
            //    {
            //        sum += grade;
            //        counter++;
            //    }
            //}

            double sum = 0, counter = 0, grade;
            for (; ; counter++)
            {
                Console.Write($"Enter grade #{counter + 1}: ");
                grade = Convert.ToInt32(Console.ReadLine());

                if (grade == 999)
                    break;

                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Invalid grade.");
                    counter--;
                }
                else
                {
                    sum += grade;
                }
            }

            Console.WriteLine($"Total of {counter} grades is {sum} and average is {sum/counter}");
        }

    }
}

