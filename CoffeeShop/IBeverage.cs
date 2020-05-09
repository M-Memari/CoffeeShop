namespace CoffeeShop
{
    public interface IBeverage
    {
        string Description { get; }
        double Cost();
    }
}
