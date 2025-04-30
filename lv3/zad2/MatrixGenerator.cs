using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private Random random;

        private MatrixGenerator()
        {
            this.random = new Random();
        }

        public static MatrixGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new MatrixGenerator();
            }

            return instance;
        }

        public double[][] GenerateRandomMatrix(int rows, int cols)
        {
            double[][] matrix = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new double[cols];
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = random.NextDouble();
                }
            }

            return matrix;
        }
    }
}
