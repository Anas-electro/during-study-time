using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039___ArrayWithLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] strNames = new string[5];
            //strNames[0] = "Ahmed";
            //strNames[1] = "Adel";
            //strNames[2] = "Amr";
            //strNames[3] = "Ehab";
            //strNames[4] = "Mahmoud";

            //Console.WriteLine(strNames[0]);
            //Console.WriteLine(strNames[1]);
            //Console.WriteLine(strNames[2]);
            //Console.WriteLine(strNames[3]);
            //Console.WriteLine(strNames[4]);

            //for (int i = 0;i<=strNames.Length - 1;i++)
            //{
            //    Console.WriteLine(strNames[i]);
            //}

            Console.Write("Enter Count of employes: ");
            int empCount = Convert.ToInt32(Console.ReadLine());
            string[] strEmps = new string[empCount];
            for (int i = 0;i<= empCount - 1;i++)
            {
                Console.Write("Enter Employee Number " + (i + 1) + ": ");
                strEmps[i] = Console.ReadLine();
            }
            for (int i = 0; i<= empCount - 1;i++)
            {
                Console.WriteLine(strEmps[i]);
            }
        }
    }
}
