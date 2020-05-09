using System;
using  CoffeeShop;

namespace CoffeeShopSandBox
{
    internal static class Program
    {
        private static void Main()
        {
            
            var myCoffee = new Milk(new Espresso());
            Console.WriteLine($"{myCoffee.Description}: {myCoffee.Cost():F}");
            var newCoffee = new Soy(myCoffee);
            Console.WriteLine($"{newCoffee.Description}: {newCoffee.Cost():F}");
        }
    }
}
