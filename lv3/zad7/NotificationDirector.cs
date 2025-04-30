using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7
{
    class NotificationDirector
    {
        IBuilder builder;

        public NotificationDirector(IBuilder builder)
        {
            this.builder = builder;
        }

        public void SetBuilder(IBuilder builder)
        {
            this.builder = builder;
        }

        public ConsoleNotification CreateInfoNotification(string author)
        {
            builder.SetLevel(Category.INFO);
            builder.SetAuthor(author);
            return builder.Build();
        }

        public ConsoleNotification CreateAlertNotification(string author)
        {
            builder.SetLevel(Category.ALERT);
            builder.SetAuthor(author);
            return builder.Build();
        }

        public ConsoleNotification CreateErrorNotification(string author)
        {
            builder.SetLevel(Category.ERROR);
            builder.SetAuthor(author);
            return builder.Build();
        }
    }
}
