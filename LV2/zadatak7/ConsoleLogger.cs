using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak7
{
    internal class ConsoleLogger : ILogger
    {
        public ConsoleLogger() { }
        public void Log(ILogable data)
        {
            Console.WriteLine(data);
        }
    }
}
