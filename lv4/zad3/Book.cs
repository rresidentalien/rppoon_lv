using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Book : IRentable
    {
        private readonly double baseBookPrice = 19.99;
        public string Name { get; private set; }
        public Book(string name)
        {
            this.Name = name;
        }
        public string Description { get { return this.Name; } }

        public double CalculatePrice()
        {
            return baseBookPrice;
        }
    }
}
