using System;

namespace ProjectInsane.Classes
{
  public class Weapon
  {
    public string Name { get; set; }
    public int Price { get; set; }
    public int AttackBonus { get; set; }

    public Weapon(string name, int attackBonus)
    {
      Name = name;
      AttackBonus = attackBonus;
      Price = attackBonus * 10;
    }
        public Weapon() { }
    }
}