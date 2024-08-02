using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042___GenerateRandom
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            // int rNum = rnd.Next();
            int rNum;
            //  rNum = rnd.Next(1,20);
            //rNum = rnd.Next(1, 13);
            //DateTime dt = Convert.ToDateTime(rNum + "/" + rNum + "/2000");

            //Console.WriteLine(dt.ToString("MMMM"));


            // Console.WriteLine(rNum);

            rNum = rnd.Next(1, 8);
            Console.WriteLine(rNum);
        }
    }
}
