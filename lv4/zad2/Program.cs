namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dataset dataset = new Dataset("example.csv");
            Analyzer3rdParty analyzer = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyzer);

            double[] columnAverage = adapter.CalculateAveragePerColumn(dataset);
            double[] rowAverage = adapter.CalculateAveragePerRow(dataset);

            Console.WriteLine("Average values per column:");
            Console.WriteLine(String.Join(",", columnAverage));

            Console.WriteLine("Average values per row:");
            Console.WriteLine(String.Join(",", rowAverage));
        }
    }
}
