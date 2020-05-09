using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop
{
    public class DarkRoast : IBeverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast";
        }

        public string Description { get; }
        public double Cost()
        {
            return 0.99;
        }
    }
}
