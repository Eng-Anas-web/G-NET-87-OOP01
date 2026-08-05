using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    public struct DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuildNumber;

        public DeliveryAddress(string city ,string street ,int buildNumber)
        {
            City = city;
            Street = street;
            BuildNumber = buildNumber;
        }

        public string GetFullAddress()
        {
            return $"{City} , {Street} , {BuildNumber}";
        }
    }
}
