using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak7
{
    class FlexibleDiceRoller : IFlexibleDiceRoller
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        public FlexibleDiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RemoveAllDice()
        {
            this.dice.Clear();
            this.resultForEachRoll.Clear();
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }
        public void RemoveDiceMatching(int numberOfSides)
        {
            foreach(var die in dice)
            {
                if (die.NumberOfSides == numberOfSides)
                {
                    dice.Remove(die);
                }
            }
        }
    }
}
