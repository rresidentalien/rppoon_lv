namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> items = new List<IRentable>();
            items.Add(new Book("The Picture of Dorian Gray"));
            items.Add(new Video("Inglorious Basterds"));
            items.Add(new HotItem(new Book("Jane Eyre")));
            items.Add(new HotItem(new Video("Arrival")));

            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(items);
            Console.WriteLine($"Total price:");
            printer.PrintTotalPrice(items);
        }
    }
}
