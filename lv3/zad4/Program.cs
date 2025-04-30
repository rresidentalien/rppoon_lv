namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleNotification notification = new ConsoleNotification("Edsger Dijkstra", "Goto Statement Considered Harmful", "For a number of years I have been familiar with...", new DateTime(1968, 3, 3), Category.INFO, ConsoleColor.Green);

            NotificationManager manager = new NotificationManager();

            manager.Display(notification);
        }
    }
}
