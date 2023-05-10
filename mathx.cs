using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Math.Max(5, 10); // highest value of a
            Console.WriteLine("highest value of a is " + a);

            int y = Math.Min(5, 10); // lowest value of y
            Console.WriteLine("lowest value of y is "+y);

            double z = Math.Sqrt(64);
            Console.WriteLine("square root of z is "+z); // square root of z

            double x = Math.Abs(-4.7); // absolute value of x
            Console.WriteLine("absolute value of x is "+x);

            double d = Math.Round(9.99); // number to the nearest
            Console.WriteLine("number to the nearest is "+ d);


            
        }
    }
}
