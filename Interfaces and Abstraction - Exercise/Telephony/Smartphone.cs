using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneManufacturer
{
    public class Smartphone : ICalable, IReadPages
    {
        public void Call(string phone)
        {
            

            Console.WriteLine($"Calling... {phone}");

        }

        public void WebsiteReader(string website)
        {
            Console.WriteLine($"Browsing: {website}!");
        }
    }
}
