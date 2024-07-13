using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029___INFINITY_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (;;)
            //    Console.WriteLine("101");

            //int x = 0;
            //for (;;)
            //{ 
            //    Console.Write(x);
            //x++;
            //}

            //int i = 1;
            //for (;;)
            //{
            //    Console.Write(i + ";");
            //    i++;
            //    if (i>1000)
            //    {
            //        break;
            ////    }
            //}


            int x = 1;
            int y = 10000;
            for(;;)
            {
                Console.Write(x - y + ";");
                x++;
                y--;
                if (x > 10000)
                {
                    break;
                }
            }


        }
    }
}
