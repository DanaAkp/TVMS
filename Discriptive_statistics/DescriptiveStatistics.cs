using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriptive_statistics
{
    class DescriptiveStatistics
    {
        public static double Average(double[] array, int n)
        {
            double res = 0;
            for (int i = 0; i < n; i++) res += array[i];
            return res / n;
        }
        public static double StandartError(double[] array, int n)
        {
            return 0;
        }
        public static double Fashion(double[] array, int n)
        {
            return 0;
        }
        public static double Max(double[] array, int n)
        {
            double max = array[0];
            for (int i = 1; i < n; i++)
                if (array[i] > max) max = array[i];
            return max;
        }
        public static double Min(double[] array, int n)
        {
            double min = array[0];
            for (int i = 1; i < n; i++)
                if (array[i] < min) min = array[i];
            return min;
        }
        public static double Excess(double[] array, int n)
        {
            return 0;
        }
        public static double Amount(double[] array, int n)
        {
            double sum = array[0];
            for (int i = 1; i < n; i++)
                sum += array[i];
            return sum;
        }
        public static double Interval(double[] array, int n)
        {
            return 0;
        }
        public static double StandartDeviation(double[] array, int n)
        {
            return 0;
        }
        public static double Asymmetry(double[] array, int n)
        {
            return 0;
        }
        public static double Median(double[] array, int n)
        {

            return 0;
        }
        //public static double Score(double[] array, int n)
        //{
        //    return n;
        //}
        public static double Dispersion(double[] array, int n)
        {
            return 0;
        }
        public static int partition<T>(T[] m, int a, int b)  where T : IComparable<T>
        {
            int i = a;
            for (int j = a; j <= b; j++)         // просматриваем с a по b
            {
                if (m[j].CompareTo(m[b]) <= 0)  // если элемент m[j] не превосходит m[b],
                {
                    T t = m[i];                  // меняем местами m[j] и m[a], m[a+1], m[a+2] и так далее...
                    m[i] = m[j];                 // то есть переносим элементы меньшие m[b] в начало,
                    m[j] = t;                    // а затем и сам m[b] «сверху»
                    i++;                         // таким образом последний обмен: m[b] и m[i], после чего i++
                }
            }
            return i - 1;                        // в индексе i хранится <новая позиция элемента m[b]> + 1
        }
        public static void quicksort<T>(T[] m, int a, int b) where T : IComparable<T>// a - начало подмножества, b - конец
        {                                        // для первого вызова: a = 0, b = <элементов в массиве> - 1
            if (a >= b) return;
            int c = partition(m, a, b);
            quicksort(m, a, c - 1);
            quicksort(m, c + 1, b);
        }

        public override string ToString()
        {
            string s = "Описательная статистика: ";
            s += "\nСреднее: " + Average();
            return base.ToString();
        }
    }
}
