using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___CompareOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbr1 = 10;
            int nbr2 = 5;

            bool b;
            // b = nbr1 == nbr2;
            // b = nbr1 > nbr2;
            //b = nbr1 >= nbr2;
            // b = nbr1 < nbr2;
            // b = nbr1 <= nbr2;
            b = nbr1 != nbr2;
            Console.WriteLine(b);

        }
    }
}
