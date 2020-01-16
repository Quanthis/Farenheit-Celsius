using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.WriteLine("Tell me tempereture in Fahrenheit");
            F = double.Parse(Console.ReadLine());
            C = 5d / 9 * (F - 32);
            Console.WriteLine(C);
            Console.ReadKey();

        }
    }
}
