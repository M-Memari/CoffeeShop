namespace CoffeeShop
{
    public class Espresso : IBeverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }
        public string Description { get; }
        public double Cost()
        {
            return 1.99;
        }
    }
}
