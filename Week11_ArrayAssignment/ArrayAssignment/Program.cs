using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();

            #region Call Question 1
            //PrintCharArray(letters);
            #endregion

            #region Call Question 2
            //PrintIntArray(numbers);
            #endregion

            #region Call Question 3
            //PrintStringArray(poem);
            #endregion

            #region Call Question 4
            //Console.WriteLine("\n\nOriginal");
            //PrintCharArray(letters);
            //Console.WriteLine("\n\nReversed");
            //Array.Reverse(letters);
            //PrintCharArray(letters);
            #endregion

            #region Call Question 5
            //Console.WriteLine("\n\nOriginal");
            //PrintStringArray(poem);
            //Console.WriteLine("\n\nSorted");
            //Array.Sort(poem);
            //PrintStringArray(poem);
            #endregion

            #region Call Question 6
            //Console.WriteLine("\n\nOriginal");
            //PrintIntArray(numbers);
            //Console.WriteLine($"\n\nSearching for 3");
            //int position = Array.BinarySearch(numbers, 1);
            //Console.WriteLine($"Number 3 was located at position {position}");

            //Array.Sort(numbers);
            //Console.WriteLine("\n\nSorted");
            //PrintIntArray(numbers);
            //Console.WriteLine($"\n\nSearching for 3");
            //position = Array.BinarySearch(numbers, 3);
            //Console.WriteLine($"Number 3 was located at position {position}");
            #endregion

            #region Call Question 7
            //Console.Write("How many values? ");
            //int numberOfValues = Convert.ToInt32(Console.ReadLine());

            //int[] array = CreateIntArray(numberOfValues);
            //PrintIntArray(array);
            #endregion

            #region Call Question 8
            //Console.Write("How many values? ");
            //int numberOfValues = Convert.ToInt32(Console.ReadLine());

            //int[] array = CreateIntRandomArray(numberOfValues);
            //PrintIntArray(array);
            #endregion

            #region Call Question 9
            //Console.Write("How many values? ");
            //int numberOfValues = Convert.ToInt32(Console.ReadLine());

            //char[] array = CreateCharRandomArray(numberOfValues);
            //PrintCharArray(array);
            #endregion
        }
        #region Question 1 - Char
        /*
         * 1.	Write a method that takes an argument (a char array) and print each item on a 
         *      single line separated by a space. 
         *      
         *      From your main, call this method with letters as argument
         */
        static void PrintCharArray(char[] toPrint)
        {
            foreach (char letter in toPrint)
            {
                Console.Write($"{letter} ");
            }
        }
        #endregion

        #region Question 2 - Int
        /*
         * 2.	Write a method that takes an argument (an int array) and print each item on a 
         *      single line separated by a space. 
         *      
         *      From your main, call this method with numbers as argument
         */
        static void PrintIntArray(int[] toPrint)
        {
            foreach (int number in toPrint)
            {
                Console.Write($"{number} ");
            }
        }
        #endregion

        #region Question 3 - String
        /*
         * 3.	Write a method that takes an argument (a string array) and print each item on a 
         *      single line separated by a space. 
         *      
         *      From your main, call this method with poem as argument
         */
        static void PrintStringArray(string[] toPrint)
        {
            foreach (string text in toPrint)
            {
                Console.Write($"{text} ");
            }
        }
        #endregion - 

        #region Question 4
        /*
         * 4.	In your main method use the method in question 1 to display the letters array, 
         *      then use the Array.Reverse() method to reverse the letters array and then again 
         *      call the appropriate method to print it
         *      
         *      For questions 4-6 you do not need to make additional methods. You simply write 
         *      the necessary code in your Main method.
         */
        #endregion

        #region Question 5
        /*
         * 5.	In your main method use the method in question 3 to display the poem array, 
         *      then use the Array.Sort() method to sort the poem array and then again call 
         *      the appropriate method to print it
         *      
         *      For questions 4-6 you do not need to make additional methods. You simply write 
         *      the necessary code in your Main method.
         */
        #endregion

        #region Question 6
        /*
         * 6.	In your main method use the method in question 2 to display the numbers array, 
         *      then use the Array.Binarysearch() method to try to find the position of 3 in the 
         *      numbers array. 
         *      What is your answer?
         *      Now repeat the same steps after you have sorted the array and printed the sorted array
         *      
         *      For questions 4-6 you do not need to make additional methods. You simply write the 
         *      necessary code in your Main method.
         */
        #endregion

        #region Question 7
        /*
         * 7.	Write a method that creates and return an array of ints. The method takes a single 
         *      int argument that represents the how many items will be in the resulting array and 
         *      does the following:
         *      
         * •	Declare an array of the required type
         * •	Allocate memory for the intended number of items
         * •	Using any looping structure, prompt the user for a number and then assign to each element. 
         * 
         *      In your main method do the following: 
         *      (1) call this method (you will need to supply an argument), 
         *          assign the resulting value to at suitable variable and then 
         *      (2) display this variable.
         *      
         *      Because a foreach loop is readonly, you should not use it here!
         */
        static int[] CreateIntArray(int numberOfIntegers)
        {
            int[] result = new int[numberOfIntegers];

            for (int i = 0; i < numberOfIntegers; i++)
            {
                Console.Write($"Enter a number #{i+1}: ");
                int x = Convert.ToInt32(Console.ReadLine());
                result[i] = x;
            }
            return result;
        }
        #endregion

        #region Question 8
        /*
         * 8.	Write another method that creates and return an array of ints. The method takes a single argument 
         *      that represents the number of items in the resulting array and does the following:
         *      
         *  •	Declare an array of the required type
         *  •	Allocate memory for the intended number of items
         *  •	Using any looping structure, assign to each element a random integer in the range 100 to 200. 
         *  
         *      You will need the following statement in global scope.
         *      static Random rand = new Random();
         *      The following statement will give you a random letter
         *      rand.Next(100, 200);
         *      Exercise this method in a similar fashion as you did for question 7
         */
        static int[] CreateIntRandomArray(int numberOfIntegers)
        {
            int[] result = new int[numberOfIntegers];

            for (int i = 0; i < numberOfIntegers; i++)
            {
                int x = rand.Next(100, 200);
                result[i] = x;
            }
            return result;
        }
        #endregion

        #region Question 9
        /*
         * 9.	Write another method that creates and return an array of char. The method takes a single argument 
         *      that represents the number of items in the resulting array and does the following:
         *      
         * •	Declare an array of the required type
         * •	Allocate memory for the intended number of items
         * •	Using any looping structure, assign to each element a random char in the range 'A' to 'Z'. 
         *      
         *      Remember, you will need the following statement in global scope.
         *      static Random rand = new Random();
         *      The following statement will give you a random letter
         *      (char)rand.Next('A', 'Z');
         *      Exercise this method in a similar fashion as you did for question 7
         */
        static char[] CreateCharRandomArray(int numberOfChars)
        {
            char[] result = new char[numberOfChars];

            for (int i = 0; i < numberOfChars; i++)
            {
                char x = (char)rand.Next('A', 'Z');
                result[i] = x;
            }
            return result;
        }
        #endregion

    }
}
