using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047___SplitString
{
    class Program
    {
        static void Main(string[] args)
        {
            string strText;
            strText = "Welcome To Egypt";

            string[] AllText = strText.Split(' ');

            foreach(string s in AllText)
            {
                Console.WriteLine(s);
            }
        }
    }
}
