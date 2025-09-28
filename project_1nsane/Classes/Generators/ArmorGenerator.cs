using System;
using System.Collections.Generic;

namespace ProjectInsane.Classes.Generators
{
  public class ArmorGenerator
  {
    private static Random random = new Random();

    private static string[] armorNames = new string[] 
    {
      "Leather Vest", "Iron Chestplate", "Chainmail", 
      "Plate Armor", "Cloth Robes", "Scale Mail", 
      "Knight's Armor", "Wizard's Robe", "Padded Armor"
    };

    public static Armor GenerateArmor(int defenseBonus)
    {
      string name = armorNames[random.Next(armorNames.Length)];
      int price = CalculatePrice(defenseBonus);
      
      return new Armor
      {
        Name = name,
        Price = price,
        DefenseBonus = defenseBonus
      };
    }

    public static List<Armor> GenerateArmors(int count)
    {
      var armors = new List<Armor>();
      
      for (int i = 0; i < count; i++)
      {
        int defenseBonus = random.Next(1, 11); // Generate defense bonus between 1-10
        armors.Add(GenerateArmor(defenseBonus));
      }
      
      return armors;
    }

    private static int CalculatePrice(int defenseBonus)
    {
      return 10 + (defenseBonus * 5);
    }
  }
}
  