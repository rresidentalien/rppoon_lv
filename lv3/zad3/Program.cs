namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.GetInstance();
            logger.FilePath = "C/Desktop";
            Console.WriteLine(logger.FilePath);

            Test test = new Test();
            test.PrintFilePath();
        }
    }
}
