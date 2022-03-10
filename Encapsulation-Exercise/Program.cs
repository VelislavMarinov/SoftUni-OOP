using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new Dictionary<string, Person>();
            var products = new Dictionary<string, decimal>();
            
            string[] personArray = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);


            string[] productsList = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);


            foreach (var item in personArray)
            {
               

                string[] splited = item.Split('=');
                string name = splited[0];
                decimal money = decimal.Parse(splited[1]);
                persons.Add(name, new Person(name, money));
            }
            foreach (var item in productsList)
            {
                
                string[] splited = item.Split('=');
                string name = splited[0];
                decimal money = decimal.Parse(splited[1]);
                if(money < 0)
                {
                    Console.WriteLine($"Money cannot be negative");
                    Environment.Exit(0);
                }
                products.Add(name, money);

            }

            string comand = Console.ReadLine();
            while (comand != "END")
            {
                string[] splitedComand = comand.Split();
                string personName = splitedComand[0];
                string productName = splitedComand[1];
                foreach (var person in persons)
                {
                    if (person.Key == personName)
                    {
                        person.Value.Add(productName, products[productName]);
                    }
                }
                comand = Console.ReadLine();

            }

            foreach (var item in persons)
            {
                if(item.Value.BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{item.Key} - Nothing bought");
                    continue;
                }
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value.BagOfProducts)}");
            }




        }
    }
}
