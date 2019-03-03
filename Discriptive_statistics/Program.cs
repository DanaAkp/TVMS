using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriptive_statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] s = new double[] {3,4,3,23,3,2,23,2,32,323,232,32,34,34,3,4,45,545,45,45,3,43,21,3,43, 23};
            //Random rand = new Random();
            //for (int i = 0; i < 100; i++)
            //{ s[i] = rand.Next(2,99); Console.Write(s[i]+" "); }
            //DescriptiveStatistics.quicksort(s, 0, 99);
            //Console.WriteLine();
            //foreach (int x in s) Console.Write(x+" ");


            testLINQ.Output_descriptive_statistics(s);


            Console.ReadLine();
        }
    }
}
