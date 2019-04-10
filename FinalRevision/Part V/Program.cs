using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_V
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {5, 12, 8, 5, 7, 3, 5, 6, 9, 10, 16, 8, 11, 34, 9, 50, 12, 14, 45};

            #region Call Question 1
            //DisplayIntArray(numbers);
            #endregion

            #region Call Question 2
            //int[] a = GenerateRandomIntArray(15, 10);
            //DisplayIntArray(a);
            //Console.WriteLine();

            //int[] b = GenerateRandomIntArray(25, 10);
            //DisplayIntArray(b);
            //Console.WriteLine();

            //int[] c = GenerateRandomIntArray(30, 100);
            //DisplayIntArray(c);
            //Console.WriteLine();
            #endregion

            #region Call Question 3
            //int[] arrayIntergers = GenerateRandomIntArray(10, 100);
            //DisplayIntArray(arrayIntergers);
            //Console.WriteLine();

            //DisplayIntArray(CountEvenOdd(arrayIntergers));
            //Console.WriteLine();
            #endregion

            #region Call Question 4
            //int numberOfValues = 15;
            //int[] arrayIntergers = GenerateRandomIntArray(numberOfValues, 9);
            //DisplayIntArray(arrayIntergers);
            //Console.WriteLine();

            //int[] result = CalculateDigitFrequencies(arrayIntergers);
            //DisplayIntArray(result);
            //Console.WriteLine();
            #endregion

            #region Call Question 5
            //int numberOfValues = 15;
            //int[] arrayIntergers = GenerateRandomIntArray(numberOfValues, 100);
            //DisplayIntArray(arrayIntergers);
            //Console.WriteLine();

            //int[] result = CalculateLastDigitFrequencies(arrayIntergers);
            //DisplayIntArray(result);
            //Console.WriteLine();
            #endregion

            #region Call Question 6
            int numberOfValues = 15;
            int[] arrayIntergers = GenerateRandomIntArray(numberOfValues, 99);
            DisplayIntArray(arrayIntergers);
            Console.WriteLine();

            int[] result = CalculateNumberFrequencies(arrayIntergers);
            DisplayIntArray(result);
            Console.WriteLine();
            #endregion
        }
        #region Question 1
        /*
         *1.	Write a method with header static void DisplayIntArray(int[] numbers). 
         *      The first argument is an array of ints. There is no return value. 
         *      
         *      This method displays all the elements of the argument on a single line. Each item will occupy three columns.
         *      
         *      Call this method from main with a suitable argument.
         */
        static void DisplayIntArray(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write($"{number,3}");
            }
        }
        #endregion

        #region Question 2
        /*
         *2.	Write a method with header static int[] GenerateRandomIntArray(int numberOfItems, int largestValue). 
         *      
         *      The first argument is an int indicating the number of elements that will be present in the return array. 
         *      The second argument is an int representing the largest item in the array. 
         *      The returned value is an array of integers. 
         *      
         *      This method does the following:
         *      a.	Declare and initialized a variable of type Random (Random generator = new Random();)
         *      b.	Declare an array of type int (you may call it result)
         *      c.	Allocate storage for the correct number of items
         *      d.	Using your favorite looping statement, assign a random integer to each element of the 
         *      array (result[i] = generator.Next(largestValue);)
         *      
         *      In your main method, call the above method three times with arguments 
         *      15, 10 and 25, 10 and 30, 100. 
         *      
         *      In each case assignment the results to a suitable variable and use the DisplayIntArray() method to display the value.
         */
        static int[] GenerateRandomIntArray(int numberOfItems, int largestValue)
        {
            Random generator = new Random();

            int[] result = new int[numberOfItems];

            for (int i = 0; i < numberOfItems; i++)
            {
                result[i] = generator.Next(largestValue); 
            }
            return result;
        }
        #endregion

        #region Question 3
        /*
         *3.	Write a method with header static int[] CountEvenOdd(int[] array). 
         *      The argument is an int array. The returned value is an array of 2 integers. 
         *      The elements of the return array will be a count of the odd and even items in the argument. 
         *      The first element of the returned array represents the number of odds in the argument 
         *      and the second element indicates the number of evens in the argument.
         *      
         *      The method will create an int array of 2 elements (call this the result). 
         *      Each item of the argument is examined and the appropriate element of the result array is incremented. 
         *      
         *      In your main method, call the GenerateRandomIntArray() method to create an int array using and assign
         *      it to a suitable variable. 
         *      Using the DisplayIntArray() method display all the item of the return. 
         *      
         *      Call the CountEvenOdd() method passing the above array as an argument and display the return value. 
         *      Do a count to verify that your method is working correctly.
         */
        static int[] CountEvenOdd(int[] array)
        {
            int[] result = new int[2];

            int even = 0, odd = 0;

            for (int counter = 0; counter < array.Length; counter++)
            {
                if (array[counter] % 2 == 0)
                {
                    even++;
                }
                else odd++;
            }

            result[0] = odd;
            result[1] = even;

            return result;
        }
        #endregion

        #region Question 4
        /*
         *4.	Write a method with header static int[] CalculateDigitFrequencies(int[] array). 
         *      The argument is an int array with values ranging from 0 to 9. 
         *      The returned value is an array of 10 integers. 
         *      The elements of the return array will be a count of the frequencies of the items in the argument. 
         *      The first element of the returned array represents the number of 0’s in the argument, 
         *      the second element indicates the number of 1’s in the argument and 
         *      the third element will indicate the number of 2’s in the argument.
         *      
         *      The method will create an int array of 10 elements (call this the result). 
         *      
         *      Each item of the argument is examined and the appropriate element of the result array is incremented. 
         *      In your main method, create an int array using the GenerateRandomIntArray() method 
         *      remember to use 10 as the second argument to the method and then print out the elements 
         *      using the DisplayIntArray() method. 
         *      
         *      Call the above method and display the return value. 
         *      Do a count to verify that your method is working correctly.
         */
        static int[] CalculateDigitFrequencies(int[] array)
        {
            int[] result = new int[10];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (array[i] == j)
            //        {
            //            result[j]++;
            //        }
            //    }
            //}

            foreach (int item in array)
            {
                result[item]++;
            }

            return result;
        }
        #endregion

        #region Question 5
        /*
         *5.	Write a method with header static int[] CalculateLastDigitFrequencies(int[] array). 
         *      The argument is an int array. 
         *      The returned value is an array of 10 integers. 
         *      The elements of the return array will be a count of the frequencies of the items in the argument. 
         *      The first element of the returned array represents the number with last digit of 0’s in the argument, 
         *      the second element indicates the number with last digit of 1’s in the argument and 
         *      the third element will indicate the number with last digit of 2’s in the argument.
         *      
         *      The method will create an int array of 10 elements (call this the result). 
         *      Each item of the argument is examined and the appropriate element of the result array is incremented.
         *      
         *      In your main method, create an int array using the GenerateRandomIntArray() method and then print out 
         *      the elements using the DisplayIntArray() method. 
         *      Call the above method and display the return value. 
         *      Do a count to verify that your method is working correctly.
         */
        static int[] CalculateLastDigitFrequencies(int[] array)
        {
            int[] result = new int[10];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if ((array[i] % 10) == j)
            //        {
            //            result[j]++;
            //        }
            //    }
            //}

            foreach (int item in array)
            {
                result[item % 10]++;
            }

            return result;
        }
        #endregion

        #region Question 6
        /*
         *6.	Write a method with header static int[] CalculateNumberFrequencies(int[] array). 
         *      The argument is an int array with values ranging from 0 to 99. 
         *      The returned value is an array of 10 integers. 
         *      The first element will indicate the number or unit values in the argument (i.e. values 0-9), 
         *      the second element will indicate the number of 10 values (i.e. values 10-19), 
         *      the third element will indicate the number of 20 values (i.e. values 20-29) etc.
         *      
         *      The method will create an int array of 10 elements (call this the result). 
         *      Each item of the argument is examined and the appropriate element of the result array is incremented. 
         *      
         *      In your main method, create an int array using the GenerateRandomIntArray() method and then print out
         *      the elements using the DisplayIntArray() method. 
         *      Call the above method and display the return value. 
         *      Do a count to verify that your method is working correctly.
         */
        static int[] CalculateNumberFrequencies(int[] array)
        {
            int[] result = new int[10];
                    //Array.Sort(array);
                    //DisplayIntArray(array);
                    //Console.WriteLine();

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        if ((array[j] >= (i * 10)) && (array[j] <= (i * 10 + 9)))
            //        {
            //            result[i]++;
            //        }
            //    }
            //}

            foreach (int item in array)
            {
                result[item / 10]++;
            }

            return result;
        }
        #endregion
    }
}
