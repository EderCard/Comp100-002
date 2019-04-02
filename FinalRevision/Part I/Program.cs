using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_I
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Call Question 1
            //DisplayPersonalInfo();
            #endregion

            #region Call Question 2
            //CalculateTuition();
            #endregion

            #region Call Question 3
            //CalculateAreaOfCircle();
            #endregion

            #region Call Question 4
            //CalculateAreaOfTriangle();
            //CalculateAreaOfTriangle();
            #endregion

            #region Call Question 5
            //CalculateSaleCommission();
            //CalculateSaleCommission();
            //CalculateSaleCommission();
            #endregion

            #region Call Question 6
            //DisplaySineTable();
            #endregion

            #region Call Question 7
            //DisplayMenu();
            #endregion

            #region Call Question 8
            ShowMenu();
            #endregion
        }
        #region Question 1
        /*
         * 1.	Write a method called DisplayPersonalInfo(). This method will display your name, 
         *      school, program and your favorite course. 
         *      
         *      Call the DisplayPersonalInfo() method from your program Main() method
         */
        static void DisplayPersonalInfo()
        {
            Console.WriteLine("Ederson Cardoso");
            Console.WriteLine("SETAS");
            Console.WriteLine("Software Engineering Technician");
            Console.WriteLine("Programming");
        }
        #endregion

        #region Question 2
        /*
         *2.	Write a method called CalculateTuition(). This method will prompt the user for the number 
         *      of courses that she is currently taking and then calculate and display the tuition cost. 
         *      (cost = number of course * 569.99). 
         *      
         *      Call the CalculateTuition() method two times from the same Main() method as in question 1
         */
        static void CalculateTuition()
        {
            Console.Write("How many courses are you taking? ");
            int numberOfCourses = Convert.ToInt32(Console.ReadLine());

            double cost = numberOfCourses * 569.99;
            Console.WriteLine($"The cost of {numberOfCourses} courses is {cost:C}");
        }
        #endregion

        #region Question 3
        /*
         * 3.	Write a method call CalculateAreaOfCircle(). This method will prompt the user for the radius 
         *      of a circle and then calculate and display the area.
         *      [A = πr2]. 
         *
         *      Call the CalculateAreaOfCircle() method twice from the same Main() method as in question 1. 
         *      Use Math.Pi for the value of π
         */
        static void CalculateAreaOfCircle()
        {
            Console.Write("Enter the radius: ");
            double radius = Convert.ToInt32(Console.ReadLine());

            double area = Math.PI * radius * radius;
            Console.WriteLine($"If the radius is {radius:F2} the area will {area:F2}");
        }
        #endregion

        #region Question 4
        /*
         *4.	Write a method call CalculateAreaOfTriangle(), that prompts the user for the base and height
         *      of a triangle and then calculate and display the area.
         *      [ A=bt/2 ] 
         *
         *      Call the CalculateAreaOfTriangle() method twice from the same Main() method as in question 1.
         *
         */
        static void CalculateAreaOfTriangle()
        {
            Console.Write("Height: ");
            double h = Convert.ToInt32(Console.ReadLine());

            Console.Write("Base: ");
            double b = Convert.ToInt32(Console.ReadLine());

            double area = b * h / 2;
            Console.WriteLine($"The area will be {area:F2} ");
        }
        #endregion

        #region Question 5
        /*
         * 5.	Write a method call CalculateSaleCommission(), that prompts the user for his sales figure, 
         *      and then calculate and display his commission. 
         *      (commission = 25% of sales in excess of 1000. 
         *      If sales is equal to or below $1000.00 there is no commission) 
         *
         *      Call the CalculateSaleCommission() method three times from the same Main() method as in question 1.
         */
        static void CalculateSaleCommission()
        {
            Console.Write("What is your sales amount? ");
            double sales = Convert.ToInt32(Console.ReadLine());

            double commission = 0;
            if (sales > 1000)
            {
                commission = (sales - 1000) * .25;
            }
            Console.WriteLine($"The commission on {sales:C} is {commission:C}");
        }
        #endregion

        #region Question 6
        /*
         * 6.	Write a method call DisplaySineTable(), that prompts the user for a starting value and an step size. 
         *      The method will calculate and display a table (10 rows) of sine values based on the user input. 
         *      Use the built-in method Math.Sin() to obtain the sine of an angle. 
         *      e.g. if the starting value is 0.5 and the step size is 0.03 the method will display the following table:
         *      0.50	0.4794
         *      0.53	0.5055
         *      0.56	0.5311
         *  
         *      0.77	0.6961
         *
         *      The numbers in both columns MUST be right aligned. 
         *      Call the DisplaySineTable() method from the same Main() method as in question 1.
         */
        static void DisplaySineTable()
        {
            Console.Write("Starting value: ");
            double angle = Convert.ToDouble(Console.ReadLine());

            Console.Write("Increment value: ");
            double increment = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                double sinValue = Math.Sin(angle);
                Console.WriteLine($"{angle:N2} {sinValue:N3}");
                angle += increment;
            }
        }
        #endregion

        #region Question 7
        /*
         * 7.	In a write a method called DisplayMenu() to display the following text on screen:
         *      ===========Narendra’s Computer Systems================
         *      |       1. Display Personal Information              |
         *      |       2. Calculate Tuition                         |
         *      |       3. Calculate Area Of A Circle                |
         *      |       4. Calculate The Area Of A Triangle          |
         *      |       5. Calculate Sales Commission                |
         *      |       6. Display Sine Table                        |
         *      |       0. End program                               |
         *      |                                                    |
         *      ======================================================
         *      Enter the number of your choice ->
         *      
         *      You may replace the instructor’s name with your name.
         */
        static void DisplayMenu()
        {
            Console.WriteLine("===========Ederson’s Computer Systems================");
            Console.WriteLine("|       1. Display Personal Information              |");
            Console.WriteLine("|       2. Calculate Tuition                         |");
            Console.WriteLine("|       3. Calculate Area Of A Circle                |");
            Console.WriteLine("|       4. Calculate The Area Of A Triangle          |");
            Console.WriteLine("|       5. Calculate Sales Commission                |");
            Console.WriteLine("|       6. Display Sine Table                        |");
            Console.WriteLine("|       0. End program                               |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("======================================================");
            Console.Write("Enter the number of your choice -> ");
        }
        #endregion

        #region Question 8
        /*
         * 8.	Add another method called ShowMenu() to your project. This method will call the method in question 7 
         *      continuously until the user presses 0. 
         *      (You will have to invoke the method in a loop body, read in the user input as well as check the input).
         *      You will need to hook up all the methods that you wrote previously 
         *      i.e. questions 1 to 6. 
         *      Replace all the code from your Main() method with a single call to the ShowMenu() method.
         */
        static void ShowMenu()
        {
            string menu = "anyValue";

            while (menu != "0")
            {
                DisplayMenu();
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        DisplayPersonalInfo();
                        break;
                    case "2":
                        CalculateTuition();
                        break;
                    case "3":
                        CalculateAreaOfCircle();
                        break;
                    case "4":
                        CalculateAreaOfTriangle();
                        break;
                    case "5":
                        CalculateSaleCommission();
                        break;
                    case "6":
                        DisplaySineTable();
                        break;
                }
            }
        }
        #endregion
    }
}
