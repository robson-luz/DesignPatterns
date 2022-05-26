using Decorator.Decorators.Common;
using Decorator.Entities.Common;

namespace Decorator.Decorators
{
    public class FireGreaseDecorator : SwordDecorator
    {
        public FireGreaseDecorator(Sword sword)
            : base(sword)
        {
            FireDamage += 50;
        }

        public override double CalculateDamage()
            => base.CalculateDamage() * 1.2;

        public override string GetStatusEffect()
            => $"Fire {base.GetStatusEffect()}";
    }
}
