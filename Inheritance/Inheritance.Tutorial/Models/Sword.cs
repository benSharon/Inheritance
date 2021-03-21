using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Tutorial.Models
{
    public class Sword : Weapon
    {
        public int DamageMultiplier { get; set; }
        public Sword(int damage, int durability, int multiplier) : base(damage, durability)
            => DamageMultiplier = multiplier;

        public override void DisplayAttack()
            => Console.WriteLine($"Attacking with sword swing!! Dealt: {Damage * DamageMultiplier} damage");

        public override string ToString()
            => base.ToString() + $"\nDamage multiplier: {DamageMultiplier}";
    }
}
