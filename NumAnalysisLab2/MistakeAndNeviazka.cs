using System;

namespace NumAnalysisLab2
{
    internal class MistakeAndNeviazka
    {
        public static double[] CalculateNeviazka(double[,] baseM, double[] x)
        {
            //обраховує вектор нев'язки
            int n = x.Length;
            double[] r = new double[n];
            for (int i = 0; i < n; i++)
            {
                r[i] = baseM[i, n];     //r = b
                for(int j = 0; j < n; j++)
                {
                    r[i] -= baseM[i, j] * x[j];        //r = b - Ax
                }
            }
            return r;
        }

        public static double SquareMistake(double[] arr1, double[] arr2)
        {
            int n = arr1.Length;
            double sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += Math.Pow((arr1[i] - arr2[i]), 2);
            }
            sum /= n;
            return Math.Sqrt(sum);
        }

    }
}
