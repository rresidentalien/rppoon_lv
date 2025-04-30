namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationBuilder builder = new NotificationBuilder();
            NotificationDirector director = new NotificationDirector(builder);
            NotificationManager manager = new NotificationManager();

            manager.Display(director.CreateInfoNotification("Information Author"));
        }
    }
}
