using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class SequentialSearch : ISearchStrategy
    {
        public bool Search(double[] array, double number)
        {
            foreach(double position in array)
            {
                if (number == position)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
