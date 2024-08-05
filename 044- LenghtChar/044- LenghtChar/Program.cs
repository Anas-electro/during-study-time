using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044__LenghtChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name and Max Digits is 10 : ");
            string strName = Console.ReadLine();
            if (strName.Length > 10)
            {
                Console.WriteLine("INVALID NAME");
            }
            else
            {
                Console.WriteLine("Hello " + strName);
            }
        }
    }
}
