using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_simulation
{
    class RandomPlace : AllDatas
    {
        Random rand = new Random();
        internal int RandomVal() => rand.Next(minSize, maxSize);
    }
}
