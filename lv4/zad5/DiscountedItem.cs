using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class DiscountedItem : RentableDecorator
    {
        private readonly double discount = 0.2;
        public DiscountedItem(IRentable rentable) : base(rentable) { }

        public override double CalculatePrice()
        {
            return base.CalculatePrice() * (1 - discount);
        }

        public override string Description
        {
            get
            {
                return base.Description + $" now at {discount * 100}% off!";
            }
        }
    }
}
