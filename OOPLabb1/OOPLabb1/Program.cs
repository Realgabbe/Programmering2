using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace OOPLabb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Pearcider pearcider = new Pearcider();
            Applecider applecider = new Applecider();

            pearcider.Flavor = "Pear";
            applecider.Flavor = "Apple";

            Console.WriteLine(pearcider.GetType().Name);

            Console.WriteLine("Welcome customer! Please type in your name.");
            customer.Name = Console.ReadLine();

            do
            {
                Console.WriteLine("Hello " + customer.Name + "! What flavor of cider would you like to buy? Your choices are: 'Pear' or 'Apple'.");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "pear")
                {
                    Console.WriteLine("How many cans of pear cider would you like to buy?");
                    pearcider.Amount = pearcider.Amount + Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You have ordered " + pearcider.Amount + " cans of " + pearcider.Flavor + " cider in total.");
                    customer._cart.Add(pearcider);
                }
                
                if (answer.ToLower() == "apple")
                {
                    Console.WriteLine("How many cans of apple cider would you like to buy?");
                    applecider.Amount = applecider.Amount + Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You have ordered " + applecider.Amount + " cans of " + applecider.Flavor + " cider in total.");
                    customer._cart.Add(applecider);
                }

                Console.WriteLine("Would you like buy more cider?");
                string repeat = Console.ReadLine();
                if (repeat.ToLower() != "yes")
                {
                    break;
                }
                
            } while (true);

            Console.WriteLine("Would you like to view your cart?");
            string viewcart = Console.ReadLine();
            if(viewcart.ToLower() == "yes")
            {
                Console.WriteLine(customer.Name + " has currently ordered " + pearcider.Amount + " cans of pear cider. " + customer.Name + " has also ordered " + applecider.Amount + " cans of apple cider.");
            }
        }
    }
}
