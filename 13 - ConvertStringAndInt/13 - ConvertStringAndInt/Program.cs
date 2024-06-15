using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___ConvertStringAndInt
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////Convert from string to Integer

            //  string Nbr1 = "998";
            //  int Nbr2 = 2;
            //  int res;
            //  // res = int.Parse(Nbr1) + Nbr2;
            //  //res = Int32.Parse(Nbr1) + Nbr2;
            //  // Convert.ToDouble;
            //  res = Convert.ToInt32(Nbr1) + Nbr2;
            //// res = double.Parse(Nbr1) + Nbr2;
            //  Console.WriteLine(res);

            int Nbr1 = 155;
            string str;

            /// str = Convert.ToString(Nbr1);
            // str = Nbr1.ToString();
            str = Nbr1 + "";
            Console.WriteLine(str);
        }
    }
}
