using Observer.Interfaces;
using Observer.Publisher.Common;

namespace Observer.Subscriber
{
    public class Sensor : ISensor
    {
        public decimal Measurement { get; set; }
        public bool Alarmed { get; set; }

        public void Update(ElectricalDevice electricalDevice)
        {
            Measurement = electricalDevice.Temperature;

            if (Measurement > 100)
            {
                Console.WriteLine($"Measurement {Measurement} triggered the alarm.");
                Alarmed = true;
            }
        }
    }
}
