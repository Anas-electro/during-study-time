using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036___DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //do
            //{
            //    Console.WriteLine("true");
            //} while (true);

            //int x = 1;
            //do
            //{
            //    Console.WriteLine("Loop Nbr:" + x);
            //    x++;
            //} while (x <= 10);

            //int x = 10;
            //do
            //{
            //    Console.WriteLine("Loop Nbr: " + x);
            //    x--;
            //} while (x >= 1);

            //for(int x = 1; false; x++)
            //{
            //    Console.WriteLine(x);
            //}
            //int x = 1;
            //while (false)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}


            //int x = 1;
            //do
            //{
            //    Console.WriteLine(x);
            //    x++;
            //} while (false);

            string strYN;
            do
            {
                int nbr1;
                int nbr2;
                int res;

                Console.Write("Enter Number1: ");
                nbr1 = int.Parse(Console.ReadLine());
                Console.Write("Enter Number2 : ");
                nbr2 = int.Parse(Console.ReadLine());
                res = nbr1 + nbr2;
                Console.WriteLine("==========");
                Console.WriteLine(res);
                Console.WriteLine("=========");
                Console.Write("Do You want try again ? (y/n) : ");
                 strYN = Console.ReadLine();
            } while (strYN == "y" || strYN == "Y");

        }
    }
}
