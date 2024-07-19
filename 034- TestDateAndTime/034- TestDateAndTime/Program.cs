using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034__TestDateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // string strDt;
            //strDt = DateTime.Now.ToString();
            //Console.WriteLine(strDt);

            // Console.WriteLine(DateTime.Now);

            DateTime dt;
            dt = Convert.ToDateTime("01/01/2000 00:00:11");
            Console.WriteLine(dt);

        }
    }
}
