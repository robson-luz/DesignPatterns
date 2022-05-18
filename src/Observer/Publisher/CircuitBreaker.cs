using Observer.Publisher.Common;

namespace Observer.Publisher
{
    public class CircuitBreaker : ElectricalDevice
    {
        public CircuitBreaker() 
            : base("Circuit Breaker", 0)
        { }
    }
}
