using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExample05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float a = 0.1f;
            float b = 0.2f;
            float c = 0.3f;
            Console.WriteLine(a + b == c);

            Console.WriteLine(1 / 2);
            Console.WriteLine(1.0 / 2.0);

            Console.WriteLine(1 / 2 * Math.Sin(Math.PI / 6.0));   //sin(30)=1/2
            Console.WriteLine(1.0 / 2.0 * Math.Sin(Math.PI / 6.0));   //sin(30)=1/2

            decimal x = 0.1m;
            decimal y = 0.2m;
            decimal z = 0.3m;
            Console.WriteLine(x + y == z);
        }
    }
}