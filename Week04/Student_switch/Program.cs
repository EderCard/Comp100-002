using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Code the following usig SWITCH
 *if (year == 1)
  Console.WriteLine("Freshman");    
  else
  if (year == 2)
    Console.WriteLine("Sophomore"); 
  else
  if (year == 3)
    Console.WriteLine("Junior");      
  else
  if (year == 4)
    Console.WriteLine("Senior");    
  else
    Console.WriteLine("Invalid year");
 */
namespace Student_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year are you in? ");
            int year = Convert.ToInt32(Console.ReadLine());
            switch (year)
            {
                case 1: Console.WriteLine($"Year {year} is a Freshman");
                    break;
                case 2:
                    Console.WriteLine($"Year {year} is a Sophomore");
                    break;
                case 3:
                    Console.WriteLine($"Year {year} is a Junior");
                    break;
                case 4:
                    Console.WriteLine($"Year {year} is a Senior");
                    break;
                default:
                    Console.WriteLine($"Year {year} is not known");
                    break;
            }
        }
    }
}
