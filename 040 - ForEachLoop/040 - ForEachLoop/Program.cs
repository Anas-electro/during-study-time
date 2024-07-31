using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040___ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            //  string[] strNames = new string[3];
            //   string strNames = "";


            // int[] intS = new int[3];
            // int i = 0;

            //string[] strNames = {"Amr", "Ali", "Tamer" };

            ////for (int index=0;index<strName.Length;index++)
            ////{
            ////    Console.WriteLine(strNames[index]);
            ////}

            //foreach(string strName in strNames)
            //{
            //    Console.WriteLine(strName);
            //}

            string strName = "Abdollah";
            //char[] cName = strName.ToCharArray();
            //foreach(char c in cName)
            //{
            //    Console.WriteLine(c);
            //}

            foreach(char c in strName)
            {
                Console.WriteLine(c);
            }

        }
    }
}
