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
            double[] s = new double[100];
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            { s[i] = rand.Next(2,99); Console.Write(s[i]+" "); }
            DescriptiveStatistics.quicksort(s, 0, 99);
            Console.WriteLine();
            foreach (int x in s) Console.Write(x+" ");
            Console.ReadLine();
        }
    }
}
