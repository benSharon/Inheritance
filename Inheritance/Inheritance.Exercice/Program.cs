using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Exercice.Models;

namespace Inheritance.Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            var villager = new Villager();
            Console.WriteLine("--- VILLAGER ---");
            Console.WriteLine($"Original value of Villager's NbEmeralds: {villager.NbEmeralds}");
            villager.Trade();
            villager.PrintNbEmeralds();
            Console.WriteLine();

            var farmer = new Farmer(10);
            Console.WriteLine("--- FARMER ---");
            Console.WriteLine($"Original value of Farmer's NbEmeralds: {farmer.NbEmeralds}");
            farmer.Trade();
            farmer.PrintNbEmeralds();
            farmer.PlantSeeds();
            farmer.HarvestSeeds();
            Console.WriteLine();

            Console.WriteLine("--- WEAPONSMITH ---");
            var weaponSmith = new WeaponSmith();
            weaponSmith.CraftWeapon();
            weaponSmith.Attack();
            Console.WriteLine($"Original value of Farmer's NbEmeralds: {weaponSmith.NbEmeralds}");
            weaponSmith.Trade();
            weaponSmith.PrintNbEmeralds();
            Console.WriteLine();
        }
    }
}
