namespace NumAnalysisLab2
{
    internal class Main_Lab2
    {
        static readonly int variant = 6;
        static readonly int k = variant - 5;
        static readonly double a = 0.5 * k;
        static readonly double b = 0.5 * k;

        static double[,] Matrix = {
            {3.81, 0.25, 1.28, 0.75+a, 4.21   },
            {2.25, 1.32, 4.58+a, 0.49, 6.47+b },
            {5.31, 6.28+a, 0.98, 1.04, 2.38   },
            {9.39+a, 2.45, 3.35, 2.28, 10.48+b}
        };

        static double[,] MatrixTest = {
            {100, 0.25, 1.28, 0.75+a, 4.21   },
            {2.25, 100, 4.58+a, 0.49, 6.47+b },
            {5.31, 6.28+a,100, 1.04, 2.38   },
            {9.39+a, 2.45, 3.35, 100, 10.48+b}
        };

        static void Main(string[] args)
        {
            IterativeMethod i = new();
            i.IsAbleToCalculate(MatrixTest);
        }
    }
}
