using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program4
    {
        static void Main()
        {
            //user have to guess the secret number
            //keep asking the user to guess until 
            //the user is able to guess the secret number
            Random rnd = new Random();
            int secret = rnd.Next(10); // 0<=secret<10
            
            int number; //do not have to set initial value. because the loop will be
                        //executed at least once
            do
            {
                Console.Write("Please guess a number: ");
                number = int.Parse(Console.ReadLine());

                if (number != secret)
                {
                    Console.WriteLine("Wrong try again!");
                }
            } while (number != secret);

            Console.WriteLine("Congratulations. You've guessed it");
        }
    }
}
