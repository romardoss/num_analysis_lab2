using System;

namespace NumAnalysisLab2
{
    internal class IterativeMethod
    {
        public static double[] ValueOfArguments = { 0, 0, 0, 0 };
        //вказує на значення х1, х2, х3, х4
        public static double[] ValueOfArgumentsTemp = { 0, 0, 0, 0 };
        //тимчасові значення іксів, зберігаються до кінця однієї ітерації
        //а потім запишуться у ValueOfArguments

        public static bool IsAbleToCalculate(double[,] m)
        {
            int n = m.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for(int j = 0; j < n; j++)
                {
                    sum += Math.Abs(m[i, j]);
                }
                sum -= Math.Abs(m[i, i]);
                if(Math.Abs(m[i, i]) <= sum)
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

        public static void StartOfWork(double[,] m)
        {
            //Тут відбуватиметься перестановка елементів з вигляду 
            //x1+x2+x3=b до вигляду x1=b-x2-x3 і так само для інших іксів в наступних рядках
            int n = m.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    m[i, j] *= -1;
                }
                double temp = m[i, 0];
                m[i, 0] = m[i, i] * -1;
                if(i != 0)
                    m[i, i] = temp;
            }
            //x1 = -x2 -x3 -x4 b
            //x2 = -x1 -x3 -x4 b etc

            for (int i = 0; i < n; i++)
            {
                double divider = m[i, 0];
                for(int j = 0; j < n+1; j++)
                {
                    m[i, j] /= divider;
                }
            }
        }

        public static void CalculateOneIteration(double[,] m)
        {
            int n = m.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 1; j < n; j++)
                {
                    int IndexOfCurrentX = j-1;
                    if (j-1 >= i) IndexOfCurrentX++;
                    sum += m[i, j] * ValueOfArguments[IndexOfCurrentX];
                    Console.WriteLine("x" + (IndexOfCurrentX + 1));
                }
                sum += m[i, n];
                Console.WriteLine(sum);
                ValueOfArgumentsTemp[i] = sum;
            }
            for(int i = 0; i < ValueOfArguments.Length; i++)
            {
                ValueOfArguments[i] = ValueOfArgumentsTemp[i];
            }
        }

    }
}
