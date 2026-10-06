namespace RefactoringLab;

public class ShippingCostCalculator
{
    private readonly IShipping _shipping;

    public ShippingCostCalculator(IShipping shipping)
    {
        _shipping = shipping;
    }
    public decimal Calculate(decimal weightkg)
    {
        return _shipping.Calculate(weightkg);
    }
}
public interface IShipping
{
    decimal Calculate(decimal weightKg);
}
public class AramexShippin : IShipping
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 12m;
    }
}
public class FedExShipping : IShipping
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 15m;
    }
}
public class DHLShipping : IShipping
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 18m;
    }
}
public class PostaShipping : IShipping
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 10m;
    }
}