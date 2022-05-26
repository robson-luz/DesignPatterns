using Decorator.Decorators.Common;
using Decorator.Entities.Common;

namespace Decorator.Decorators
{
    public class PoisonGreaseDecorator : SwordDecorator
    {
        public PoisonGreaseDecorator(Sword sword) : base(sword)
        {
            BaseDamage -= 20;
            FireDamage -= 20;
            LightningDamage -= 20;
            PoisonDamage += 100;
        }

        public override double CalculateDamage()
            => base.CalculateDamage() * 0.9;
        
        public override string GetStatusEffect()
        {
            return $"Poison {base.GetStatusEffect()}";
        }
    }
}
