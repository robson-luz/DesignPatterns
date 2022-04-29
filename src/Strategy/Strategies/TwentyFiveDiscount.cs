using Strategy.Interfaces;

namespace Strategy.Strategies
{
    public class TwentyFiveDiscount : IDiscountStrategy
    {
        public double GetDiscount(double value)
            => value - (value * 0.25);
    }
}
