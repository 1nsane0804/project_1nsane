using System;

namespace project_1nsane
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int AttackPower { get; set; }
    }

    public class Armor
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Defense { get; set; }
    }

    public class Player
    {

        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }


        public int Health { get; set; }
        public int Mana { get; set; }
        public int Money { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        public Weapon EquippedWeapon { get; set; }
        public Armor EquippedArmor { get; set; }

        public int CalculateAttack()
        {
            int weaponAttack = EquippedWeapon?.AttackPower ?? 0;
            return Strength + weaponAttack;
        }

        public int CalculateDefense()
        {
            int armorDefense = EquippedArmor?.Defense ?? 0;
            return Stamina + armorDefense;
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
            Health += amount;
        }

        public void UseMana(int amount)
        {
            Mana = Math.Max(0, Mana - amount);
        }

        public void AddMoney(int amount)
        {
            Money += amount;
        }

        public void SpendMoney(int amount)
        {
            Money = Math.Max(0, Money - amount);
        }
    }

    public class Enemy
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Experience { get; set; }
        public int Reward { get; set; }
    }

    public class Skill
    {
        public string Name { get; set; }
        public int ManaCost { get; set; }
        public int Damage { get; set; }
        public bool IsHealing { get; set; }

        public void Use(Player user, Enemy target)
        {
            if (IsHealing)
            {
                user.Heal(Damage);
                user.UseMana(ManaCost);
            }
            else
            {
                target.Health = Math.Max(0, target.Health - Damage);
                user.UseMana(ManaCost);
            }
        }


        static void Main()
        {



        }

    }
}
