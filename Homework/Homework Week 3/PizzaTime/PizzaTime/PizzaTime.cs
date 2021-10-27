using System;
using System.Collections.Generic;

namespace PizzaTime
{
    class Program
    {
        static void Main(string[] args)
        {

            //Setup vars 
            double totalCost = 0;
            double taxRate = 1.1;


            //Calculate pizza size costs

            Console.WriteLine("Choose what size pizza would you like:");
            Console.WriteLine("Type s for a small pizza.");
            Console.WriteLine("Type m for a medium pizza.");
            Console.WriteLine("Type l for a large pizza.");
            var pizzaSize = Console.ReadLine();
            if (String.Equals(pizzaSize, "S", StringComparison.OrdinalIgnoreCase))
            {
                totalCost = 5;
                Console.WriteLine("watching netflix alone tonight? :) ");
            }
            else if (String.Equals(pizzaSize, "M", StringComparison.OrdinalIgnoreCase))
            {
                totalCost = 7;
                Console.WriteLine("ok, throwing a medium party");
            }
            else if (String.Equals(pizzaSize, "L", StringComparison.OrdinalIgnoreCase))
            {
                totalCost = 9;
                Console.WriteLine("Damnnn you must b hungry wanting that large"); 
            }
            else
            {
                Console.WriteLine("Bro you have no idea, you getting a large");
                totalCost = 9;
               
            }

            //Calculate toppings costs
            Console.WriteLine("How many toppings would you like; 0, 1, or 2?");
            var toppings = Console.ReadLine();            
            if (String.Equals(toppings, "0", StringComparison.OrdinalIgnoreCase))
            {
                totalCost += 0;
            }
            else if (String.Equals(toppings, "1", StringComparison.OrdinalIgnoreCase))
            {
                totalCost += 1;
            }
            else if (String.Equals(toppings, "2", StringComparison.OrdinalIgnoreCase))
            {
                totalCost += 1.5;
            }
            else
            {
                Console.WriteLine("Ok you getting ALL the toppings. Please tip. It's gonna be expensive");
                totalCost = totalCost * totalCost;
                Console.WriteLine(totalCost);
            }
            //Join the two
            // This logic was already done above

            //Apply tax

            totalCost = totalCost * taxRate;
            Console.WriteLine(string.Format("Your total cost comes out to be ${0:N2}" ,totalCost));

            Console.WriteLine("Hit any key to close");
            Console.ReadLine();
            Environment.Exit(0);
        }




    }
}
