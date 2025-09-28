using System;
using System.Collections.Generic;

namespace ProjectInsane.Classes.Generators
{
  public class WeaponGenerator
  {
    private static Random random = new Random();

    private static string[] weaponNames = new string[] 
    {
      "Iron Sword", "Steel Blade", "Rusty Dagger", 
      "Elven Bow", "Battle Axe", "Magic Staff", 
      "Hammer of Might", "Royal Sword", "Warrior's Mace"
    };

    public static Weapon GenerateWeapon(int attackBonus)
    {
      string name = weaponNames[random.Next(weaponNames.Length)];
      int price = CalculatePrice(attackBonus);
      
      return new Weapon
      {
        Name = name,
        Price = price,
        AttackBonus = attackBonus
      };
    }

    public static List<Weapon> GenerateWeapons(int count)
    {
      var weapons = new List<Weapon>();
      
      for (int i = 0; i < count; i++)
      {
        int attackBonus = random.Next(1, 11); // Generate attack bonus between 1-10
        weapons.Add(GenerateWeapon(attackBonus));
      }
      
      return weapons;
    }

    private static int CalculatePrice(int attackBonus)
    {
      return 10 + (attackBonus * 5);
    }
  }
}
  