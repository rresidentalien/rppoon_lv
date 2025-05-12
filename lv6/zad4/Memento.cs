using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Memento
    {
        public string OwnerName { get; private set; }
        public string OwnerAddress { get; private set; }
        public decimal Balance { get; private set; }

        public Memento(string ownerName, string ownerAddress, decimal balance)
        {
            OwnerName = ownerName;
            OwnerAddress = ownerAddress;
            Balance = balance;
        }
    }
}
