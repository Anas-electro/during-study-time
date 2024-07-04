using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20___IF_STATEMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //// if(condition)
            //{
            //    stattement1;
            //    stattement2;
            //    .........
            //}
            //int nbr1 = 10;
            //int nbr2 = 5;
            //if (nbr1 > nbr2)
            //{
            //    Console.WriteLine("true");
            //}
            //Console.Write("Enter y/n : ");
            //string strYN = Console.ReadLine();
            //if (strYN == "y")
            //    Console.WriteLine("Welcome");

            Console.Write("Enter Number1: ");
            string strNumber1 = Console.ReadLine();
            Console.Write("Enter Number2 : ");
            string strNumber2 = Console.ReadLine();

            int number1 = int.Parse(strNumber1);
            int number2 = int.Parse(strNumber2);
            int res = 0;
            if (number1 >= number2)
            {
                res = number1 - number2;
            Console.WriteLine(res);
            }

        }
    }
}
