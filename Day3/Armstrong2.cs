using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Armstrong2
    {
        static void Main()
        {
            //we get number from user
            Console.Write("Please enter a 3 digits number: ");
            int number = int.Parse(Console.ReadLine());

            //compare
            //if they are the same it's armstrong else it's not, print the output
            if ((int)(Math.Pow(number % 10, 3) + Math.Pow((number / 10) % 10, 3)
                + Math.Pow(number / 100, 3)) == number)
            {
                Console.WriteLine("It's an Armstrong number");
            } else
            {
                Console.WriteLine("It's NOT an Armstrong number");
            }
            /*
            if ((int)(Math.Pow(number % 10, 3) + Math.Pow((number / 10) % 10, 3)
                + Math.Pow(number / 100, 3)) == number)

            int a = (int)(Math.Pow(number % 10, 3) + Math.Pow((number / 10) % 10, 3)
                + Math.Pow(number / 100, 3))
            if (a == number)

            b = Math.Pow(number % 10, 3) + Math.Pow((number / 10) % 10, 3)
                + Math.Pow(number / 100, 3)
            a = (int)(b)

            when executing b:
            1. Math.Pow(number % 10, 3)
            2. Math.Pow((number / 10) % 10, 3)
            3. Math.Pow(number / 100, 3)

            Let's take no 2. when executing 2.
            - (number / 10)
            - (number / 10) % 10
            - Math.Pow((number / 10) % 10, 3)
            */

        }
    }
}
