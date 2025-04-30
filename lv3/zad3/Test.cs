using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Test
    {
        Logger logger = Logger.GetInstance();
        public void PrintFilePath()
        {
            Console.WriteLine(logger.FilePath);
        }
    }
}
