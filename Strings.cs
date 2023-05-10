using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = "hello im bijan from rov";
            string upperx = text.ToUpper(); // ouptputs HELLO IM BIJAN FROM ROV
            string lowerx = text.ToLower(); // outputs hello im bijan from rov

            Console.WriteLine(upperx);
            Console.WriteLine(lowerx);


            string firstname = "Jongheon";
            string lastname = "Eiei";
            string fullname = firstname + lastname;
            Console.WriteLine(fullname);

            // สามารถใช้ string.Concat() ในการเชื่อมข้อความได้ เช่น
            string name = string.Concat(firstname, lastname);
            Console.WriteLine(name);

            //String Interpolation 
            string fname = "kim";
            string lname = "taox";
            string funame = $"hello ,my name is {fname} {lname}";
            Console.WriteLine(funame);

            //Access Strings
            string txt = "IM AM ";
            Console.WriteLine(txt[0]); // output I
            Console.WriteLine(txt[1]); // output A
            string myString = "Hello";
            Console.WriteLine(myString.IndexOf("l"));// output 2

            

        }
    }
}
