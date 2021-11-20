using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_simulation
{
    class AmountOfShips : CreateShips
    {
        internal int Amount()
        {
            var Amount = 0;
            foreach (var Model in Model())
                Amount += Model.Counter;

            return Amount;
        }
    }
}
