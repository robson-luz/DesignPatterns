using Strategy.Interfaces;

namespace Strategy
{
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public IDiscountStrategy DiscountStrategy { get; set; }

        public Item(
            string name, 
            double price,
            IDiscountStrategy discountStrategy
        )
        {
            Name = name;
            Price = price;

            DiscountStrategy = discountStrategy;
        }

        public double DiscountPrice()
            => DiscountStrategy.GetDiscount(Price);
    }
}
