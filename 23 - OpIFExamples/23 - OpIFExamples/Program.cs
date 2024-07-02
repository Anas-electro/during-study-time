using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23___OpIFExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //int nbr1, nbr2;
            //Console.Write("Enter Number1: ");
            //nbr1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Number2: ");
            //nbr2 = int.Parse(Console.ReadLine());

            //int greater;

            //if (nbr1 > nbr2)
            //{
            //    greater = nbr1;
            //}
            //else
            //{
            //    greater = nbr2;
            //}

            //     Console.WriteLine(greater);

            //   (Condition) ? 5 : 2; ادا تحقق الشرط سوف يطبع 5 والعكس ادا لم يتحقق

            //greater = (nbr1 > nbr2) ? nbr1 : nbr2;
            //Console.WriteLine(greater);

            //Console.WriteLine("Enter The person Name: ");
            //string strName = Console.ReadLine();

            ////if (strName == "")
            ////{
            ////    strName = "Person";
            ////}

            //strName = (strName == "") ? "Person" : strName;
            //Console.WriteLine(strName);

            Console.WriteLine("Enter Grade: ");
            int gr = int.Parse(Console.ReadLine());

            string strGrade = (gr >= 50) ? "Pass" : "Fail";
            Console.WriteLine(strGrade);
         

        }
    }
}
