namespace CoffeeShop
{
    public class Soy : IBeverage
    {
        private readonly IBeverage _beverage;

        public Soy(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string Description => _beverage.Description + ", Soy";

        public double Cost()
        {
            return _beverage.Cost() + 0.30;
        }
    }
}
