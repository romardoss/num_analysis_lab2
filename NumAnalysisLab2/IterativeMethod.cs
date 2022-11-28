using System;

namespace NumAnalysisLab2
{
    internal class IterativeMethod
    {
        public bool IsAbleToCalculate(double[,] m)
        {
            int n = m.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for(int j = 0; j < n+1; j++)
                {
                    sum += m[i, j];
                }
                sum -= m[i, i];
                if(m[i, i] <= sum)
                {
                    Console.WriteLine("Вiдсутня дiагональна перевага");
                    Console.WriteLine("Неможливо обрахувати цю матрицю iтерацiйними методами");
                    Console.WriteLine("Перетворiть її на матрицю з дiагональною перевагою");
                    return false;
                }
            }
            Console.WriteLine("Дiагональна перевага присутня");
            Console.WriteLine("Матрицю можна обраховувати iтерацiйними методами");
            return true;
        }

    }
}
