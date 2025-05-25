using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class ConsoleLogger : Logger
    {
        public void Log(SimpleSystemDataProvider provider)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine($"CPU Load: {provider.CPULoad}");
            Console.WriteLine($"Available RAM: {provider.AvailableRAM}\n");
        }
    }
}
