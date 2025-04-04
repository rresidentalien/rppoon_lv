using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak4
{
    class Die
    {
        private int numberOfSides;
        private RandomGenerator randomGenerator;
        public Die(int numberOfSides, RandomGenerator randomGenerator)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = randomGenerator;
        }
        public int Roll()
        {
            int rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }
    }
}
