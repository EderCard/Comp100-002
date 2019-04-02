using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Call Question 1
            //int a, b, original;

            //a = 5;
            //original = a;
            //DoubleIt(ref a);
            //Console.WriteLine($"Before method call: {original} after method call: {a}");

            //b = 7;
            //original = b;
            //DoubleIt(ref b);
            //Console.WriteLine($"Before method call: {original} after method call: {b}");
            #endregion

            #region Call Question 2
            //int a, b, cube;
            //cube = 0;

            //a = 5;
            //CubeIt(a, ref cube);
            //Console.WriteLine($"Before method call: {a}, after method call: {cube}");

            //b = 2;
            //CubeIt(b, ref cube);
            //Console.WriteLine($"Before method call: {b}, after method call: {cube}");
            #endregion

            #region Call Question 3
            //int number;
            //double cost, fees;
            //fees = 0;

            //number = 5;
            //cost = 500;
            //CalculateTuitionFee(number, cost, ref fees);
            //Console.WriteLine($"{number} courses @{cost:C} will cost {fees:C}");

            //number = 5;
            //cost = 450;
            //CalculateTuitionFee(number, cost, ref fees);
            //Console.WriteLine($"{number} courses @{cost:C} will cost {fees:C}");

            //number = 10;
            //cost = 450;
            //CalculateTuitionFee(number, cost, ref fees);
            //Console.WriteLine($"{number} courses @{cost:C} will cost {fees:C}");

            //number = 10;
            //cost = 350;
            //CalculateTuitionFee(number, cost, ref fees);
            //Console.WriteLine($"{number} courses @{cost:C} will cost {fees:C}");
            #endregion

            #region Call Question 4
            //int a, b, sumAB, difAB;
            //a = 10;
            //b = 15;
            //CalculateSumDif(a, b, out sumAB, out difAB);
            //Console.WriteLine($"a:{a}, b:{b}, sum:{sumAB}, dif:{difAB}");

            //a = 25;
            //b = 15;
            //CalculateSumDif(a, b, out sumAB, out difAB);
            //Console.WriteLine($"a:{a}, b:{b}, sum:{sumAB}, dif:{difAB}");

            //a = 25;
            //b = 25;
            //CalculateSumDif(a, b, out sumAB, out difAB);
            //Console.WriteLine($"a:{a}, b:{b}, sum:{sumAB}, dif:{difAB}");
            #endregion

            #region Call Question 5
            //int angle = 0;

            //Console.WriteLine($" Angle   Sine     Cosine   Tangent");

            //for (int i = 1; i <= 20; i++)
            //{
            //    CalculateTrigValues(angle, out double sine, out double cosine, out double tangent);
            //    Console.WriteLine($"{angle,6:F2} {sine,8:F4} {cosine,8:F4} {tangent,8:F4}");
            //    angle += 5;
            //}
            #endregion

            #region Call Question 6
            double angle = 0.5;

            Console.WriteLine($" Angle   Sine     Cosine");

            for (int i = 1; i <= 10; i++)
            {
                CalculateTrigValues(angle, out double sine, out double cosine);
                Console.WriteLine($"{angle,6:F2} {sine,8:F4} {cosine,8:F4}");
                angle += 0.01;
            }
            #endregion

            #region Call Question 7
            //CalculateQuadraticEquation(12, 1, -6, out double x1, out double x2);

            //Console.WriteLine($"equation 12x^2 + 1x - 6 will have roots {x1:N3} {x2:N3}");
            #endregion
        }
        #region Question 1
        /*
         *1.	Write a method call DoubleIt(ref int x) that takes a single argument and does not return a value. 
         *      This method will double the value of its argument. 
         *      
         *      In your main, call this method twice and print the value of the parameter after the method call.
         *      
         *      The ref and out modifier allows the method to mutate the value of a parameter.
         *      You will have to add the modifier when sending the argument in your method invocation and in the 
         *      method header of the method definition
         */
        static void DoubleIt(ref int x)
        {
            x *= 2;
        }
        #endregion

        #region Question 2
        /*
         *2.	Write a method call CubeIt(int x, ref int cube) that takes two arguments and does not return a value. 
         *      The method will cube the first argument and assign it to the second argument. 
         *      
         *      In your main, call this method twice and print the value of the parameters after each method call.
         */
        static void CubeIt(int x, ref int cube)
        {
            cube = x * x * x;
        }
        #endregion

        #region Question 3
        /*
         *3.	Write a method with the following header: 
         *      static void CalculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees). 
         *      
         *      This method will calculate and assign the required fees amount to the third argument. 
         *      
         *      [Fees = number of courses * cost per course + 15.25]. 
         *      
         *      From your program Main() method, call the CalculateTuitionFee () method four times supplying 
         *      different arguments each time and display the value of the third argument after each method call.
         */
        static void CalculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees)
        {
            fees = numberOfCourses * costPerCourse + 15.25;
        }
        #endregion

        #region Question 4
        /*
         *4.	Write a method that takes four parameter of type int. The method will assign the sum of the 
         *      first two arguments to the third and the difference of the first two to the fourth. 
         *      
         *      This method should be coded so that the calling method will able to modify the values of the 
         *      third and fourth parameters.
         *      
         *      Call this method about three times and print out the values of all the four parameters after each method call.
         */
        static void CalculateSumDif(int valueA, int valueB, out int sumAB, out int difAB)
        {
            sumAB = valueA + valueB;
            difAB = Math.Abs(valueA - valueB);
        }
        #endregion

        #region Question 5
        /*
         *5.	Write a method with header 
         *      static void CalculateTrigValues(double degrees, out double sine, out double cosine, out double tangent). 
         *      
         *      The method will use the first argument to compute the values of the other three arguments. 
         *      Used the method Math.Sin, Math.Cos and Math.Tan to compute the second to fourth arguments respectively. 
         *      [radians = degrees * Math.Pi /180]. 
         *      
         *      In the Main() method, invoke this method 20 times with the first argument taking the values 0, 5, 10, … 95 
         *      and display the four arguments in a professional tabular format.
         *      
         *      The argument is taken as degrees
         */
        static void CalculateTrigValues(double degrees, out double sine, out double cosine, out double tangent)
        {
            sine = Math.Sin(degrees * Math.PI / 180);
            cosine = Math.Cos(degrees * Math.PI / 180);
            tangent = Math.Tan(degrees * Math.PI / 180);
        }
        #endregion

        #region Question 6
        /*
         *6.	Write a method that takes three parameters of type double: 
         *      the first represents an angle, the other two represents the sine and cosine of the angle respectively. 
         *      
         *      The method must be able to change the actual value of the second and third argument. 
         *      
         *      In your Main() method, call this method ten times with values 0.50, 0.51, 0.52 … 0.59 and printout the 
         *      values for angle, sine and cosine in a tabular format
         *      
         *      The argument is taken as radians
         */
        static void CalculateTrigValues(double degrees, out double sine, out double cosine)
        {
            sine = Math.Sin(degrees);
            cosine = Math.Cos(degrees);
        }
        #endregion

        #region Question 7
        /*
         *7.	A quadratic equation is one in the form of ax2+bx+c = 0. 
         *      Normally, there are two solutions to such equations given by the expression 
         *      x=(-b∓√(b^2-4ac))/2a
         *      
         *      The Write a method that takes five double arguments, the first three represents a, b and c respectively and 
         *      the last two the solutions to the equation. 
         *      
         *      [You can check your implementation, the quadratic equation 12x2 + x - 6 will yield solutions -0.750 & 0.667]
         *///
        static void CalculateQuadraticEquation(double a, double b, double c, out double x1, out double x2)
        {
            x1 = ((-1) * b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            x2 = ((-1) * b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
        }
        #endregion
    }
}
