using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___InputFromUser
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Console.WriteLine("Write any words: ");
            //Console.Write("Write any word : ");
            //string str = Console.ReadLine();
            //Console.WriteLine("Input is : " + str);

            //Console.Write("Enter Your Name: ");
            //string strName = Console.ReadLine();
            //Console.WriteLine("===========");
            //Console.WriteLine("Welcome " + strName);
            //Console.WriteLine("===========");

            Console.Write("Enter Number1 = ");
            string StrNbr1 = Console.ReadLine();
            Console.Write("Enter Number2 = ");
            string StrNbr2 = Console.ReadLine();
            Console.Write("Enter Number = ");
            string StrNbr3 = Console.ReadLine();
            int nbr1 = int.Parse(StrNbr1);
            int nbr2 = int.Parse(StrNbr2);
            int nbr3 = Convert.ToInt32(StrNbr3);
            int res = nbr1 + nbr2 + nbr3;
            Console.WriteLine(res);

        }
    }
}
