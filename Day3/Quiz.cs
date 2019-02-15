using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Quiz
    {
        static void Main(string[] args)
        {
            //we set price to $500
            double price = 500;

            //ask for quantity
            Console.WriteLine("Welcome to ISS Gadget Shop \n");
            Console.Write("Number of items to purchase: ");
            string input = Console.ReadLine();
            int quantity = int.Parse(input);

            //calculate the current total amount
            double amount = quantity * price;

            //based on the amount, we calculate the discount
            double discountPct = 0;
            if (amount>2000 && amount <= 3000)
            {
                discountPct = 0.03;
            } else if (amount > 3000 && amount <=6000)
            {
                discountPct = 0.05;
            } else if (amount > 6000)
            {
                discountPct = 0.08;
            } else //not needed as we have initialized our discount to 0%
            {
                discountPct = 0;
            }

            //calculate the final amount
            double total = amount * (1 - discountPct);

            //display the amount
            Console.WriteLine("Please pay ${0:0,0.00}", total);
        }
    }
}
