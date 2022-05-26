using Decorator.Decorators;
using Decorator.Entities;
using Decorator.Entities.Common;

Sword broadsword = new Broadsword(50);

broadsword = new FireGreaseDecorator(broadsword);
broadsword = new LightningGreaseDecorator(broadsword);
broadsword = new PoisonGreaseDecorator(broadsword);

Console.WriteLine(broadsword.GetStatusEffect());
Console.WriteLine(broadsword.CalculateDamage());