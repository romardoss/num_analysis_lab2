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

        static readonly double[] CalculatorResults = {1.08077, -0.50838, 1.11889, -0.97101};

        static void Main(string[] args)
        {
            Console.WriteLine("Початкова матриця:");
            Print.Matrix(Matrix);
            Console.WriteLine();

            Console.WriteLine("Перевiрка матрицi на дiагональну перевагу:");
            IterativeMethod.IsAbleToCalculate(Matrix);
            Console.WriteLine();

            Console.WriteLine("Перетворена матриця:");
            Print.Matrix(NewMatrix);
            Console.WriteLine();

            Console.WriteLine("Перевiрка матрицi на дiагональну перевагу:");
            IterativeMethod.IsAbleToCalculate(NewMatrix);
            Console.WriteLine();

            Console.WriteLine("Перетворення матрицi до вигляду x1=-x2-x3-x4+b; x2=-x1-x3-x4+b; x3=... x4=...:");
            IterativeMethod.StartOfWork(NewMatrix);
            Print.Matrix(NewMatrix);
            Console.WriteLine();

            Console.WriteLine("Обчислення матрицi:");
            IterativeMethod.DoIterationUntil(NewMatrix, Matrix);
            Console.WriteLine();

            Console.WriteLine("Вiдповiдi:");
            double[] array = IterativeMethod.ValueOfArguments;
            Print.Array(array);
            Console.WriteLine();

            double[] NeviazkaCalculator = MistakeAndNeviazka.CalculateNeviazka(Matrix, CalculatorResults);
            Console.WriteLine("Вектор нев'язки вiд розв'язку, отриманого з онлайн калькулятора:");
            Print.Array(NeviazkaCalculator);
            Console.WriteLine();

            double squareMistake = MistakeAndNeviazka.SquareMistake(IterativeMethod.ValueOfArguments, CalculatorResults);
            Console.WriteLine("Середньоквадратична похибка:");
            Console.WriteLine(squareMistake);
        }
    }
}
