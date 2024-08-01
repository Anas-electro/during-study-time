using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041___TracingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string strName;
            strName = "Omar";
            Console.WriteLine(strName);

            string[] strNames = { "Ahmed", "Amr", "Abdel", "Ehab" };
            for(int index = 0;index<4;index++)
            {
                Console.WriteLine(strNames[index]);
            }
        }
    }
}
