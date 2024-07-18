using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033___ALL_MULTIPLICATIONUsingFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int baseNum = 1; baseNum<=10; baseNum++)
            {
                Console.WriteLine("Table " + baseNum);
                Console.WriteLine("-----------");
                for (int num = 1; num<=10;num++ )
                {
                    Console.WriteLine("  " + baseNum + " x " + num + " = " + baseNum * num);
                }
                Console.WriteLine("==========");
            }
        }
    }
}
