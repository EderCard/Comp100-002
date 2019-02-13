using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * ==================      Test #1 Winter 2019      ==================
 * 
 * Name: Ederson Cardoso
 * Student ID: 301033332
 *
 * Question 5a.
 * 12 Marks.
 *
 * Write a program that prompts the user for her home planet. Based on the
 * user's input the program will display the following:
 * 
 * Input: earth
 * Message: earth. You are an Earthling and you have 10 fingers
 * 
 * Input: VENUS
 * Message: VENUS. You are a Venusian and you have 12 fingers
 * 
 * Input: Mars
 * Message: Mars. You are a Martian and you have 8 fingers
 * 
 * any other input
 * Message: I am sorry I don't know of that planet
 * 
 * You may use either the ToUpper() or ToLower() methods 
 * 
 * You MUST USE A NESTED IF statement to solve this problem
 * [For full marks you need to accept all permutations of earth, venus 
 * and mars]
 * 
 * [Solution: Question5A]
 */
 namespace Q5_PlanetIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your home planet? ");
            string planet = Console.ReadLine();
            string planetL = planet.ToLower();
            if (planetL == "earth")
            {
                Console.WriteLine($"{planet}. You are an Earthling and you have 10 fingers");
            }
            else if (planetL == "venus")
            {
                Console.WriteLine($"{planet}. You are a Venusian and you have 12 fingers");
            }
            else if (planetL == "mars")
            {
                Console.WriteLine($"{planet}. You are a Martian and you have 8 fingers");
            }
            else
            {
                Console.WriteLine($"I am sorry I don't know of that planet");
            }
        }
    }
}
