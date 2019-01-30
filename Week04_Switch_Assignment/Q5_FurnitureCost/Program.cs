using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    5.	Write a program for a furniture company. Ask the user to choose Pine Oak or Mahogany. 
        Show the price of a table manufactured with the chosen wood 
        Pine tables cost $100, 
        Oak tables cost $225, 
        and Mahogany tables cost $310. 
        Use named constants and switch. 
*/
namespace Q5_FurnitureCost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Materials available for tables are:");
            Console.WriteLine("1 . Pine");
            Console.WriteLine("2 . Oak");
            Console.WriteLine("3 . Mahogany");
            Console.Write("Choose a material for a table? ");
            int material = Convert.ToInt32(Console.ReadLine());
            const double PINE_COST = 100;
            const double OAK_COST = 225;
            const double MAHOGANY_COST = 310;
            switch (material)
            {
                case 1:
                    Console.WriteLine($"A table of Pine cost {PINE_COST:C}");
                    break;
                case 2:
                    Console.WriteLine($"A table of Oak cost {OAK_COST:C}");
                    break;
                case 3:
                    Console.WriteLine($"A table of Mahogany cost {MAHOGANY_COST:C}");
                    break;
            }
        }
    }
}

