using System;

namespace ProjectInsane.Classes
{
  public class Enemy
  {
    public string Name { get; set; }
    public int Level { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int RewardGold { get; set; }
    public int RewardXP { get; set; }
    public string? SpecialAbility { get; set; }

    public static Enemy GenerateEnemy(int playerLevel)
    {
      Random random = new Random();
      int enemyLevel = Math.Max(1, playerLevel + random.Next(-1, 2));

      return new Enemy 
      {
        Name = "Enemy " + enemyLevel,
        Level = enemyLevel,
        Attack = enemyLevel * 5,
        Defense = enemyLevel * 3,
        Health = enemyLevel * 20,
        MaxHealth = enemyLevel * 20,
        RewardGold = enemyLevel * 10,
        RewardXP = enemyLevel * 15,
        SpecialAbility = random.Next(2) == 0 ? "Heal" : "PowerStrike"
      };
    }
  }
}