using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Lost_Fortune
{
    //Nedarver fra Entity
    class Enemy : Entity
    {
        private int _experienceReward;
        private int _goldReward;
        private Item[] _lootReward; //STUB, til loot når man har nakket mobben

        //skal bruge et array af data for at oprette en entity, kaldet enemy
        //8 er experience der skal gives når enemy dør, 9 er gold der skal gives når den dør
        public Enemy(object[] enemy) : base(enemy)
        {
            _experienceReward = Convert.ToInt32(enemy[8]);
            _goldReward = Convert.ToInt32(enemy[9]);
        }
    }
}
