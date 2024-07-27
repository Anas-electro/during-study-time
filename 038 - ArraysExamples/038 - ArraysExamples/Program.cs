using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038___ArraysExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //string strName = "Ahmed";
            //strName = "Ali";
            //strName = "Mohamed";

            //Console.WriteLine(strName);

            //string[] strNames = new string[5];
            //strNames[0] = "Anas";
            //strNames[1] = "Samsung";
            //strNames[2] = "FRP BYPASS";
            //strNames[3] = "Apple";
            //strNames[4] = "Huwaei";

            //Console.WriteLine(strNames[0]);
            //Console.WriteLine(strNames[1]);
            //Console.WriteLine(strNames[2]);
            //Console.WriteLine(strNames[3]);
            //Console.WriteLine(strNames[4]);

            //int[] nbrs = new int[3];
            //nbrs[0] = 15;
            //nbrs[1] = 19;
            //nbrs[2] = nbrs[0] + nbrs[1];
            //Console.WriteLine(nbrs[0]);
            //Console.WriteLine(nbrs[1]);
            //Console.WriteLine(nbrs[2]);

            object[] data = new object[7];

            data[0] = "ABC";
            data[1] = 1;
            data[2] = true;
            data[3] = 'M';
            data[4] = 3.14444;
            data[5] = 12345678901034506;
            data[6] = false;

            Console.WriteLine(data[0]);
            Console.WriteLine(data[1]);
            Console.WriteLine(data[2]);
            Console.WriteLine(data[3]);
            Console.WriteLine(data[4]);
            Console.WriteLine(data[5]);
            Console.WriteLine(data[6]);



        }
    }
}
