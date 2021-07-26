using System;

namespace SampleTest2.ACA
{
    class Program
    {
        /// <summary>
        // 2D-array
        /// Given a n x n matrix. The problem is to find all the sum of elements of
        ///the matrix.
        /// </summary>

        static void Main(string[] args)
        {
            int n = 4;
            int[,] matrix = FillMatrix(n);

            Console.WriteLine($"Sum = {FindMatrixSum(matrix, n)}");
        }

        public static int[,] FillMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(5, 20);
                }
            }

            return matrix;
        }

        public static int FindMatrixSum(int[,] matrix, int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }
    }
}