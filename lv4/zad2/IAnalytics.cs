namespace zad2;

interface IAnalytics
{
    double[] CalculateAveragePerColumn(Dataset dataset);
    double[] CalculateAveragePerRow(Dataset dataset);
}