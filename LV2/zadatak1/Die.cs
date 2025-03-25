using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak1
{
    class Die
    {
        private int numberOfSides;
        private Random randomGenerator;
        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = new Random();
        }
        public int Roll()
        {
            int rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
            return rolledNumber;
        }
    }
}
