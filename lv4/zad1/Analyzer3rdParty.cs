namespace zad1;

class Analyzer3rdParty
{
    public double[] PerRowAverage(double[][] data)
    {
        int rowCount = data.Length;
        double[] results = new double[rowCount];
        for (int i = 0; i < rowCount; i++)
        {
            results[i] = data[i].Average();
        }
        return results;
    }
    public double[] PerColumnAverage(double[][] data)
    {
        int colCount = data.Length;
        double[] results = new double[colCount];
        for (int i = 0; i < colCount; i++)
        {
            results[i] = data[i].Average();
        }
        return results;
    }
}