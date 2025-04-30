using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Logger
    {
        private static Logger instance;
        public string FilePath { get; set; }

        private Logger()
        {
            FilePath = "C/";
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }
}
