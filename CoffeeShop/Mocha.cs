using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop
{
    public class Mocha : IBeverage
    {
        private readonly IBeverage _beverage;

        public Mocha(IBeverage beverage)
        {
            _beverage = beverage;
        }
        public string Description => _beverage.Description + ", Mocha";

        public double Cost()
        {
            return  _beverage.Cost() + 0.20;
        }
    }
}
