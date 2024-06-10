using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // STRUCT DataType VarName;
            byte nbr1;
            // nbr1 = "Error please put natural number";
            nbr1 = 1;
            string StrName;
            StrName = "Hello Trust the magic of new beginings";
            //StrName = 123; "please put text";
            int intNum;
            intNum = 144;
            char c;
            c = 'c'; // don't forget to use single quote to print a character
            // طبع الرقم المخزون مع الرجوع للسطر 
            Console.WriteLine(nbr1);
            Console.WriteLine(StrName);
            Console.WriteLine(intNum);
            Console.WriteLine(c);
            // use control + F5 to debug 
            // المتغير دائما ما يخد القيمة الأولى للمتغير   
            bool value;
            value = true; // value = false;
            Console.WriteLine(value);
            double myNumber = 07222298.05;

            Console.WriteLine(myNumber);

        }
    }
}
