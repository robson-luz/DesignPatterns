using Decorator.Decorators.Common;
using Decorator.Entities.Common;

namespace Decorator.Decorators
{
    public class LightningGreaseDecorator : SwordDecorator
    {
        public LightningGreaseDecorator(Sword sword) : base(sword)
        {
            LightningDamage += 70;
            BaseDamage -= 10;
        }

        public override double CalculateDamage()
            => base.CalculateDamage() * 2;
        
        public override string GetStatusEffect()
        {
            return $"Lightning {base.GetStatusEffect()}";
        }
    }
}
