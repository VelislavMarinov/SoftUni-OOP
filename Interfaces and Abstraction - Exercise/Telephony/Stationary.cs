using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneManufacturer
{
    public class StationaryPhone : ICalable
    {
        public void Call(string phone)
        {

            Console.WriteLine($"Dialing... {phone}");
        }
    }
}
