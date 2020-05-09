using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop
{
    public class Decaf : IBeverage
    {
        public Decaf()
        {
            Description = "Decaf coffee";
        }
        public string Description { get; }
        public double Cost()
        {
            return 1.05;
        }
    }
}
