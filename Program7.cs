using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s, a, b;
            char r;
            a = int.Parse(Console.ReadLine());
            r = Console.ReadKey().KeyChar;
            b = int.Parse(Console.ReadLine());


            if (r == '*')
                s = a * b;
            else if (r == '/')
                s = a / b;
            else if (r == '+')
                s = a + b;
            else if (r == '-')
                s = a - b;
            Console.WriteLine('s');
            Console.ReadLine();
        }
    }
}
