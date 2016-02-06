using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Lost_Fortune

{
    class Entity
    {
        private string _name;
        private int _level;
        private int _health;
        private int _mana;
        private int _physicalDamage;
        private int _magicalDamage;
        private int _resist;
        private int _dodge;
        private bool _isDead = false;

        //skal bruge et array af data for at oprette en entity, kaldet data
        //0 er navn, 1 er level, 2 er health, 3 er mana, 4 er pdamage, 5 er mdamage, 6 er resist, 7 er dodge
        public Entity(object[] data)
        {
            _name = data[0].ToString();
            _level = Convert.ToInt32(data[1]);
            _health = Convert.ToInt32(data[2]);
            _mana = Convert.ToInt32(data[3]);
            _physicalDamage = Convert.ToInt32(data[4]);
            _magicalDamage = Convert.ToInt32(data[5]);
            _resist = Convert.ToInt32(data[6]);
            _dodge = Convert.ToInt32(data[7]);
        }

        //Henter level
        public int GetLevel()
        {
            return _level;
        }

        //tilføjer level, brugt kun i Player
        public void AddLevel()
        {
            _level++;
        }

        //henter health
        public int GetHealth()
        {
            return _health;
        }


        // Når der bliver dealt skade ud - både til NPC og playeren
        public int DamageToHealth(double amount)
        {
            amount = 1 + Math.Pow(_resist, 0.5);
            _health = _health - Convert.ToInt32(amount);

            if (_health <= 0)
                _isDead = true;
            
            return _health;
        }

        //til at heale liv
        public int HealHealth(int amount)
        {
            _health = _health + amount;
            return _health;
        }

        //henter mana
        public int GetMana()
        {
            return _mana;
        }

        //damager mana, Eks. En spell som drainer npc/playerens mana
        public int DamageMana(int amount)
        {
            _mana = _health - amount;
            return _mana;
        }

        // En spell som giver mana til npc/playeren
        public int HealMana(int amount)
        {
            _mana = _mana + amount;
            return _mana;
        }
        
        //Henter om en entity er død eller levende
        public bool GetState()
        {
            return _isDead;
        }
    }
}
