using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program5
    {
        static void Main()
        {
            string s = "   Hello   world!   ";
            Console.WriteLine($"*{s}*");
            string t = s.Trim();
            Console.WriteLine($"*{t}*");

            s = "*##*Hello*##*";
            char[] charToBeRemoved = new char[] { '*', '#' };
            Console.WriteLine(s.Trim(charToBeRemoved));

            s = "John";
            t = "Michael";
            Console.WriteLine(s.PadRight(20, '*')+"Student");
            Console.WriteLine(t.PadRight(20, '*')+"Student");
            Console.WriteLine(t.PadLeft(4, ' '));

            s = "Hello";
            Console.WriteLine(s[1]); //return a char
            Console.WriteLine(s.Substring(1, 1)); //return a string
            //s[1] = 'b'; //if you need this, read about StringBuffer


        }

    }
}
