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

            //DateTime dt;
            //dt = Convert.ToDateTime("01/01/2000 00:00:11");
            //Console.WriteLine(dt);

            ///////////////////////////

            // string strDT;
            // strDT = DateTime.Now.ToString("d");
            //strDT = DateTime.Now.ToString("D");
            //strDT = DateTime.Now.ToString("t");
            //strDT = DateTime.Now.ToString("T");
            //strDT = DateTime.Now.ToString("dd");
            //  strDT = DateTime.Now.ToString("MM");
            //strDT = DateTime.Now.ToString("yyyy");
            //strDT = DateTime.Now.ToString("yy");
            //strDT = DateTime.Now.ToString("M");
            //strDT = DateTime.Now.ToString("y");
            // strDT = DateTime.Now.ToString("dd/MM/yyyy");
            //strDT = DateTime.Now.ToString("dd/MM/yy");
            //strDT = DateTime.Now.ToString("dd-MM-yyyy");
            //strDT = DateTime.Now.ToString("d/M/yyyy");
            //strDT = DateTime.Now.ToString("hh");
            //strDT = DateTime.Now.ToString("mm");
            //strDT = DateTime.Now.ToString("ss");
            //strDT = DateTime.Now.ToString("tt"); //pm/am
            // strDT = DateTime.Now.ToString("hh:mm:ss tt");
            //strDT = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss tt");
            // Console.WriteLine(strDT)  ;

            Console.WriteLine(DateTime.Now.AddYears(5).AddMonths(1).AddDays(3).AddHours(1).AddMinutes(10).ToString("dd-MM-yyyy  - hh:mm:ss tt"));

        }
    }
}
