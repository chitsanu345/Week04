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
            int n = 123456789;
            Console.WriteLine("{0, 20:E}", 1);
            Console.WriteLine("{0, 20:F}", 1);
            Console.WriteLine("{0, 20:G}", 1);
            Console.WriteLine("{0, 20:N}", 1);
            Console.WriteLine("{0, 20:P}", 1);
            Console.WriteLine("{0, 20:X}", 1);
        }
    }
}
