using Decorator.Entities.Common;

namespace Decorator.Decorators.Common
{
    public class SwordDecorator : Sword
    {
        private readonly Sword _sword;

        public SwordDecorator(Sword sword)
        {
            _sword = sword;

            BaseDamage = sword.BaseDamage;
            FireDamage = sword.FireDamage;
            LightningDamage = sword.LightningDamage;
            PoisonDamage = sword.PoisonDamage;
        }
        
        public override double CalculateDamage()
            => _sword.CalculateDamage();

        public override string GetStatusEffect()
            => _sword.GetStatusEffect();
    }
}
