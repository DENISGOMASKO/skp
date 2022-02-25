using System;
using static System.Console;

namespace BinominalTh
{
    class Program
    {
        static void PT(int n, ref long compl)
        {
            int[][] result = new int[n + 1][];
            for(int i = 0; i < result.Length; i++)
            {
                result[i] = new int[i + 1];
                for (int j = 0; j < result.Length; j++)
                {
                    if (j > i) continue;
                    if (i == 0 || j == 0 || i == j)
                    {
                        result[i][j] = 1;
                    }
                    else
                    {
                        result[i][j] = result[i - 1][j - 1] + result[i - 1][j];
                        compl++;
                    }
                    if (i == n) Write(result[i][j] + " ");
                }
            }
        }
        static int BC(int n, int k, ref long complication)
        {
            long result = 1;
            for(int i = n - k + 1; i <= n; i++)
            {
                result *= i;
                complication++;
            }
            for(int i = 2; i <= k; i++)
            {
                result /= i;
                complication++;
            }
            return (int)result;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("Введите степень");
                try
                {
                    long compl = 0;
                    string result = "1 ";
                    int n = Convert.ToInt32(ReadLine());
                    if (n < 0)
                    {
                        throw new Exception();
                    }
                    for(int i = 1; i <= n; i++)
                    {
                        result += Convert.ToString(BC(n, i, ref compl)) + " ";
                    }
                    WriteLine(result);
                    compl = 0;
                    WriteLine();
                    PT(n, ref compl);
                    WriteLine();
                }
                catch
                {
                    WriteLine("Ошибка ввода");
                    continue;
                }
            }
        }
    }
}
