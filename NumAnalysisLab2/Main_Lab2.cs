using System;

namespace NumAnalysisLab2
{
    internal class Main_Lab2
    {
        static readonly int variant = 6;
        static readonly int k = variant - 5;
        static readonly double a = 0.5 * k;
        static readonly double b = 0.5 * k;

        static readonly double[,] Matrix = {
            {3.81, 0.25, 1.28, 0.75+a, 4.21   },
            {2.25, 1.32, 4.58+a, 0.49, 6.47+b },
            {5.31, 6.28+a, 0.98, 1.04, 2.38   },
            {9.39+a, 2.45, 3.35, 2.28, 10.48+b}
        };

        static readonly double[,] NewMatrix = {
            {9.89, 2.45, 3.35, 2.28, 10.98},
            {1.5, 6.53, -0.3, -0.21, -1.83},
            {2.25, 1.32, 5.08, 0.49, 6.97},
            {30.07, -0.35, 1.05, 38.54, -3.56}
        };

        static void Main(string[] args)
        {
            PrintMatrix(NewMatrix);
            Console.WriteLine();
            IterativeMethod.IsAbleToCalculate(NewMatrix);
            Console.WriteLine();
            IterativeMethod.StartOfWork(NewMatrix);
            PrintMatrix(NewMatrix);
            Console.WriteLine();
            for (int i=0; i < 25; i++)
            {
                IterativeMethod.CalculateOneIteration(NewMatrix);
            }
            Console.WriteLine();
            Console.WriteLine("ANSWERS:");
            double[] array = IterativeMethod.ValueOfArguments;
            foreach (double i in array)
            {
                Console.Write(i + " ");
            }
        }

        static void PrintMatrix(double[,] m)
        {
            int rowLength = m.GetLength(0);
            int colLength = m.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", m[i, j]));
                }
                Console.WriteLine();
            }
        }
    }
}
