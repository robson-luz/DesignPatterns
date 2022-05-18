using Observer.Interfaces;
using Observer.Subscriber;

namespace Observer.Publisher.Common
{
    public abstract class ElectricalDevice
    {
        public string Name { get; set; }
        public decimal Temperature { get; private set; }

        private List<ISensor> subscribers = new List<ISensor>();

        public ElectricalDevice(string name, decimal temperature)
        {
            Name = name;
            Temperature = temperature;
        }

        public void SetTemperature(decimal temperature)
        {
            Console.WriteLine($"Temperature changed from {Temperature} to {temperature}.");
            Temperature = temperature;            

            Notify();
        }

        public void Subscribe(Sensor subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Unsubscribe(Sensor subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void Notify()
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Update(this);
            }
        }
    }
}
