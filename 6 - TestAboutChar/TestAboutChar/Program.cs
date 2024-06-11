using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAboutChar
{
    class Program
    {
        static void Main(string[] args)
        {
            //  char c1 = 'A';
            //  Console.WriteLine(c1);
            // write a character using HEXADECIMAL UNICODE CHARCTER
            //char c2 = '\u0041';
            char c1 = '\u0048';
            char c2 = '\u0065';
            char c3 = '\u006C';
            char c4 = '\u006C';
            char c5 = '\u006F';
            Console.Write(c1);
            Console.Write(c2);
            Console.Write(c3);
            Console.Write(c4);
            Console.WriteLine(c5);
            // Console.WriteLine(c2);

            string strName;
            strName = "\u0048\u0065\u006C\u006C\u006F \u0054\u006F \u0045\u0067\u0079\u0070\u0074\u0065";
            // you can use https://www.rapidtables.com/code/text/unicode-characters.html to write a unicode characters;
            Console.WriteLine(strName);
            /*  string StrName2 = "Hello To Egypte";
              Console.WriteLine(StrName2);
              Console.WriteLine("Hello To Egypte");
              */

        }
    }
}
