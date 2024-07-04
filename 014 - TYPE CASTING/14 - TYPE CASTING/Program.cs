using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___TYPE_CASTING
{
    class Program
    {
        static void Main(string[] args)
        {
            //double dblNum = 11.55;
            //int intNum;
            //intNum = (int)dblNum;

            //// intNum = Convert.ToInt32(dblNum);
            //Console.WriteLine(intNum);

            object obj = "Hello";
            string str = (string)obj;

            Console.WriteLine(str);
            
        }
    }
}
