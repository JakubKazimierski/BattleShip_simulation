using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_simulation
{
    class PlayerChoose : RandomPlace
    {
        internal string Choose() => $"{StartValue}{RandomVal()}{RandomVal()}";
    }
}
