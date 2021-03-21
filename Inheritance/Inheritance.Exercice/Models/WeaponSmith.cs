using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Exercice.Models
{
    class WeaponSmith : Villager
    {
        public WeaponSmith() : base()
            => TradeCost = 10;
        public void CraftWeapon()
            => Console.WriteLine("WeaponSmith is crafting weapon.");

        public void Attack()
            => Console.WriteLine("WeaponSmith is attacking zombie.");

        public override void PrintNbEmeralds()
            => Console.WriteLine($"WeaponSmith's emeralds are now of {NbEmeralds}.");
    }
}
