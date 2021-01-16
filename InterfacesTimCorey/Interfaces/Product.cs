using System;

namespace Interfaces
{
    public interface IProduct
    {
        string Title { get; set; }
        bool HasBeenShipped { get; }
        void ShipItem(Customer customer);
    }
    public class DigitalProduct : IProduct
    {
        public string Title { get; set; }
        public bool HasBeenShipped { get; private set; }

        public int TotalDownloadsLeft { get; private set; } = 5;

        public void ShipItem(Customer customer)
        {
            if (HasBeenShipped == false)
            {
                Console.WriteLine($"Stimulating emailing {Title} to {customer.FirstName}");
                TotalDownloadsLeft -= 1;
                if (TotalDownloadsLeft < 1)
                {
                    HasBeenShipped = true;
                    TotalDownloadsLeft = 0;
                }
            }
        }
    }
    public class Product : IProduct
    {
        public string Title { get; set; }
        public bool HasBeenShipped { get; private set; }

        public void ShipItem(Customer customer)
        {
            if (HasBeenShipped == false)
            {
                Console.WriteLine($"Stimulating shipping {Title} to {customer.FirstName}");
                HasBeenShipped = true;
            }
        }
    }
}
