using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032___NestedForExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int dept = 1; dept <= 4; dept++)
            //{
            //   /// Console.WriteLine("--------------------");
            //    Console.WriteLine("Departement : " + dept);
            //    Console.WriteLine("--------------------");
            //    for (int emp = 1; emp <= 3; emp++)
            //    {
            //        Console.WriteLine("  Employee : " + emp);
            //    }
            //    Console.WriteLine("--------------------");
            //}

            for (int com = 1; com <= 2; com++)
            {
                Console.WriteLine("Company " + com);
                Console.WriteLine("_________________");
                for(int b = 1; b<=2;b++)
                {
                    Console.WriteLine("   Building " + b);
                    Console.WriteLine("   -----------");
                    for (int f = 1; f<=3; f++)
                    {
                        Console.WriteLine("      Floor" + f);

                        for (int r = 1; r<=2; r++)
                        {
                            Console.WriteLine("           Room " + r);
                        }
                    }
                    Console.WriteLine("------------------");
                }
            }

        }
    }
}
