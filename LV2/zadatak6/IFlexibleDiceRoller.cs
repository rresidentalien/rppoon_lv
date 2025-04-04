using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak6
{
    interface IFlexibleDiceRoller
    {
        void InsertDie(Die die);
        void RemoveAllDice();
        void RollAllDice();
    }
}