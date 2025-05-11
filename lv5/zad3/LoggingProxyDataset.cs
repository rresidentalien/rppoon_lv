using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class LoggingProxyDataset : IDataset
    {
        private Dataset dataset;
        private string filePath;

        public LoggingProxyDataset(string filePath)
        {
            this.filePath = filePath;
        }

        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
                ConsoleLogger.GetInstance().Log("Dataset created");
            }
            ConsoleLogger.GetInstance().Log("Dataset logged");
            return dataset.GetData();
        }
    }
}
