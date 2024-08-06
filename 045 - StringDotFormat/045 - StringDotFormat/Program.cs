using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045___StringDotFormat
{
    class Program
    {
        static void Main(string[] args)
        {

            string strName = "Ahmed";
            string strJobs = "Programmer";
            string strPhone = "0722229805";

            //string strData = "Name: " + strName
            //               + "\nJob: " + strJobs
            //               + "\nPhone: " + strPhone;

            string strData = string.Format("Name: {0}\nJob: {1}\nPhone: {2}",strName,strJobs,strPhone);
            Console.WriteLine(strData); 
        }
    }
}
