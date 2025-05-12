namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");

            logger.SetNextLogger(fileLogger);

            logger.Log("System will shut down in 30 seconds", MessageType.INFO);
            logger.Log("Wrong Password", MessageType.WARNING);
            logger.Log("Page Fault", MessageType.ERROR);
        }
    }
}
