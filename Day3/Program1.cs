using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program1
    {
        static void Main()
        {
            ////WHILE LOOP VERSION

            ////loop until user enter 3 digits number
            //int number = 0;
            //while (number < 100 || number > 999)
            //{
            //    Console.Write("Please enter a 3 digits number: ");
            //    number = int.Parse(Console.ReadLine());

            //    if (number <100 || number > 999)
            //    {
            //        Console.WriteLine("Error, you didnt enter a 3 digits number");
            //    }
            //}
            //Console.WriteLine("You have entered a 3 digits number");


            //Do WHILE LOOP VERSION

            //loop until user enter 3 digits number
            int number; //do not have to set initial value. because the loop will be
                        //executed at least once
            do
            {
                Console.Write("Please enter a 3 digits number: ");
                number = int.Parse(Console.ReadLine());

                if (number < 100 || number > 999)
                {
                    Console.WriteLine("Error, you didnt enter a 3 digits number");
                }
            } while (number < 100 || number > 999);

            Console.WriteLine("You have entered a 3 digits number");
        }
    }
}
