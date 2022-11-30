using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void PrintArray(double[] r)
        {
            //виводить на екран нев'язку (або будь-який інший масив)
            for(int i = 0; i < r.Length; i++)
            {
                Console.Write(r[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
