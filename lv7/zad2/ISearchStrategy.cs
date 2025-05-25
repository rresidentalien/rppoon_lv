using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    interface ISearchStrategy
    {
        bool Search(double[] array, double number);
    }
}
