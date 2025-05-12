using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class CareTaker
    {
        public CareTaker()
        {
            PreviousStates = new List<Memento>();
        }
        public List<Memento> PreviousStates { get; set; }
    }
}
