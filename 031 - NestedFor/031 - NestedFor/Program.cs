using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031___NestedFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int x = 1; x<= 5; x++)
            //{
            //    Console.WriteLine(x);
            //    for (int y = 1; y <= 3; y++)
            //    {
            //        Console.WriteLine(" " + x + ">>" + y);
            //    }

            //}

            for (int x = 1; x <= 3; x++)
            {
                Console.WriteLine(x);
                for (int y = 1; y <= 3; y++)
                {
                    Console.WriteLine(" " + x + ">>" + y);

                    for (int z = 1; z <= 2; z++)
                    {
                        Console.WriteLine("   " + x + ">>" + y + ">>" + z);
                    }
                }

            }


        }
    }
}
