using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Lost_Fortune
{
    //Nedarver fra Entity
    class Player : Entity
    {
        private int _gold;
        private int _experiencePoints;

        //skal bruge et array af data for at oprette en entity, kaldet player
        //når en player bliver oprettet sendes playerens data også til entity via base()
        public Player(object[] player) : base(player)
        {
            _experiencePoints = Convert.ToInt32(player[8]);
            _gold = Convert.ToInt32(player[9]);
        }

        //Tilføjer xp til playeren og lvler op hvis den har nok
        public void AddExperiencePoints(int amount)
        {
            _experiencePoints = _experiencePoints + amount;
            //
            if (10 * Math.Pow(1.5, base.GetLevel()) < _experiencePoints)
            {
                AddLevel();
            }
        }
    }
}
