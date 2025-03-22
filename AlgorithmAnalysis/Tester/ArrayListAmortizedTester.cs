using AlgorithmAnalysis.ArrayListOperations;
using AlgorithmAnalysis.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.Tester
{
    public class ArrayListAmortizedTester
    {
        public static void TestAmortizedCost(int testSize)
        {
            var arrayList = new ArrayListOperation();
            long totalElapsedTicks = 0;
            int resizeCount = 0;

            Console.WriteLine($"\n=== Amortized Cost Test for {testSize} Elements ===");

            for (int i = 0; i < testSize; i++)
            {
                long elapsedTicks = TimeHelper.MeasureTime("Add Operation", () =>
                {
                    arrayList.Add(i);
                    return 0;
                });

                totalElapsedTicks += elapsedTicks;

                if (arrayList.Size == arrayList.Capacity / 2) 
                {
                    resizeCount++;
                    Console.WriteLine($"Resize at {arrayList.Size}: Time {elapsedTicks} ticks, Capacity {arrayList.Capacity}");
                }
            }
            double amortizedTimePerOperation = (double)totalElapsedTicks / testSize;
            Console.WriteLine($"Total Add Time: {totalElapsedTicks} ticks");
            Console.WriteLine($"Amortized Cost per Add: {amortizedTimePerOperation} ticks");
            Console.WriteLine($"Total Resizes: {resizeCount}");
            Console.WriteLine($"Resize Frequency: {(double)resizeCount / testSize * 100}%");
        }
    }
}
