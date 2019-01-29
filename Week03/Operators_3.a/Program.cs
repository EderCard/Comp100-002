using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_3.a
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 2, c = 4;
            bool result;
            result = Convert.ToBoolean(b % c * a != a % c * b);
            Console.WriteLine($"Result is {result}");
        }
    }
}
