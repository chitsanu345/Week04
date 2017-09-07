using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            const double i = 123.456789d;
            Console.WriteLine("{0:F1}", i);
            Console.WriteLine("{0:F2}", i);
            Console.WriteLine("{0:F3}", i);
            Console.WriteLine("{0:F4}", i);
            Console.WriteLine("{0:F5}", i);
        }
    }
}
