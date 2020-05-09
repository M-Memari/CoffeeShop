namespace CoffeeShop
{
    public class Milk : Condiment
    {
        public Milk(IBeverage beverage) : base(beverage, "Milk", 0.30)
        {
        }
    }
}
