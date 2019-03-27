using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            string[] names = { "Bart", "Arya", "Curt", "Eden", "Fred", "Gina", "Jack", "Kate" };

            char[] pets = "dog cat hamster parrot buggie spider rabbit snake".ToCharArray();

            #region Demo 1 Tester
            //Console.WriteLine("\n\nOriginal");
            //PrintStringArray(names);

            //Console.WriteLine("\n\nReversed");
            //Array.Reverse(names);
            //PrintStringArray(names);

            //Console.WriteLine("\n\nSorted");
            //Array.Sort(names);
            //PrintStringArray(names);

            //string toFind = "Bart";
            //Console.WriteLine($"\n\nSearching for {toFind}");
            //int position = Array.BinarySearch(names, toFind);
            //Console.WriteLine($"{toFind} was located at {position}");
            #endregion

            #region Demo 2 Tester
            //Console.WriteLine("\n\nOriginal");
            //PrintCharArray(pets);

            //Console.WriteLine("\n\nReversed");
            //Array.Reverse(pets);
            //PrintCharArray(pets);

            //Console.WriteLine("\n\nSorted");
            //Array.Sort(pets);
            //PrintCharArray(pets);

            //char toFind = 'a';
            //Console.WriteLine($"\n\nSearching for {toFind}");
            //int position = Array.BinarySearch(pets, toFind);
            //Console.WriteLine($"{toFind} was located at {position}");
            #endregion

            #region Demo 3 Tester
            //Console.WriteLine(CreateWord(5));

            string[] sentences = CreateWordArray(6, 10);
            PrintStringArray(sentences);
            #endregion
        }
        #region Demo 1
        /*
         * Write a method that take a string array and display each
         * element on the same line seperated by a space
         * 
         * Call this method from main with an appropriate argument
         */
        static void PrintStringArray(string[] toPrint)
        {
            foreach (string name in toPrint)
            {
                Console.Write($"{name} ");
            }
        }
        #endregion

        #region Demo 2
        /*
         * Write a method that take a string array and display each
         * element on the same line seperated by a space
         * 
         * Call this method from main with an appropriate argument
         */
        static void PrintCharArray(char[] toPrint)
        {
            foreach (char letter in toPrint)
            {
                Console.Write($"{letter}");
            }
        }
        #endregion

        #region Demo 3
        /*
         * Write a method that take an int and returns a word
         * of that length
         */
        static string CreateWord(int numberOfLetters)
        {

            string word = "";
            for (int i = 0; i < numberOfLetters; i++)
            {
                word += (char)rand.Next('a', 'z');
            }
            return word;
        }
        /*
         * Write a method that needs two arguments and
         * returns an array of words. The first argument
         * indicates the size of each word and the second
         * argument indicates the number of word in the array.
         * 
         * YOU SHOULD USE THE PREVIOUS METHOD
         */
        static string[] CreateWordArray(int wordSize, int numberOfWords)
        {
            string[] result = new string[numberOfWords];
            for (int i = 0; i < numberOfWords; i++)
            {
                result[i] = CreateWord(wordSize);
            }
            return result;
        }
        #endregion
    }
}
