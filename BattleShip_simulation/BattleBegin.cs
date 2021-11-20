using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_simulation
{
    class BattleBegin : PlayerChoose
    {
        internal string begin(List<string> ShipCoords)
        {
            string IsStrike = Choose();
            if (ShipCoords.Any(item => item.Contains(IsStrike)))
                if (!Strikes.Any(item => item.Contains(IsStrike)))
                {
                    Strikes.Add(IsStrike);
                    ShipCoords.Remove(IsStrike);
                    return IsStrike;
                }

            return string.Empty;
        }
    }
}
