using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__IDENTIFIERS_RULES
{
    class Program
    {
        static void Main(string[] args)
        {
            //// المسميات حساسة لحالة الأحرف
            //string strName;
            //strName = "Anas"; //Correct
            //strname = "Anas"; //Incorrect

            ////2- لا يتم تسمية مثل الكلمات المحجوزة
            //string strName; //Correct
            //string string; //Incorrect ممنوع عمل مثغير بنفس الاسم
            //int int; // Incorrect;

            ////3- لا يصح أن يبدأ المسمى برقم
            //// لا بد من أن يبدأ بحرف
            //string name1; // Correct;
            //string name2name; //Correct;
            //string 1number; // Incorrect;
            //int 22Grade; // Incorrect;

            ////4- المسميات لا تحتوي على رموز فيما عدا رمز
            //string _name; //Correct;
            //string First_name; //Correct;
            //string name_; //Correct;
            //string name$; //Incorrect;
            //int num&name; //Incorrect;

            //5- لا يصح ان تحتوي المسميات على مسافة
            //string first name; //Incorrect;

            ////6- لا بد ان يتم تعريف المتغير قبل استخدتمه
            //num1 = 5; // Incorrect;
            //int num1;
            //// Correct;
            //int num2;
            //num2 = 5;

            //7- يمكن استخدام رموز Unicode عند التعريف

            // string \u004Don;

            // Mon = "Hello@example.com";
            // Console.WriteLine(\u004Don);
            //// int \u0033num; //Incorrect;
            // int num\u0033; //Correct;
            // num3 = 5;
            // Console.WriteLine(num3);


            //8- يمكن استخدام نفس حروف الكلمات المحجوزة بحالة أحرف اخرى
            // وهذه الطريقة لا ننصح بها
            //int INT; // int Int;
            //INT = 2;

            //9- يمكن الهروب من الكلمات المحجوزة اثناء التسمية
            // وهذه الطريقة لا ننصح بها
            //string @string;
            //@string = "Hello @";
            //int @int;
            //@int = 55;

            //Console.WriteLine(@string);
            //Console.WriteLine(@int);

            //string ABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJ;

            //ABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJ = "WELCOME LONG";
            //Console.WriteLine(ABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJ);







        }
    }
}
