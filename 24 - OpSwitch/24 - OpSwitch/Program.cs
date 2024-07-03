using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24___OpSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //int nbr = 3;
            //switch(nbr)
            //{
            //    case 1:
            //        Console.WriteLine(1);
            //        Console.WriteLine("One");
            //        break;
            //    case 2:
            //        Console.WriteLine(2);
            //        break;
            //    case 3:
            //        Console.WriteLine("Three");
            //        break;
            //    default:
            //        Console.WriteLine("Other");
            //        break;


            // }

            //char c = 'B';
            //switch (c)
            //{
            //    case 'A':
            //        Console.WriteLine("A");
            //        break;
            //    case 'B':
            //        Console.WriteLine("B");
            //        break;

            int nbr = 2;
            switch (nbr*2)
            {
                case 2:
                    Console.WriteLine(nbr + " * 2 = " + (nbr*2));
                    break;
                case 4:
                    Console.WriteLine(nbr + " * 2 = " + (nbr * 2));
                    break;
                case 6:
                    Console.WriteLine(nbr + " * 2 = " + (nbr * 2));
                    break;
           // }   

            }

        }
    }
}
