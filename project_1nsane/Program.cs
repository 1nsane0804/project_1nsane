using System;

namespace project_1nsane
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int AttackBonus { get; set; }
    }

    public class Armor
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int DefenseBonus { get; set; }
    }

    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int LevelCap { get; set; }
        public int Experience { get; set; }

        public int Strength { get; set; }
        public int Endurance { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }

        public int Health { get; set; }
        public int MaxHealth => Endurance * 10;
        public int Mana { get; set; }
        public int MaxMana => Intelligence * 5;
        public int Gold { get; set; }

        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }

        public double CriticalChance => Agility * 0.005;

        public Player()
        {
            Level = 1;
            LevelCap = 10;
            Experience = 0;
            Gold = 0;
        }

        public int CalculateAttackPower()
        {
            int weaponBonus = Weapon?.AttackBonus ?? 0;
            return Strength + weaponBonus;
        }

        public int CalculateDefense()
        {
            int armorBonus = Armor?.DefenseBonus ?? 0;
            return Agility + armorBonus;
        }

        public void GainExperience(int amount)
        {
            Experience += amount;
            
        }

        public void TakeDamage(int amount)
        {
            Health = Math.Max(0, Health - amount);
        }

        public void Heal(int amount)
        {
            Health = Math.Min(MaxHealth, Health + amount);
        }

        public void UseMana(int amount)
        {
            Mana = Math.Max(0, Mana - amount);
        }

        public void AddGold(int amount)
        {
            Gold += amount;
        }

        public void SpendGold(int amount)
        {
            Gold = Math.Max(0, Gold - amount);
        }
    }

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
        public string SpecialAbility { get; set; }

        public Enemy(int playerLevel)
        {
            var rand = new Random();
            Level = Math.Max(1, playerLevel + rand.Next(-1, 2));
            MaxHealth = 30 + Level * 10;
            Health = MaxHealth;
            Attack = 5 + Level * 2;
            Defense = 3 + Level;
            RewardGold = 10 + Level * 5;
            RewardXP = 15 + Level * 8;
            SpecialAbility = rand.Next(2) == 0 ? "Heal" : "PowerStrike";
        }
    }
}