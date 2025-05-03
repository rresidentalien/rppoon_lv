namespace zad1;

class Adapter : IAnalytics
{
    private Analyzer3rdParty analyticsService;
    public Adapter(Analyzer3rdParty service)
    {
        this.analyticsService = service;
    }
    private double[][] ConvertData(Dataset dataset)
    {
        IList<List<double>> data = dataset.GetData();
        int rows = data.Count;
        int cols = data[0].Count;
        double[][] dataMatrix = new double[rows][];

        for (int i = 0; i < rows; i++)
        {
            dataMatrix[i] = new double[cols];
            for (int j = 0; j < cols; j++)
            {
                dataMatrix[i][j] = data[i][j];
            }
        }

        return dataMatrix;
    }
    public double[] CalculateAveragePerColumn(Dataset dataset)
    {
        double[][] data = this.ConvertData(dataset);
        return this.analyticsService.PerColumnAverage(data);
    }
    public double[] CalculateAveragePerRow(Dataset dataset)
    {
        double[][] data = this.ConvertData(dataset);
        return this.analyticsService.PerRowAverage(data);
    }
}