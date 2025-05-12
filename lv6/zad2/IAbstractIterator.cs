using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal interface IAbstractIterator
    {
        Box First();
        Box Next();
        bool isDone { get; }
        Box Current { get; }
    }
}
