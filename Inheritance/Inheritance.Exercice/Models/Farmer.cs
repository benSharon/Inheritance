using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Exercice.Models
{
    class Farmer : Villager
    {
        public Farmer(int nbEmeraldsOfFarmer) : base()
            => NbEmeralds = nbEmeraldsOfFarmer;

        public void PlantSeeds()
            => Console.WriteLine("Farmer is planting seeds.");

        public void HarvestSeeds()
            => Console.WriteLine("Farmer is harvesting seeds.");

        public override void PrintNbEmeralds()
            => Console.WriteLine($"Farmer's emeralds are now of {NbEmeralds}.");
    }
}
