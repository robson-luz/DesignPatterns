using Observer.Publisher.Common;

namespace Observer.Interfaces
{
    public interface ISensor
    {
        void Update(ElectricalDevice electricalDevice);
    }
}
