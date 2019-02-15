using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Armstrong
    {
        static void Main()
        {
            //we get number from user
            Console.Write("Please enter a 3 digits number: ");
            int number = int.Parse(Console.ReadLine());

            //optional: verify if the number contains 3 digits
            //we get 1st, 2nd and 3rd digits
            int digit3 = number % 10;
            int digit2 = (number / 10 ) % 10;
            int digit1 = number / 100;

            //calculate the sum of the digits raised to the power of 3
            int sumOfPower = (int) (Math.Pow(digit3, 3) + Math.Pow(digit2, 3) 
                + Math.Pow(digit1, 3));
            //compare
            //if they are the same it's armstrong else it's not, print the output
            if (sumOfPower == number)
            {
                Console.WriteLine("It's an Armstrong number");
            } else
            {
                Console.WriteLine("It's NOT an Armstrong number");
            }
        }
    }
}
