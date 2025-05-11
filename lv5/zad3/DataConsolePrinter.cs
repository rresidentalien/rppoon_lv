using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class DataConsolePrinter
    {
        public void DisplayData(List<List<string>> data)
        {
            data.ForEach(row => Console.WriteLine(string.Join(", ", row)));
        }
    }
}
