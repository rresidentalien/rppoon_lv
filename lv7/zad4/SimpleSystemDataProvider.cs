using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    abstract class SimpleSystemDataProvider
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        private List<Logger> loggers;
        public SimpleSystemDataProvider()
        {
            this.cpuCounter = new PerformanceCounter("Processor", "% processor time", "_Total");
            this.ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            this.loggers = new List<Logger>();
        }
        public float CPULoad { get { return this.cpuCounter.NextValue(); } }
        public float AvailableRAM { get { return this.ramCounter.NextValue(); } }
        public void Attach(Logger logger)
        {
            if (!this.loggers.Contains(logger))
                this.loggers.Add(logger);
        }
        public void Detach(Logger logger)
        {
            this.loggers.Remove(logger);
        }
        public void Notify()
        {
            foreach (Logger logger in this.loggers)
            {
                logger.Log(this);
            }
        }
    }
}
