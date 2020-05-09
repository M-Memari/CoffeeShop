namespace CoffeeShop
{
    public abstract class Condiment : IBeverage
    {
        private readonly IBeverage _beverage;

        protected Condiment(IBeverage beverage, string name, double price)
        {
            _beverage = beverage;
            Name = name;
            Price = price;
        }

        public string Description => _beverage.Description + $" {Name}";
        private string Name { get; }

        private  double Price { get; } 

        public double Cost()
        {
            return  _beverage.Cost() + Price ;
        }
    }
}
