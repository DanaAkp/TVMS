using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriptive_statistics
{
    class DescriptiveStatistics
    {
        public static double[] array { get; set; }

        #region Описательная статистика
        /// <summary>
        /// Нахождение среднего для описательной статистики
        /// </summary>
        /// <returns></returns>
        public static double Average()
        {
            double res = 0;
            for (int i = 0; i < array.Length; i++) res += array[i];
            return res / array.Length;
        }
        /// <summary>
        /// Нахождение стандартной ошибки для описательной статистики
        /// </summary>
        /// <returns></returns>
        public static double StandartError()
        {
            return 0;
        }
        /// <summary>
        /// Нахождение моды для описательной статистики
        /// </summary>
        /// <returns></returns>
        public static double Fashion()
        {
            Dictionary<double, int> dic = new Dictionary<double, int>();
            for(int i = 0; i < array.Length; i++)
            { int c = 0;
                
            }
            return 0;
        }
        /// <summary>
        /// Нахождение максимального элемента для описательной статистики
        /// </summary>
        /// <returns></returns>
        public static double Max()
        {
            return array[array.Length - 1];
        }
        /// <summary>
        /// Нахождение минимального элемента для описательной статистики
        /// </summary>
        /// <returns></returns>
        public static double Min()
        {
            return array[0];
        }
        /// <summary>
        /// Нахождение эксцеса для описательной статистики
        /// </summary>
        /// <returns></returns>
        public static double Excess()
        {
            return 0;
        }
        /// <summary>
        /// Нахождение суммы всех элементов для описательной статистики
        /// </summary>
        /// <returns></returns>
        public static double Amount()
        {
            double sum = array[0];
            for (int i = 1; i < array.Length; i++)
                sum += array[i];
            return sum;
        }
        /// <summary>
        /// Нахождение интервала для описательной статистики
        /// </summary>
        /// <returns></returns>
        public static double Interval()
        {
            return 0;
        }
        /// <summary>
        /// Нахождение стандартного отклонения для описательной статистики
        /// </summary>
        /// <returns></returns>
        public static double StandartDeviation()
        {
            return 0;
        }
        /// <summary>
        /// Нахождение асимметрии для описательной статистики
        /// </summary>
        /// <returns></returns>
        public static double Asymmetry()
        {
            return 0;
        }
        /// <summary>
        /// Нахождение медианы для описательной статистики
        /// </summary>
        /// <returns></returns>
        public static double Median()
        {
            quicksort(array, 0, array.Length - 1);
            if (array.Length % 2 != 0) return array.Length / 2 + 1;
            return (array[array.Length / 2] + array[array.Length / 2 - 1]) / 2;
        }
        //public static double Score(double[] array, int n)
        //{
        //    return n;
        //}
        /// <summary>
        /// Нахождение дисперсии для описательной статистики
        /// </summary>
        /// <returns></returns>
        public static double Dispersion()
        {
            return 0;
        }

        public override string ToString()
        {
            string s = "Описательная статистика: ";
            s += "\nСреднее: " + Average();
            s += "\nСумма: " + Amount();
            return s;
        }
        #endregion

        #region Функции
        /// <summary>
        /// Нахождение среднего для какой-то совокупности
        /// </summary>
        /// <param name="arr">Какая-то совокупность</param>
        /// <returns></returns>
        public static double Average(double[] arr)
        {
            double res = 0;
            for (int i = 0; i < array.Length; i++) res += array[i];
            return res / array.Length;
        }
        /// <summary>
        /// Нахождение стандартной ошибки для какой-то совокупности
        /// </summary>
        /// <param name="arr">Какая-то совокупность</param>
        /// <returns></returns>
        public static double StandartError(double[] arr)
        {
            return 0;
        }
        /// <summary>
        /// Нахождение моды для какой-то совокупности
        /// </summary>
        /// <param name="arr">Какая-то совокупность</param>
        /// <returns></returns>
        public static double Fashion(double[] arr)
        {
            return 0;
        }
        /// <summary>
        /// Нахождение максимального элемента для какой-то совокупности
        /// </summary>
        /// <param name="arr">Какая-то совокупность</param>
        /// <returns></returns>
        public static double Max(double[] arr)
        {
            double max = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > max) max = arr[i];
            return max;
        }
        /// <summary>
        /// Нахождение минимального элемента для какой-то совокупности
        /// </summary>
        /// <param name="arr">Какая-то совокупность</param>
        /// <returns></returns>
        public static double Min(double[] arr)
        {
            double min = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < min) min = arr[i];
            return min;
        }
        /// <summary>
        /// Нахождение эксцеса для какой-то совокупности
        /// </summary>
        /// <param name="arr">Какая-то совокупность</param>
        /// <returns></returns>
        public static double Excess(double[] arr)
        {
            return 0;
        }
        /// <summary>
        /// Нахождение суммы всех элементов для какой-то совокупности
        /// </summary>
        /// <param name="arr">Какая-то совокупность</param>
        /// <returns></returns>
        public static double Amount(double[] arr)
        {
            double sum = array[0];
            for (int i = 1; i < array.Length; i++)
                sum += array[i];
            return sum;
        }
        /// <summary>
        /// Нахождение интервала для какой-то совокупности
        /// </summary>
        /// <param name="arr">Какая-то совокупность</param>
        /// <returns></returns>
        public static double Interval(double[] arr)
        {
            return 0;
        }
        /// <summary>
        /// Нахождение стандартного отклонения для какой-то совокупности
        /// </summary>
        /// <param name="arr">Какая-то совокупность</param>
        /// <returns></returns>
        public static double StandartDeviation(double[] arr)
        {
            return 0;
        }
        /// <summary>
        /// Нахождение асимметрии для какой-то совокупности
        /// </summary>
        /// <param name="arr">Какая-то совокупность</param>
        /// <returns></returns>
        public static double Asymmetry(double[] arr)
        {
            return 0;
        }
        /// <summary>
        /// Нахождение медианы для какой-то совокупности
        /// </summary>
        /// <param name="arr">Какая-то совокупность</param>
        /// <returns></returns>
        public static double Median(double[] arr)
        {

            return 0;
        }
        //public static double Score(double[] array, int n)
        //{
        //    return n;
        //}
        /// <summary>
        /// Нахождение дисперсии для какой-то совокупности
        /// </summary>
        /// <param name="arr">Какая-то совокупность</param>
        /// <returns></returns>
        public static double Dispersion(double[] arr)
        {
            return 0;
        }
        #endregion

        #region Сортировка
        public static int partition<T>(T[] m, int a, int b) where T : IComparable<T>
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
        #endregion
    }
}
