using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * ==================      Test #1 Winter 2019      ==================
 * 
 * Name: Ederon Cardoso
 * Student ID: 301033332
 *
 * Question 3a.
 * 6 Marks.
 *
 * Write a program that prompts the user for a letter. The program prints
 * the letter and the number equivalent. The number equivalent is obtained
 * by casting the char to an int. You must match the format exactly.
 * 
 * YOU MUST READ IN THE INPUT AS A CHAR and you MUST do an explicit cast
 * [Solution: Question3A]
 * [Hint: See Wk03_data_types.pptx slide #6 and #8]
 */
namespace Q3_LetterCast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a letter: ");
            char letter = Convert.ToChar(Console.ReadLine());
            int number = (int)letter;
            Console.WriteLine($"The letter {letter} corresponds to the number {number}");
        }
    }
}
