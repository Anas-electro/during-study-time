using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026___StartWithLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);
            //Console.WriteLine(11);

            // for (VarWithStartValue ; Condition ; +or-) {Statements;}

            for (int i=1; i <= 11; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=============");
            for (int i = 11; i >= 1; i--)
            {
                Console.WriteLine(i);
            }



        }
    }
}
