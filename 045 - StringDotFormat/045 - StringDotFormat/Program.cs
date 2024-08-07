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

            //string strName = "Ahmed";
            //string strJobs = "Programmer";
            //string strPhone = "0722229805";

            ////string strData = "Name: " + strName
            ////               + "\nJob: " + strJobs
            ////               + "\nPhone: " + strPhone;

            //string strData = string.Format("Name: {0}\nJob: {1}\nPhone: {2}",strName,strJobs,strPhone);
            //Console.WriteLine(strData); 


            //int invoiceNum = 1;
            //string strInvoice = string.Format("{0:00000}", invoiceNum);
            //Console.WriteLine(strInvoice);

            //int[] InvoiceNumbers = { 1, 50, 155, 6000, 123, 900, 1000, 999 };
            //foreach(int index in InvoiceNumbers)
            //{
            //    Console.WriteLine(string.Format("{0:000000}",index));
            //}

            //int price = 150;

            //Console.WriteLine(string.Format("{0:c6}", price));

            //int salary = 7000;
            //string strSal = string.Format("{0:f2}", salary);
            //Console.WriteLine(strSal);

            //DateTime dt = Convert.ToDateTime("01 / 01 / 2000 03:15 pm");
            //string myDate = string.Format("{0:dd/MM/yyyy}",dt);
            //Console.WriteLine(myDate);

            //int num = 10550000;
            //Console.WriteLine(string.Format("{0:X}", num));

            string strName = "Adel";
            Console.WriteLine("Name: {0}", strName);
        }
    }
}
