using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    class Person
    {
        private decimal money;
        private string name;
        public List<string> BagOfProducts { get; set; }
        public Person(string _name, decimal _money)
        {
            this.Money = _money;
            this.Name = _name;
            BagOfProducts = new List<string>();

        }
        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"Name cannot be empty");
                    Environment.Exit(0);
                }
                name = value;
            }
        }
        public decimal Money
        {
            get => money;

            private set 
            { 
                if(value < 0)
                {
                    Console.WriteLine($"Money cannot be negative");
                    Environment.Exit(0);

                }
                money = value; 
            }
        }
        
        public void Add(string name, decimal cost)
        {
            if(this.money >= cost)
            {
                BagOfProducts.Add(name);
                money -= cost;
                Console.WriteLine($"{this.name} bought {name}");
            }
            else
            {
                Console.WriteLine($"{this.name} can't afford {name}");
            }
        }

    }
}
