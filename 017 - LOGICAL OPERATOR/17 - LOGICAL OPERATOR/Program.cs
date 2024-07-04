using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___LOGICAL_OPERATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ahmed AND Amr
            // true  true = true;
            // false false = false;
            // false false = ture;
            // false true = true;
            // في هذه الحالة يجب تحقق من كل من الاسطر


            //Ahmed OR Amr
            // true  true = true;
            // true  false = ture;
            // true  true  = false;
            // false false = false;

            // NOT true = false;
            // NOT false = true;
            // NOT Ahmed = every body except ahmed
            // NOT Amr  = every body except amr


            /////////AND
            Console.WriteLine("AND Operator");
            bool and1 = true && true;
            bool and2 = true && false;
            bool and3 = false && true;
            bool and4 = false && false;
            Console.WriteLine(and1);
            Console.WriteLine(and2);
            Console.WriteLine(and3);
            Console.WriteLine(and4);

            Console.WriteLine("=============");

            ////////OR
            Console.WriteLine("OR Operator");
            bool or1 = true || true;
            bool or2 = true || false;
            bool or3 = false || true;
            bool or4 = false || false;

            Console.WriteLine(or1);
            Console.WriteLine(or2);
            Console.WriteLine(or3);
            Console.WriteLine(or4);

            Console.WriteLine("=============");

            //////NOT
            Console.WriteLine("NOT Operator");
            bool not1 = !true;
            bool not2 = !false;
            Console.WriteLine(not1);
            Console.WriteLine(not2);
            Console.WriteLine("=============");


        }
    }
}
