namespace CoffeeShop
{
    public class HouseBlend : IBeverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }
        public string Description { get;  }
        public double Cost()
        {
            return .89;
        }
    }
}
