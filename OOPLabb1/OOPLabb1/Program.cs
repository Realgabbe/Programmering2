using System;
using System.Collections.Generic;

namespace OOPLabb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cider cider = new Cider();
            Customer customer = new Customer();

            Console.WriteLine("Welcome customer! Please type in your name.");
            customer.Name = Console.ReadLine();

            Console.WriteLine("Hello " + customer.Name + "! How many cider do you want to buy?");
            cider.Amount = Convert.ToInt32(Console.ReadLine());
            customer._cart.Add(cider);
            Console.WriteLine("Ordered " + cider.Amount + " cans of cider. Here's a list of current orders:");

            foreach (var Product in customer._cart)
            {
                Console.WriteLine(customer.Name + " has currently ordered " + cider.Amount + " cans of cider");
            }
        }
    }
}
