namespace CoffeeShop
{
    public class Milk : IBeverage
    {
        private readonly IBeverage _beverage;

        public Milk(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string Description => _beverage.Description + ", Milk";

        public double Cost()
        {
            return _beverage.Cost() + .10;
        }
    }
}
