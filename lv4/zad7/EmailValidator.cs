using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7
{
    internal class EmailValidator : IEmailValidatorService
    {
        public bool IsValidAddress(string candidate)
        {
            if (string.IsNullOrEmpty(candidate))
            {
                return false;
            }

            return ContainsAt(candidate) && EndsWithComOrHr(candidate);
        }

        private bool ContainsAt(string candidate)
        {
            if (!candidate.Contains("@"))
            {
                return false;
            }
            return true;
        }

        private bool EndsWithComOrHr(string candidate)
        {
            return candidate.EndsWith(".com") || candidate.EndsWith(".hr");
        }
    }
}
