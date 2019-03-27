using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrokenTest();
            // FixedTwice();
             TestOut();
        }
        #region BrokenTwice
        /*
         *Write a methos that double its argument 
         */
        static void BrokenTwice(int a)
        {
            a *= 2;
            Console.WriteLine($"In the method {a}");
        }
        /*
         * Write a method to call the above method
         */
        static void BrokenTest()
        {
            int a = 10;
            Console.WriteLine($"Before method call {a}");
            BrokenTwice(a);
            Console.WriteLine($"After method call {a}");
        }
        #endregion


        #region FixedTwice
        /*
         *Write a methos that double its argument 
         */
        static void Twice(ref int michael)
        {
            michael *= 2;
            Console.WriteLine($"In method {michael}");
        }
        /*
         * Write a method that call the above method
         */
        static void FixedTwice()
        {
            int mushfika = 10;
            Console.WriteLine($"Before method {mushfika}");
            Twice(ref mushfika);
            Console.WriteLine($"After method {mushfika}");
        }
        #endregion

        #region out
        /*
        * Write a method to square and cube its argument
        */
        static void SquareAndCube(int a,  out int s, out int c)
        {
            s = a * a;
            c = s * a;
        }
        /*
         * Write a method that test the above method
         */
        static void TestOut()
        {
            int number = 2, square, cube;
            //Console.WriteLine($"Before {number}, {square}, {cube}");
            SquareAndCube(number, out square, out cube);
            Console.WriteLine($"After {number}, {square}, {cube}");
        }
        #endregion
    }
}
