namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SystemDataProvider provider = new SystemDataProvider();
            ConsoleLogger consoleLogger = new ConsoleLogger();
            FileLogger fileLogger = new FileLogger("log.txt");
            provider.Attach(consoleLogger);
            provider.Attach(fileLogger);
            while (true)
            {
                provider.GetCPULoad();
                provider.GetAvailableRAM();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
