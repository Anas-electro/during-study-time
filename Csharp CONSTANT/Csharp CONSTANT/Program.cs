using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_CONSTANT
{
    class Program
    {
        static void Main(string[] args)
        {
            const int months = 12;
            // months = 15; لن يأخد اي قيمة من غير القيمة الأولى 
            const int days = 365;
            const int weeks = 52;
            const double pi = 3.14;
            const int SpeedOfLight = 300000;
            Console.WriteLine(months);
            Console.WriteLine(days);
            Console.WriteLine(weeks);
            Console.WriteLine(pi);
            Console.WriteLine(SpeedOfLight);

        }
    }
}
