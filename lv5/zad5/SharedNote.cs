using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class SharedNote : Note
    {
        List<string> names;
        public SharedNote(string message, ITheme theme) : base(message, theme)
        {
            names = new List<string>();
        }
        public void AddName(string name)
        {
            names.Add(name);
        }
        public void RemoveName(string name)
        {
            names.Remove(name);
        }
        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("RELEVANT MEMBERS: ");
            foreach (string name in names)
            {
                Console.WriteLine($"- {name}");
            }
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
        }
    }
}
