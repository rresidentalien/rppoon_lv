using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class ConsoleLogger : Logger
    {
        public void Log(SimpleSystemDataProvider provider)
        {
            Console.WriteLine($"{DateTime.Now}: {provider.CPULoad}%, {provider.AvailableRAM} MB free");
        }
    }
}
