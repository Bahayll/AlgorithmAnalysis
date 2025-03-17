using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.Helpers
{
    public static class TimeHelper
    {
        public static int MeasureTime(string methodName, Func<int> method)
        {
            Stopwatch sw = Stopwatch.StartNew();
            int result = method();
            sw.Stop();

            Console.WriteLine($"{methodName}: Result {result}, Duration: {sw.ElapsedMilliseconds} ms");
            return result;
        }
    }
}
