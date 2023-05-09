using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type variableName = value;

            // STRING
            string name = "KIATTIPOOM";
            Console.WriteLine(name);

            // INT & DOUBLE
            int varNum;
            double varDub = 5.5;
            varNum = 0;
            int myNum = 18;
            Console.WriteLine(myNum);
            Console.WriteLine(varNum);
            Console.WriteLine(varDub);

            // BOOL

            bool myBool = false;
            Console.WriteLine(myBool);

            // EXAMPLE

            int Number = 7855;
            double myDouble = 59.555;
            char letter = 'H';
            bool theTrue = true;
            string Text = "Hello, my nickname is Poom";

            Console.WriteLine(Number);
            Console.WriteLine(myDouble);
            Console.WriteLine(letter);
            Console.WriteLine(theTrue);
            Console.WriteLine(Text);


            // CONSTANT

            const int Cnum = 15; // ตัวแปรคงที่ค่า = 15 เสมอ
            Console.WriteLine(Cnum);

            // DISPLAY NAME

            String NickName = "Poom";
            Console.WriteLine("Hello, Im " + NickName );

            String FirtName = "john";
            String LastName = "Wick";
            String FullName = FirtName +" "+ LastName;
            Console.WriteLine( FullName );

            int x = 20;
            int y = 50;

            Console.WriteLine(x+y);

        }  
    }      
}
