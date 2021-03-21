using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Exercice.Models
{
    class Villager
    {
        private const int DEFAULT_TRADE_COST = 5;

        //An empty int variable or property will always (automatically) have a value of zero.
        public int TradeCost { get; set; }
        public int NbEmeralds { get; set; }

        public Villager()
            => TradeCost = DEFAULT_TRADE_COST;

        public void Trade()
        {
            NbEmeralds += TradeCost;
            Console.WriteLine("Trade successfully completed.");
        }

        public virtual void PrintNbEmeralds()
            => Console.WriteLine($"Villager's emeralds are now of {NbEmeralds}.");
    }
}
