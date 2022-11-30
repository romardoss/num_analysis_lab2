using System;
using System.Linq;

namespace NumAnalysisLab2
{
    internal class Print
    {
        public static string Number(double num)
        {
            string s = num.ToString();
            string answer = "";
            if(num < 0)
            {
                answer = "-";
                s = s[1..];
            }
            int k = (num >= 0) ? 6 : 5;
            if (s.Length >= k)
            {
                answer += s[..k];
            }
            else
            {
                answer += string.Concat(Enumerable.Repeat("0", k - s.Length)) + s;
            }

            if(num == 0)
            {
                return "000000";
            }
            return answer;
        }

        public static void Array(double[] arr)
        {
            //виводить на екран нев'язку (або будь-який інший одновимірний масив)
            foreach (double i in arr)
            {
                Console.Write(Number(i) + " ");
            }
            Console.WriteLine();
        }

        public static void Matrix(double[,] m)
        {
            //виводить на екран двовимірний масив (матрицю)
            int rowLength = m.GetLength(0);
            int colLength = m.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", Number(m[i, j])));
                }
                Console.WriteLine();
            }
        }
    }
}
