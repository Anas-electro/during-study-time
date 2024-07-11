using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028___TestFor
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Alphabet");
            ////Console.WriteLine("===============");
            ////for (char c = 'a'; c<= 'z'; c++)
            ////{
            ////    Console.WriteLine(c);
            ////   // Console.WriteLine((int)c);
            ////}

            //for (char c = 'z'; c >= 'a'; c--)
            //{
            //    Console.WriteLine(c);
            //  //  Console.WriteLine((int)c);
            //}

            //for (int x = 1, y = 10; x<=10;x++,y--)
            //{
            //    Console.WriteLine(x + ":" + y);
            //   // Console.WriteLine("X = " + x);
            //   // Console.WriteLine("Y = " + y);
            //}


            //for (int x = 1, y = 10, z = 100; x <= 10; x++, y += 10, z+=100)
            //    Console.WriteLine(x + ":" + y + ":" + z);

            //for (int x = 1, y = 10, z = 100; x <= 10 && y <= 30; x++, y += 10, z += 100)
            //    Console.WriteLine(x + ":" + y + ":" + z);

            for (int x = 1,y = 10; x < y;x++,y--)
            {
                Console.WriteLine(x + " : " + y);
            }



        }
    }
}
