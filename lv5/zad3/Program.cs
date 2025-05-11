namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = User.GenerateUser("James Bond");
            VirtualProxyDataset virtualProxy = new VirtualProxyDataset("example.csv");
            ProtectionProxyDataset protectionProxy = new ProtectionProxyDataset(user);

            DataConsolePrinter printer = new DataConsolePrinter();
            printer.DisplayData(virtualProxy.GetData().ToList());
            printer.DisplayData(protectionProxy.GetData().ToList());

            LoggingProxyDataset loggingProxy = new LoggingProxyDataset("example.csv");
            printer.DisplayData(loggingProxy.GetData().ToList());
            printer.DisplayData(loggingProxy.GetData().ToList());
        }
    }
}
