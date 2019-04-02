using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_II
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Call Question 1
            //DisplayHorizontalStars(0);
            //DisplayHorizontalStars(5);
            //DisplayHorizontalStars(10);
            //Console.WriteLine();
            #endregion

            #region Call Question 2
            //DisplayVerticalStars(0);
            //DisplayVerticalStars(5);
            //DisplayVerticalStars(10);
            #endregion

            #region Call Question 3
            //CalculeteSphereVolume(1);
            //CalculeteSphereVolume(2);
            //CalculeteSphereVolume(10);
            #endregion

            #region Call Question 4
            //CalculateTax(10, "on");
            //CalculateTax(1, "On");
            //CalculateTax(20, "QC");
            //CalculateTax(100, "qC");
            //CalculateTax(25, "BC");
            #endregion

            #region Call Question 5
            //ConvertCelsiusToFahrenheit(0);
            //ConvertCelsiusToFahrenheit(50);
            //ConvertCelsiusToFahrenheit(95);
            #endregion

            #region Call Question 6
            //ConvertKmToMile(10, 1, 5);
            //ConvertKmToMile(1, .5, 5);
            //ConvertKmToMile(10, 10, 5);
            #endregion

            #region Call Question 7
            //DisplaySineTable(30, .2, 15);
            #endregion

            #region Call Question 8
            //ConvertHeight(90);
            //ConvertHeight(120);
            //ConvertHeight(275);
            #endregion

        }
        #region Question 1
        /*
         *1.	Write a method called DisplayHorizontalStars(int numberOfStars). 
         *      This method will output the number of stars horizontally specified by its argument. 
         *      
         *      Call the DisplayHorizontalStars() method three times from your program Main() method, 
         *      supplying 0, 5 and 10 respectively for the number of stars. 
         */
        static void DisplayHorizontalStars(int numberOfStars)
        {
            for (int i = 1; i <= numberOfStars; i++)
            {
                Console.Write($"*");
            }
        }
        #endregion

        #region Question 2
        /*
         * 2.	Write a method similar to the one above that displays a vertical line of stars. 
         * 
         * Call this method three times with arguments 0, 5 and 10 respectively.
         */
        static void DisplayVerticalStars(int numberOfStars)
        {
            for (int i = 1; i <= numberOfStars; i++)
            {
                Console.WriteLine($"*");
            }
            Console.WriteLine();
        }
        #endregion

        #region Question 3
        /*
         * 3.	Write a method that accepts an argument of type double. The method will calculate 
         *      and display the volume of a sphere with radius specified by its argument. 
         *      [V=4/3  πr^3]. 
         *      
         *      Call this method from your main three times, with arguments 1, 2, and 10 respectively. 
         *      The answers are 4.1888, 33.5103 and 4188.7902 respectively.
         *      Use Math.PI for the value of π
         *      
         *      Use the format string “F4” to obtain four decimal places.
         */
        static void CalculeteSphereVolume(double radius)
        {
                double volume = Math.PI * radius * radius * radius * 4 / 3;
                Console.WriteLine($"A sphere of radius {radius} will have a volume of {volume:F4}");
        }
        #endregion

        #region Question 4
        /*
         * 4.	Write a method that takes two arguments: a cost price and a two-letter province code. 
         *      It will calculate and display the selling price. (If province is Ontario a tax of 13% is 
         *      added to the price, if the province is Quebec a tax of 17% is added to the cost price. 
         *      There is no tax for the rest of the provinces and territories). 
         *      
         *      In your main, call this method enough times to fully test it
         *      
         *      Use the ToUpper() or the ToLower() method to accept all permutations of the province code.
         */
        static void CalculateTax(double price, string province)
        {
            double tax = 0;

            if (province.ToUpper() == "ON")
            {
                tax = price * .13;
            }
            else if (province.ToUpper() == "QC")
            {
                tax = price * .13;
            }
                Console.WriteLine($"The tax on an item {price:C} in {province} will be {tax:C}");
        }
        #endregion

        #region Question 5
        /*
         * 5.	Write a method that takes a single argument of type double. 
         *      The will display a Celsius to Fahrenheit conversion table. 
         *      The starting temperature is indicated by the argument and it
         *      will display 10 lines in increments of 1. 
         *      [Fahrenheit = 9/5 Celsius + 32]. 
         *      
         *      In your main call this method two times, each time with a different value.
         */
        static void ConvertCelsiusToFahrenheit(double c)
        {
            for (int i = 0; i < 10; i++)
            {
                double f = (c * 9 / 5) + 32;
                Console.WriteLine($"{c} {f:N2}");
                c += 1;
            }
        }
        #endregion

        #region Question 6
        /*
         * 6.	Write a method that takes the following arguments: 
         *      a starting km value of type double, an increment size of type double 
         *      and the number of lines of type int. 
         *      Your program will create and display a kilometer to miles conversion table. 
         *      [miles = km * 0.621371]. 
         *      
         *      In your main call this method three times, each time with different values.
         */
        static void ConvertKmToMile(double km, double increment, int lines)
        {
            for (int i = 1; i <= lines; i++)
            {
                double mile = km * 0.621371;
                Console.WriteLine($"{km:N2} {mile:N2}");
                km += increment;
            }
        }
        #endregion

        #region Question 7
        /*
         * 7.	Modify the DisplaySineTable() method in the previous section 
         *      to accept the start value, the step size and number of rows as argument to the method.
         */
        static void DisplaySineTable(double angle, double increment, double lines)
        {
            for (int i = 1; i <= lines; i++)
            {
                double sinValue = Math.Sin(angle);
                Console.WriteLine($"{angle:N2} {sinValue:N2}");
                angle += increment;
            }
        }
        #endregion

        #region Question 8
        /*
         *8.	Write a method that converts a person’s height from centimeter to meters and centimeters 
         *      and display the result on the console. 
         *      
         *      In your main method, you should call this method three times with argument 90, 120 and 275. 
         *      The result is shown in the table below. You do not have to create the table below!
         *      Input	Result
         *      90cm	0m 90cm
         *      120cm	1m 20 cm
         *      275cm	2m 75cm
         */
        static void ConvertHeight(int height)
        {
            int heightMeter = height / 100;
            int heightCentimeter =  height % 100;
            Console.WriteLine($"{height}cm {heightMeter}m {heightCentimeter}cm");
        }
        #endregion
    }
}
