using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030__MultiUsingFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNum;
            Console.WriteLine("Enter The Number: ");
            baseNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(baseNum + " x " + i + " = " + baseNum * i);
            }
        }
    }
}
