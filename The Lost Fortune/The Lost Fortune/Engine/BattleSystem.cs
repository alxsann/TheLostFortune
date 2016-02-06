using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Lost_Fortune
{
    class BattleSystem
    {
        private Player _player;
        private Enemy _enemy;
        private Random _rnd;
        
        // når en battle oprettes skal den bruge et område kode for at bestemme modstander, på areaCode
        public BattleSystem(int areaCode) 
        {
            //henter en liste af monstre man kan møde i det område man er i, på areaCode
            List<object[]> monster = Monsters.GetMonsterList(areaCode);

            //Vælger random monster fra den liste
            _rnd = new Random();
            int tempId = _rnd.Next(monster.Count);

            //opretter monsteret
            _enemy = new Enemy(monster[tempId]);
        }
    }
}
