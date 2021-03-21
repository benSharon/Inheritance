# Inheritance - Exercice

## Instructions

1.- Create a class Villager
| Properties | Value |
| ---------- | --------------------------- |
| TradeCost | Set to 5 in the constructor |
| NbEmeralds | Set to 0 in the constructor |

| Method name     | Implementation                                                                 |
| --------------- | ------------------------------------------------------------------------------ |
| Trade           | The nbEmeralds increases by the tradeCost and prints "Trade successfully done" |
| PrintNbEmeralds | Prints "Villager's emeralds are now of {nbEmeralds}."                          |

2.- Create a class Farmer that inherits from Villager with the following methods:

| Method name  | Implementation                        |
| ------------ | ------------------------------------- |
| PlantSeeds   | Prints "Villager is planting seeds"   |
| HarvestSeeds | Prints "Villager is harvesting seeds" |

3.- For the Farmer, create a constructor that takes the nbEmeralds to assign at creation

4.- Create a class WeaponSmith that inherits from Villager with the following methods:

| Method name | Implementation                        |
| ----------- | ------------------------------------- |
| CraftWeapon | Prints "Villager is crafting weapon"  |
| Attack      | Prints "Villager is attacking zombie" |

5.- For the WeaponSmith, increase the tradeCost of the WeaponSmith to be of 10;

6.- Create at least an instance of each created class

7.- Create a small program that uses all methods implemented
