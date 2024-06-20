using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___PRE_FIX_and_POST_FIX
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //x = x + 1;
            //x += 1;
            //x++;
            //++x;

            //x = x - 1;
            //x -= 1;
            //x--;
            //--x;


            // Console.WriteLine(x);

            ////// Postfix + جاي بعد المتغير
            ////x++;
            //// Prefix قبل المتغير
            //++x;

            int x = 5;
            // int y = x++;
            int y = ++x;

            Console.WriteLine("y = " + y);
            Console.WriteLine("x = " + x);


        }
    }
}
