using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class RentVisitor : IVisitor
    {
        private const double rentPercentage = 0.1;

        public double Visit(DVD DVDItem)
        {
            if (DVDItem.Type == DVDType.SOFTWARE)
            {
                return double.NaN;
                //return DVDItem.Price;
            }
            return DVDItem.Price * rentPercentage;
        }
        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * rentPercentage;
        }
        public double Visit(Book BookItem)
        {
            return BookItem.Price * rentPercentage;
        }
    }
}
