using System;

namespace ProjectInsane.Classes
{
  public class Armor
  {
    public string Name { get; set; }
    public int Price { get; set; }
    public int DefenseBonus { get; set; }

    public Armor(string name, int defenseBonus)
    {
      Name = name;
      DefenseBonus = defenseBonus;
      Price = defenseBonus * 10;
    }
        public Armor() { }
    }
}