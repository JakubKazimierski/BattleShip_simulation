using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_simulation
{
    interface IBoard
    {
        public List<string> CreatingWidth();
        public Dictionary<int, List<string>> CreatingBoard();
        public void GetValues();
    }
}
