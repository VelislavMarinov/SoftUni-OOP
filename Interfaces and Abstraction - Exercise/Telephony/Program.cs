using System;
using System.Linq;

namespace PhoneManufacturer
{
    public interface ICalable
    {
        void Call(string phone);
    }
    public interface IReadPages
    {
        void WebsiteReader(string website);
    }
    public class Program
    {

        static void Main(string[] args)
        {
            string[] phones = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();
            var smartphone = new Smartphone();
            var phone = new StationaryPhone();



            for (int i = 0; i < phones.Length; i++)
            {
                bool isNotValid = false;
                string current = phones[i];
                for (int j = 0; j < phones[i].Length; j++)
                {
                    string curent = phones[i];
                    if (!char.IsDigit(curent[j]))
                    {
                        isNotValid = true;
                        break;
                    }
                }
                if (isNotValid)
                {
                    Console.WriteLine($"Invalid number!");
                    continue;
                }
                if (phones[i].Length == 7)
                {
                    phone.Call(current);
                    continue;


                }
                else
                {
                    smartphone.Call(current);
                }

            }

            for (int i = 0; i < websites.Length; i++)
            {
                string current = websites[i];
                bool isNotValid = false;
                for (int j = 0; j < current.Length; j++)
                {
                    if (char.IsDigit(current[j]))
                    {
                        isNotValid = true;
                        break;
                    }
                }
                if (isNotValid)
                {
                    Console.WriteLine($"Invalid URL!");
                    continue;
                }
                smartphone.WebsiteReader(current);
            }
        }
    }
}
