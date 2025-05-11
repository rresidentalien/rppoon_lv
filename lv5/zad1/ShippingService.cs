using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class ShippingService
    {
        private double pricePerKg;
        public ShippingService(double pricePerKg)
        {
            this.pricePerKg = pricePerKg;
        }
        public double CalculateShippingPrice(double shipmentWeight)
        {
            return shipmentWeight * pricePerKg;
        }
    }
}
