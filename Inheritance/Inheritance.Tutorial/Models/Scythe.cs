using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Tutorial.Models
{
    public class Scythe : Weapon
    {
        public const int SPIN_DAMAGE = 100;
        public Scythe(int damage, int durability) : base(damage, durability) { }
        public override void DisplayAttack()
            => Console.WriteLine($"Attacking with scythe slice!! Dealt: {Damage} damage");

        public void SpinAttack()
        {
            Console.WriteLine($"Spin spin spinning around! Dealt: {SPIN_DAMAGE} damage");
            Console.WriteLine($"No durability cost. Durability is still at {Durability}/{MaxDurability}.");
            Console.WriteLine();
        }
    }
}
