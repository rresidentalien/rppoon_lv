using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
            string log = $"{type}: {DateTime.Now}\n" +
                      new string('=', message.Length) + "\n" +
                      message + "\n" +
                      new string('=', message.Length) + "\n\n";
            File.AppendAllText(this.filePath, log);
        }
    }
}
