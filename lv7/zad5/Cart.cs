using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class Cart
    {
        private List<IItem> items;
        private IVisitor visitor;

        public Cart(IVisitor visitor)
        {
            items = new List<IItem>();
            this.visitor = visitor; 
        }

        public void SetVisitor(IVisitor visitor)
        {
            this.visitor = visitor;
        }
        public void AddItem(IItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(IItem item)
        {
            items.Remove(item);
        }
        public double Accept()
        {
            double sum = 0;
            foreach(var item in items)
            {
                sum += item.Accept(visitor);
            }

            return sum;
        }
    }
}
