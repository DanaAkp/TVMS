using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Common;
using System.IO;
using System.Threading.Tasks;


namespace Discriptive_statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            

            string d = File.ReadAllText(@"C: \Users\Данагуль\source\repos\Discriptive_statistics\средний периметр.txt");
            double[] s = DiscriptiveStatistics.GetSample(d);

            DiscriptiveStatistics.Output(s);
            DiscriptiveStatistics.Output_descriptive_statistics(s);
            Console.WriteLine("--------------------------------------------------------------------");
            s = DiscriptiveStatistics.Rationing_MaxMin(s);
            DiscriptiveStatistics.Output(s);
            DiscriptiveStatistics.Output_descriptive_statistics(s);
            

            Console.ReadLine();
        }

    }
}
