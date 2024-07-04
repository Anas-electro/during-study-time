using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___ElseifExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Enter Number1: ");
            //int nbr1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Number2 : ");
            //int nbr2 = int.Parse(Console.ReadLine());

            //if (nbr1 > nbr2)
            //{
            //    Console.WriteLine("Number1 > Number2");
            //}
            //else if (nbr2 > nbr1)
            //{
            //    Console.WriteLine("Number 2 > Number1");
            //}
            //else
            //{
            //    Console.WriteLine("Number 1 = Number 2");
            //}

            Console.WriteLine("Enter Grade:");
            int g = int.Parse(Console.ReadLine());

            if (g<0)
            {
                Console.WriteLine("No Grade!");
            }
            else if (g<50)
            {
                Console.WriteLine("F");
            }
            else if (g < 60)
            {
                Console.WriteLine("E");
            }
            else if (g < 70)
            {
                Console.WriteLine("D");
            }
            else if (g < 80)
            {
                Console.WriteLine("C");
            }
            else if (g < 90)
            {
                Console.WriteLine("B");
            }
            else if (g <= 100)
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine("No Grade!");
            }

        }
    }
}
