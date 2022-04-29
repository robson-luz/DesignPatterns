using Strategy.Strategies;

namespace Strategy
{
    public static class DiscountExecutor
    {
        public static void Execute()
        {
            Console.WriteLine("--- Strategy Example ---");

            var twentyFiveDiscount = new TwentyFiveDiscount();
            var fiftyDiscount = new FiftyDiscount();
            var noDiscount = new NoDiscount();

            var items = new List<Item>()
            {
                new Item(
                    "Item 1",
                    100,
                    twentyFiveDiscount
                ),
                new Item(
                    "Item 2",
                    150,
                    fiftyDiscount
                ),
                new Item(
                    "Item 3",
                    75,
                    noDiscount
                )
            };

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} - ${item.Price}, discount: {item.DiscountPrice()}");
            }
        }
    }
}
