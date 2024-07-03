using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24___OpSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbr = 3;
            switch(nbr)
            {
                case 1:
                    Console.WriteLine(1);
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
                
                    
            }
        }
    }
}
