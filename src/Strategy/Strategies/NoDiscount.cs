using Strategy.Interfaces;

namespace Strategy.Strategies
{
    public class NoDiscount : IDiscountStrategy
    {
        public double GetDiscount(double value)
            => value;
    }
}
