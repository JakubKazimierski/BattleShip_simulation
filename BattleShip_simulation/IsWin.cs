using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BattleShip_simulation
{
    class IsWin
    {
        internal bool WinShip(int AmountOfShips, int ActualHitsShips)
        {
            MessageBox.Show($"{AmountOfShips}, {ActualHitsShips}");
            return AmountOfShips == ActualHitsShips;
        }
    }
}
