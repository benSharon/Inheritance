using Inheritance.Tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------
            Console.WriteLine("--- WEAPON ---");
            Console.WriteLine();

            Weapon weapon = new Weapon(20, 5);
            Console.WriteLine(weapon.ToString());
            Console.WriteLine();

            weapon.Attack();
            weapon.Attack();
            
            weapon.Repair(); 
            weapon.Attack();

            //---------------------------------------------
            Console.WriteLine();
            Console.WriteLine("--- SWORD ---");
            Console.WriteLine();

            Sword sword = new Sword(10, 3, 4);
            Console.WriteLine(sword.ToString());
            Console.WriteLine();

            sword.Repair();
            sword.Attack();
            sword.Repair();

            //---------------------------------------------
            Console.WriteLine();
            Console.WriteLine("--- SCYTHE ---");
            Console.WriteLine();

            Scythe scythe = new Scythe(15, 1);
            Console.WriteLine(scythe.ToString());
            Console.WriteLine();

            scythe.Attack();
            scythe.Attack();
            scythe.Repair();

            Console.ReadKey();
        }
    }
}
