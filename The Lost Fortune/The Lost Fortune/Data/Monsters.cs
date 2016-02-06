using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Lost_Fortune
{
    public class Monsters
    {
        //   0     1      2       3        4              5            6       7        8              9       10        11
        // name, level, health, mana, physicalDamage, magicalDamage, resist, dodge, experienceReward, gold, rewardId, areaCode
        // Items position i denne liste er den samme som dens Id.
        private static List<object[]> monsters = new List<object[]>();
        public static void GenerateMonsters()
        {
            monsters.Add(new object[] { "Rat", 1, 10, 10, 10, 10, 10, 10, 10, 0, Area.AREA_CRATER });
        }

        //henter en liste af enemies bestemt efter hvilket område man er i, areaCode
        public static List<object[]> GetMonsterList(int areaCode)
        {
            List<object[]> monsterList = new List<object[]>();

            foreach(object[] raw in monsters)
            {
                if(Convert.ToInt32(raw[11]) == areaCode)
                {
                    monsterList.Add(raw);
                }
            }

            return monsterList;
        }

        //henter enkelt monster hvis man ved man skal bruge et bestemt. angivet af monsterId
        public static object[] GetMonster(int monsterId)
        {
            return monsters[monsterId];
        }
    }
}
