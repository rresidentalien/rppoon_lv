using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    internal class NotificationBuilder : IBuilder
    {
        private string author = "Author";
        private string title = "Notification";
        private DateTime time = DateTime.Now;
        private Category level = Category.INFO;
        private ConsoleColor colour = ConsoleColor.Green;
        private string text = "Notification Body Text";

        public ConsoleNotification Build()
        {
            return new ConsoleNotification(author, title, text, time, level, colour);
        }

        public IBuilder SetAuthor(string author)
        {
            this.author = author;
            return this;
        }

        public IBuilder SetColor(ConsoleColor color)
        {
            this.colour = color;
            return this;
        }

        public IBuilder SetLevel(Category level)
        {
            this.level = level;
            return this;
        }

        public IBuilder SetText(string text)
        {
            this.text = text;
            return this;
        }

        public IBuilder SetTime(DateTime time)
        {
            this.time = time;
            return this;
        }

        public IBuilder SetTitle(string title)
        {
            this.title = title;
            return this;
        }
    }
}
