using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProduct> cart = new List<IProduct>
            {
                new Product {Title = "Hard drive"},
                new Product {Title = "T-Shirt"},
                new Product {Title = "Chocolate box"},
                new DigitalProduct {Title = "Online game"}
                
            };

            Customer customer = new Customer
            {
                FirstName = "Iyad"
            };

            foreach (var product in cart)
            {
                product.ShipItem(customer);
            }


            Console.ReadLine();
        }
    }
}
