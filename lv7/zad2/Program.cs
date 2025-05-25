namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = { 1, 2, 6, 323, 7.8, 7.4, 999, 234, 5, 5, 9, 10 };
            NumberSequence sequence = new NumberSequence(numbers);
            sequence.InsertAt(3, 6.5);

            SortStrategy sort = new SequentialSort();
            sequence.SetSortStrategy(sort);
            sequence.Sort();

            Console.WriteLine(sequence.ToString());

            ISearchStrategy search = new SequentialSearch();
            sequence.SetSearchStrategy(search);
            Console.WriteLine(sequence.Search(6));
        }
    }
}
