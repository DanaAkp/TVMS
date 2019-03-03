using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriptive_statistics
{
    class testLINQ
    {
        public static double[] array { get; set; }

        #region Функции
        /// <summary>
        /// Нахождение среднего для какой-то совокупности
        /// </summary>
        /// <param name="arr">Какая-то совокупность</param>
        /// <returns></returns>
        public static double Average(double[] arr)
        {
            return array.Sum() / array.Length;
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
            var dic = array.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => new { Element = y.Key, Count = y.Count() }).ToList();
            var w = from v in dic orderby v.Count select v;
            return w.Last().Element;
        }
        /// <summary>
        /// Нахождение максимального элемента для какой-то совокупности
        /// </summary>
        /// <param name="arr">Какая-то совокупность</param>
        /// <returns></returns>
        public static double Max(double[] arr)
        {
            return array.Max();
        }
        /// <summary>
        /// Нахождение минимального элемента для какой-то совокупности
        /// </summary>
        /// <param name="arr">Какая-то совокупность</param>
        /// <returns></returns>
        public static double Min(double[] arr)
        {
            return array.Min();
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
            return array.Sum();
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
        public static object Median(double[] arr)
        {
            var s = from t in array orderby t select t;
             var d=s.Select ((elem, index) => new { index, elem = array[index] });
            //if(s.ToArray().Count()%2!=0)
                return s.ToArray().GetValue(s.ToArray().Count() / 2 + 1);
            //return (s.ToArray().GetValue(s.ToArray().Count() / 2) + s.ToArray().GetValue(s.ToArray().Count() / 2 - 1)) / 2;

           // return 0;
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
    }
}
