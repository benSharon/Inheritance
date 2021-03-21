using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Tutorial.Models
{
    public class Weapon
    {
        public int Damage { get; }
        public int MaxDurability { get; }
        public int Durability { get; set; }
        public bool IsBroken { get { return Durability == 0; } }

        public Weapon(int damage, int durability)
        {
            Damage = damage;
            MaxDurability = durability;
            Durability = durability;
        }

        #region Actions
        public void Attack()
        {
            if (IsBroken)
                DisplayBrokenWeaponMessage();
            else
            {
                Durability--;
                DisplayAttack();
                Console.WriteLine($"Durability dicreases by one ({Durability}/{MaxDurability}).");
            }
            Console.WriteLine();
        }

        public void Repair()
        {
            if (IsBroken)
                DisplayBrokenWeaponMessage();
            else if (Durability >= MaxDurability)
                Console.WriteLine($"Durability is already at its maximum of {MaxDurability}.");
            else
            {
                Durability++;
                Console.WriteLine($"Durability increased by one. Currently at {Durability}/{MaxDurability}");
            }
            Console.WriteLine();
        }
        #endregion

        #region DisplayMethods
        public virtual void DisplayAttack()
            => Console.WriteLine($"Attacking ennemy... Dealt {Damage} damage");

        public void DisplayBrokenWeaponMessage()
            => Console.WriteLine("Weapon's broken and cannot be repaired :c");

        public override string ToString()
            => $"Damage: {Damage}\nDurability: {Durability}";
        #endregion
    }
}
