namespace Decorator.Entities.Common
{
    public abstract class Sword
    {
        public double BaseDamage { get; set; }
        public double FireDamage { get; set; }
        public double LightningDamage { get; set; }
        public double PoisonDamage { get; set; }

        public virtual double CalculateDamage()
            => BaseDamage + FireDamage + LightningDamage + PoisonDamage;

        public virtual string GetStatusEffect()
            => "";
    }
}
