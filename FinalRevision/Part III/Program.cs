using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_III
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Call Question 1
            int first, second;
            first = 3; second = 5;
            Console.WriteLine($"The difference between {first} and {second} is is {CalculateDifference(first, second)}");

            first = 5; second = 3;
            Console.WriteLine($"The difference between {first} and {second} is is {CalculateDifference(first, second)}");

            first = 13; second = 5;
            Console.WriteLine($"The difference between {first} and {second} is is {CalculateDifference(first, second)}");

            first = 23; second = 8;
            Console.WriteLine($"The difference between {first} and {second} is is {CalculateDifference(first, second)}");
            #endregion

            #region Call Question 2
            //double i, r;
            //i = 1; r = 1.5;
            //Console.WriteLine($"If current is {i:N2}A and Resistance is {r:N2}ohms then power will be {CalculatePower(i, r):N2}W");

            //i = 0.1; r = 100;
            //Console.WriteLine($"If current is {i:N2}A and Resistance is {r:N2}ohms then power will be {CalculatePower(i, r):N2}W");
            #endregion

            #region Call Question 3
            //int number;
            //double cost;

            //number = 1; cost = 500;
            //Console.WriteLine($"{number} courses @{cost:C} will cost a total of {CaculateTuitionFee(number, cost):C}");

            //number = 5; cost = 450;
            //Console.WriteLine($"{number} courses @{cost:C} will cost a total of {CaculateTuitionFee(number, cost):C}");

            //number = 5; cost = 449.99;
            //Console.WriteLine($"{number} courses @{cost:C} will cost a total of {CaculateTuitionFee(number, cost):C}");

            //number = 5; 
            //Console.WriteLine($"{number} courses @not cost supplied will cost a total of {CaculateTuitionFee(number):C}");
            #endregion

            #region Call Question 4
            //double sales;
            //sales = 900;
            //Console.WriteLine($"A sale amount of {sales:C} will yield a commission of {CalculateCommission(sales):C}");

            //sales = 1000;
            //Console.WriteLine($"A sale amount of {sales:C} will yield a commission of {CalculateCommission(sales):C}");

            //sales = 2000;
            //Console.WriteLine($"A sale amount of {sales:C} will yield a commission of {CalculateCommission(sales):C}");
            #endregion

            #region Call Question 5
            //Console.WriteLine($"First call gives {CalculateBurgers():C}");

            //Console.WriteLine($"Second call gives {CalculateBurgers():C}");
            #endregion

            #region Call Question 6
            //double earth = 5.972e+24;
            //double moon = 7.348e+22;
            //double dist = 3.844e+8;

            //Console.WriteLine($"Earth: {earth:e6}");
            //Console.WriteLine($"Moon: {moon:e6}");
            //Console.WriteLine($"Distance: {dist:e6}");
            //Console.WriteLine($"Force: {CalculateGravitationalAttraction(earth, moon, dist):e6}");
            #endregion

            #region Call Question 7
            //double a = 5.83;
            //double b = 4.24;
            //double c = 8;

            //Console.WriteLine($"a:{a:N2} b:{b:N2} c:{c:N2} area:{CalculateTriangleArea(a, b, c):N1}");
            #endregion

            #region Call Question 8
            //double value1 = 0;
            //double value2 = 50;
            //double value3 = 100;

            //Console.WriteLine($"C:{value1:N2} F:{ConvertCelsiusToFahrenheit(value1):N2}");
            //Console.WriteLine($"C:{value2:N2} F:{ConvertCelsiusToFahrenheit(value2):N2}");
            //Console.WriteLine($"C:{value3:N2} F:{ConvertCelsiusToFahrenheit(value3):N2}");
            #endregion

            #region Call Question 9
            //double value1 = 0;
            //double value2 = 32;
            //double value3 = 212;

            //Console.WriteLine($"F:{value1:N2} C:{ConvertFahrenheitToCelsius(value1):N2}");
            //Console.WriteLine($"F:{value2:N2} C:{ConvertFahrenheitToCelsius(value2):N2}");
            //Console.WriteLine($"F:{value3:N2} C:{ConvertFahrenheitToCelsius(value3):N2}");
            #endregion

            #region Call Question 10
            //double value1 = -196;
            //double value2 = 0;
            //double value3 = 100;

            //Console.WriteLine($"C:{value1:N2} K:{ConvertCelsiusToKelvin(value1):N2}");
            //Console.WriteLine($"C:{value2:N2} K:{ConvertCelsiusToKelvin(value2):N2}");
            //Console.WriteLine($"C:{value3:N2} K:{ConvertCelsiusToKelvin(value3):N2}");
            #endregion

            #region Call Question 11
            //double value1 = -196;
            //double value2 = 0;
            //double value3 = 100;

            //Console.WriteLine($"F:{value1:N2} K:{ConvertFahrenheitToKelvin(value1):N2}");
            //Console.WriteLine($"F:{value2:N2} K:{ConvertFahrenheitToKelvin(value2):N2}");
            //Console.WriteLine($"F:{value3:N2} K:{ConvertFahrenheitToKelvin(value3):N2}");
            #endregion

            #region Call Question 12
            //Console.Write($"Enter a number: ");
            //int value = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Original number: {value}, after cubing the square: {Cube(Square(value))} ");   
            #endregion
        }
        #region Question 1
        /*
         *1.	Write a method called CaculateDifference(int firstNumber, int secondNumber). 
         *      This method will calculate and return the difference between the two numbers 
         *      
         *      i.e. it will subtract the smaller one from the larger one and then return that value. 
         *
         *      Call the CaculateDifference() method four times from your program Main() method supplying
         *      different arguments each time. 
         *      You must display the returned value for each call.
         *      
         *      To use the result of a method call, you must assign it to a suitable variable. 
         *      If you simply want to see the value, then use Console.Write().the method call
         *      In this part all the output are done in the Main() method 
         *      
         *      i.e. none of the methods should have any Console.Write or Console.WriteLine 
         *      unless you need to prompt for input
         *
         */
        static int CalculateDifference(int firstNumber, int secondNumber)
        {
            int larger = firstNumber, smaller = secondNumber;
            
            if (secondNumber > firstNumber)
            {
                larger = secondNumber;
                smaller = firstNumber;
            }
            int difference = larger - smaller;
            return difference;
         }
        #endregion

        #region Question 2
        /*
         *2.	Write a method called CalculatePower(double current, double resistance). 
         *      The method will calculate and return the electrical power dissipated in a circuit. 
         *      [P=I^2R].
         *      
         *      Call the CalculatePower() method two times from your program Main() method 
         *      supplying different arguments each time and displaying the returned value each time.
         */
        static double CalculatePower(double current, double resistance)
        {
            double power = Math.Pow(current,2) * resistance;
            return power;
        }
        #endregion

        #region Question 3
        /*
         *3.	Write a method called CaculateTuitionFee(int numberOfCourses, double costPerCourse = 449.99). 
         *      This method will calculate and return the required fees amount. 
         *      
         *      [Fees = number of courses * cost per course + 15.25].
         *      
         *      Call the CaculateTuitionFee() method four times from your program Main() method 
         *      supplying different arguments each time.
         *      
         *      This method has a default argument 
         *      i.e. if you do not specify the second argument then one will be supplied for you.
         */
        static double CaculateTuitionFee(int numberOfCourses, double costPerCourse = 449.99)
        {
            double fees = numberOfCourses * costPerCourse + 15.25;
            return fees;
        }
        #endregion

        #region Question 4
        /*
         *4.	Write a method called CalculateCommission(double saleAmount). 
         *      This method will calculate and return a sales representation’s commission. 
         *      
         *      [over $1000 the commission will be 1%]. 
         *      
         *      Call the CalculateCommission() method three times from your program Main() method, 
         *      supplying arguments 900, 1000 and 2000.
         */
        static double CalculateCommission(double saleAmount)
        {
            double commission = 0;
            if (saleAmount > 1000)
            {
                commission = (saleAmount - 1000) * .01;
            }
            return commission;
        }
        #endregion

        #region Question 5
        /*
         *5.	Write a method that does not take any argument. The method will prompt the user for 
         *      the number of burgers that he wants to buy. 
         *      The method will calculate and return the amount of money that will be required. 
         *      [One burger cost $1.39]. 
         *      
         *      From your program Main() method, call the above method two times 
         */
        static double CalculateBurgers()
        {
            Console.Write("How many burgers? ");
            double burgers = Convert.ToDouble(Console.ReadLine());

            const double PRICE = 1.39;

            double total = burgers * PRICE;

            return total;
        }
        #endregion

        #region Question 6
        /*
         *6.	“Newton's law of universal gravitation states that every point mass in the universe 
         *      attracts every other point mass with a force that is directly proportional to the product 
         *      of their masses and inversely proportional to the square of the distance between them.” 
         *      
         *      Write a method called CalculateGravitationalAttraction() that takes three double arguments 
         *      (masses of the two bodies and the distance between them). 
         *      
         *      The method will calculate and return the force of attraction between them. 
         *      [F=G (m_1 m_2)/d^2  , where G = 6.673x10-11]. 
         *      
         *      In your main call this method with the masses of the earth, moon and the distance between 
         *      them and display the resulting force. 
         *      
         *      Mass of Earth = 5.972 × 1024, moon = 7.348 × 1022, Distance = 384,400000m. 
         *      [Answer 1.99 x 1020N] 
         *      
         *      Use the e symbol to specify very large or very small values:
         *      double G = 6.673e-11;
         */
         static double CalculateGravitationalAttraction(double massBody1, double massBody2, double distance)
         {
            const double G = 6.673e-11;

            double F = G * ((massBody1 * massBody2) / Math.Pow(distance, 2));

            return F;
         }
        #endregion

        #region Question 7
        /*
         *7.	Heron’s formula allows you to calculate the area of any triangle given the length of the three sides. 
         * 
         *      Write a method that takes the length of the three sides and return the area of the specified triangle. 
         *      
         *      A=√(s(s-a)(s-b)(s-c) ) where s=(a+b+c)/2. 
         *      
         *      In your main call this method with arguments 5.83, 4.24 and 8.00, and display the area. 
         *      [Answer = 12.0].
         */
        static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            double s = (sideA + sideB + sideC) / 2;

            double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));

            return area;
        }
        #endregion

        #region Question 8
        /*
         *8.	Write a method called ConvertCelsiusToFahrenheit that takes a double argument. 
         *      The method will calculate and return the Fahrenheit equivalent of the argument. 
         *      
         *      [F = C * 9 / 5 + 32]. 
         *      
         *      In your main call this method three times with arguments 0, 50 and 100 
         *      respectively and display the results.
         */
        static double ConvertCelsiusToFahrenheit(double celsius)
        {
            double F = (celsius * 9/5) + 32;

            return F;
        }
        #endregion

        #region Question 9
        /*
         *9.	Write a method called ConvertFahrenheitToCelsius that takes a double argument. 
         *      The method will calculate and return the Celsius equivalent of the argument. 
         *      
         *      [C = (F – 32) * 5 / 9]. 
         *      
         *      In your main call this method three times with arguments 0, 32 and 212 
         *      respectively and display the results.
         */
        static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            double c = (fahrenheit - 32) * 5 / 9;

            return c; 
        }
        #endregion

        #region Question 10
        /*
         *10.	Write a method called ConvertCelsiusToKelvin that takes a double argument. 
         *      The method will calculate and return the Kelvin equivalent of the argument. 
         *      
         *      [K = C + 273.15].
         *      
         *      In your main call this method three times with arguments -196, 0 and 100
         *      respectively and display the results.
         */
        static double ConvertCelsiusToKelvin(double celsius)
        {
            double k = celsius + 273.15;

            return k;
        }
        #endregion

        #region Question 11
        /*
         *11.	Write a method call ConvertFahrenheitToKelvin that takes a double argument. 
         *      The method will calculate and return the Kelvin equivalent of the argument. 
         *      
         *      [DO NOT RE-CODE THIS METHOD. Use the two previous methods to assist in your computation]. 
         *      
         *      In your main call this method three times and display the results.
         *      
         *      Sending the output of one method call into the input of another method is referred to as method chaining. 
         *      It is an elegant style of programming.
         */
        static double ConvertFahrenheitToKelvin(double fahrenheit)
        {
            double k = ConvertCelsiusToKelvin(ConvertFahrenheitToCelsius(fahrenheit));

            return k;
        }
        #endregion

        #region Question 12
        /*
         *12.	Write two methods: Square(int) and Cube(int), these methods return the square and the cube of its argument. 
         *      
         *      In your main method prompt the user for an integer, then pass this integer to the Square method and then 
         *      pass the results to the Cube method. 
         *      
         *      In the main method print out the final results.
         */
        static int Square(int value)
        {
            int square = value * value;
            return square;
        }
        static int Cube(int value)
        {
            int cube = value * value * value;
            return cube;
        }
        #endregion
    }
}
