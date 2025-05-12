using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    internal class PasswordValidator
    {
        private StringChecker firstChecker;

        public PasswordValidator(StringChecker firstChecker)
        {
            this.firstChecker = firstChecker;
        }

        public void AddChecker(StringChecker newChecker)
        {
            StringChecker current = firstChecker;
            while (current.GetNext() != null)
            {
                current = current.GetNext();
            }
            current.SetNext(newChecker);
        }


        public bool Validate(string password)
        {
            if (firstChecker == null)
                return false;
            return firstChecker.Check(password);
        }
    }
}
