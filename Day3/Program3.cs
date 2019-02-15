using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program3
    {
        static void Main()
        {
            //draw a triangle of 10 lines
            // *
            // **
            // ***
            // ****
            // *****
            // ******
            Console.Write("Enter how deep is the triangle: ");
            int size = int.Parse(Console.ReadLine());

            // repeat 10 times from x = 1 to 10 and in each repetition I will do:
            //      print x number of *
            for (int x = 1; x <= size; x++)
            {
                //Print X number of *
                for (int i = 1; i <= x; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                //End of printing problem
            }

            ////how do i print 7 *
            //for (int i = 1; i <= 7; i++)
            //{
            //    Console.Write("*");
            //}
            //Console.WriteLine();

        }
    }
}
