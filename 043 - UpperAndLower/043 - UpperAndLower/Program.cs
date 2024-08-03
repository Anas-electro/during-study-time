using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043___UpperAndLower
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "abcdefgh";
            //string strUP = str.ToUpper();
            //string strLow = str.ToLower();
            //Console.WriteLine(str);
            //Console.WriteLine(strUP);
            //Console.WriteLine(strLow);

            string strName = "Ahmed";
            string strName2 = "";
            char[] cName = strName.ToCharArray();
            for (int index=0;index <5;index++)
            {
                if (index == 3)
                {
                strName2 += cName[index].ToString().ToUpper();
                }
                else
                {
                    strName2 += cName[index];
                }
            }
            Console.WriteLine(strName2);
        }
    }
}
