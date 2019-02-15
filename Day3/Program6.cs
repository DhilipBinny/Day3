using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program6
    {
        static void Main()
        {
            //reverse a string
            string input = "Hello world!";

            //output string would have the same length as original string
            //loop from 0 to length of the string
            //    copy the character starting from the end of the string

            //loop from index = 0 to length of the string - 1  
            //    copy the i-th character starting from the end of the string

            int len = input.Length;
            //loop from index = 0 to length of the string - 1 
            string output = "";
            for (int index=0; index <=len-1; index++)
            {
                //copy the i-th character starting from the end of the string
                //example: string is Hello (5 chars) index 0-4
                // if index = 0, i want to take "o" -> index = 4
                // when index = 0, i need a formula that return 4
                // formula: len - 1 - index -> 5 - 1 - 0
                output = output + input.Substring(len - 1 - index, 1).ToUpper();
            }

            Console.WriteLine(output);
        }
    }
}
