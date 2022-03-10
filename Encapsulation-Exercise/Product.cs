using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;
        public Product(string _name, decimal _cost)
        {
            this.Name = _name;
            this.Cost = _cost;
        }
        public string Name
        {
            get => name;
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"Name cannot be empty");
                    Environment.Exit(0);
                }
                name = value;
            }
        }
        public decimal Cost
        {
            get => this.cost;
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine($"Money cannot be negative");
                    Environment.Exit(0);

                }
                this.cost = value;
            }
        }

    }
}
