using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    interface IEmailValidatorService
    {
        bool IsValidAddress(String candidate);
    }
}
