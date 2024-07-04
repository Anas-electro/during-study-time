using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25___OpSwitchExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter number1 : ");
            //int nbr = int.Parse(Console.ReadLine());

            //switch(nbr)
            //{
            //    case 0:
            //        Console.WriteLine("Zero");
            //        break;
            //    case 1:
            //        Console.WriteLine("One");
            //        break;
            //    case 2:
            //        Console.WriteLine("Twoo");
            //        break;
            //    case 3:
            //        Console.WriteLine("Three");
            //        break;
            //    case 4:
            //        Console.WriteLine("four");
            //        break;
            //    case 5:
            //        Console.WriteLine("Five");
            //        break;
            //    default:
            //        Console.WriteLine("Other Numbers");
            //        break;

            //}

            //Console.WriteLine("Enter Name Of Number: ");
            //string strName = Console.ReadLine();

            //switch (strName)
            //{
            //    case "zero":
            //        Console.WriteLine(0);
            //        break;
            //    case "one":
            //        Console.WriteLine(1);
            //        break;
            //    case "two":
            //        Console.WriteLine(2);
            //        break;
            //    case "three":
            //        Console.WriteLine(3);
            //        break;
            //    case "four":
            //        Console.WriteLine(4);
            //        break;
            //    default:
            //        Console.WriteLine("other name please");
            //        break;


            //}

            //Console.WriteLine("Enter the product number: ");
            //int proNum = int.Parse(Console.ReadLine());

            //switch(proNum)
            //{
            //    case 1:
            //    case 4:
            //        Console.WriteLine("Price is 500");
            //        break;
            //    case 2:
            //    case 3:
            //        Console.WriteLine("Price is 550");
            //        break;
            //    case 5:
            //        Console.WriteLine("Price is 600");
            //        break;
            //    case 6:
            //        Console.WriteLine("Price is 650");
            //        break;
            //    case 7:
            //        Console.WriteLine("Price is 700");
            //        break;
            //    default:
            //        Console.WriteLine("Product " + proNum + " Not Found!");
            //        break;


            //}


            Console.WriteLine("Enter The Product :");
            string strPro = Console.ReadLine();

            switch(strPro)
            {
                case "1":
                case "nokia":
                    Console.WriteLine("Price is 900");
                    break;
                case "2":
                case "lenovo":
                    Console.WriteLine("Price is 1200");
                    break;
                case "3":
                case "lg":
                    Console.WriteLine("Price is 1500");
                    break;
                case "4":
                case "iphone":
                    Console.WriteLine("Price is 2000");
                    break;
                case "5":
                case "htc":
                    Console.WriteLine("Price is 2100");
                    break;
                default:
                    Console.WriteLine("Product " + strPro + " Not Found");
                    break;

            }

        }
    }
}
