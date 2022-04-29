using Strategy.Interfaces;

namespace Strategy.Strategies
{
    public class FiftyDiscount : IDiscountStrategy
    {
        public double GetDiscount(double value)
            => value - (value * 0.50);
    }
}
