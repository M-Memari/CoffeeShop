using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop
{
    public class Mocha : Condiment
    {
        public Mocha(IBeverage beverage) : base(beverage, "Mocha", 0.50)
        {
        }
    }
}
