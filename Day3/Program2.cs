using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program2
    {
        static void Main()
        {
            ////count from 1 - 10
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 10);

            //for loop using j
            for (int j = 1; j <= 10; j++) //j starts from 1 to 10 increment by 1
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("--------------");

            //1,3,5,7,9
            for (int j = 1; j <= 10; j = j + 2) //j starts from 1 to 10 increment by 2
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("--------------");

            //counting down
            for (int j = 10; j >= 1; j--) //j starts from 1 to 10 increment by 1
            {
                Console.WriteLine(j);
            }
        }
    }
}
