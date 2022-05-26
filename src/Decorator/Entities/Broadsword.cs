using Decorator.Entities.Common;

namespace Decorator.Entities
{
    public class Broadsword : Sword
    {
        public Broadsword(double baseDamage) 
        {
            BaseDamage = baseDamage;
        }
    }
}
