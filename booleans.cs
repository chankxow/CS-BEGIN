using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booleans
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 10;
            int y = 20;
            Console.WriteLine(x > y); // outputs false

            Console.WriteLine(20>10);// outputs true

            int c = 10;
            Console.WriteLine(c == 10); // true

            int myAge = 25;
            int votingAge = 18;
            if(myAge >= votingAge) 
            {
                Console.WriteLine("Old enough to vote!");
            }
            else
            {
                Console.WriteLine("Not old enough to vote.");
            }

            
        }
    }
}
