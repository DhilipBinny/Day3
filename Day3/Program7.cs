using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program7
    {
        static void Main()
        {
            //too many spaces in between
            //remove them!
            string s = "    institute    of   systems     science   ";

            string[] sArr = s.Split();

            //create an empty output string
            //loop through sArr
            //      if that element is not an empty string, append to the output string
            string output = "";
            for (int i=0; i<sArr.Length; i++)
            {
                if (sArr[i] != "")
                {
                    output = output + sArr[i] + " " ;
                }
            }

            output = output.Trim();
            Console.WriteLine(output);

            string t = "John|19-Dec|$20";
            string[] tArr = t.Split('|');
            Console.WriteLine(tArr[2]); //display $20
        }
    }
}
