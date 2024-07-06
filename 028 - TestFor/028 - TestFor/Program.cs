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
            //Console.WriteLine("Alphabet");
            //Console.WriteLine("===============");
            //for (char c = 'a'; c<= 'z'; c++)
            //{
            //    Console.WriteLine(c);
            //   // Console.WriteLine((int)c);
            //}

            for (char c = 'z'; c >= 'a'; c--)
            {
                Console.WriteLine(c);
              //  Console.WriteLine((int)c);
            }
        }
    }
}
