namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatrixGenerator generator = MatrixGenerator.GetInstance();

            double[][] matrix = generator.GenerateRandomMatrix(3, 5);

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}
