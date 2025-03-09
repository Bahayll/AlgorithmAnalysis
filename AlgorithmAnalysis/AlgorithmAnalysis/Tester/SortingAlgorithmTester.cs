using AlgorithmAnalysis.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.Tester
{
    public class SortingAlgorithmTester
    {
        public static void TestSortAlgorithm(Func<int[], int[]> sortingAlgorithm, int[] sizes)
        {
            foreach (int size in sizes)
            {
                int[] arr = RandomArrayHelper.GenerateRandomArray(size);

                Stopwatch stopwatch = Stopwatch.StartNew();

                sortingAlgorithm((int[])arr.Clone());

                stopwatch.Stop();
                Console.WriteLine($"{sortingAlgorithm.Method.Name} - Time for {size} elements: {stopwatch.ElapsedMilliseconds} ms");
                Console.WriteLine();
            }
        }
        }
}
