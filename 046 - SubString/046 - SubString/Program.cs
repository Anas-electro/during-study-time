using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046___SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string strText = "Hello Word!";
            //// string strSubText = strText.Substring(2);
            //string strSubText = strText.Substring(0,5);

            //Console.WriteLine(strSubText);

            Console.Write("Enter the File Name: ");
            string strFileName = Console.ReadLine();

            string strFileName2 = "";

            if (strFileName.Length > 4)
            {
                strFileName2 = strFileName.Substring(0,strFileName.Length - 4);
            }
            Console.WriteLine(strFileName2);
        }
    }
}
