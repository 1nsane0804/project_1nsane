using System;

namespace ProjectInsane.Classes
{
  public class Player
  {
    public string Name { get; set; }
    public int Level { get; set; } = 1;
    public int LevelCup { get; set; } = 100;
    public int Experience { get; set; } = 0
    
    // Core attributes
    public int Strength { get; set; } = 10;
    public int Endurance { get; set; } = 10;
    public int Agility { get; set; } = 10;
    public int Intelligence { get; set; } = 10;

    // Derived attributes
    public int Health { get => Endurance * 10; }
    public int MaxHealth { get => Endurance * 10; }
    public int Mana { get => Intelligence * 5; }
    public int MaxMana { get => Intelligence * 5; }
    
    public int Gold { get; set; } = 100;
    public Weapon? Weapon { get; set; }
    public Armor? Armor { get; set; }
    
    public double CriticalChance { get => Agility * 0.5; }

    public int CalculateAttackPower() 
    {
      return Strength + (Weapon?.AttackBonus ?? 0);
    }

    public int CalculateDefense() 
    {
      return Agility + (Armor?.DefenseBonus ?? 0);
    }

    public void LevelUp()
    {
      Level++;
      Strength += 2;
      Endurance += 2;
      Agility += 2;
      Intelligence += 2;
    }
  }
}