using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Lost_Fortune

{
    class Entity
    {
        private string Name;
        private int gold;
        private int Level;
        private int Health;
        private int Mana;
        private int PhysicalDamage;
        private int MagicalDamage;
        private int Resist;
        private int Dodge;
        private int ExperiencePoints;
        private bool IsDead = false;

        public Entity()
        {
        }

        public int GetHealth()
        {
            return Health;
        }

        // Når der bliver dealt skade ud - både til NPC og playeren

        public int DamageToHealth(double amount)
        {
            amount = 1 + Math.Pow(Resist, 0.5);
            Health = Health - Convert.ToInt32(amount);

            if (Health <= 0)
                IsDead = true;
            
            return Health;
        }

        public int HealHealth(int amount)
        {
            Health = Health + amount;
            return Health;
        }

        public int GetMana()
        {
            return Mana;
        }

        // Eks. En spell som drainer npc/playerens mana

        public int DamageMana(int amount)
        {
            Mana = Health - amount;
            return Mana;
        }

        // En spell som giver mana til npc/playeren
        public int HealMana(int amount)
        {
            Mana = Mana + amount;
            return Mana;
        }

        public void AddExperiencePoints(int amount)
        {
            ExperiencePoints = ExperiencePoints + amount;
            if (10 * Math.Pow(1.5, Level) < ExperiencePoints)
            {
                Level++;
            }
        }

        public bool GetState()
        {
            return IsDead;
        }
    }
}
