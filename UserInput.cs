using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER YOUR NAME : ");
            String Name = Console.ReadLine();
            Console.WriteLine("ENTER YOUR AGE :");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is  " + Name);
            Console.WriteLine("Your age is " + Age);

        }
    }
}
