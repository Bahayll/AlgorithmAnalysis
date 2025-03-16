using AlgorithmAnalysis.FinderAlgorithms;
using AlgorithmAnalysis.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.Tester
{
    public class KthSmallestTester
    {
        public static void TestKthSmallestAlgorithm(Func<int[], int, int> algorithm, int[] sizes, int k)
        {
            foreach (int size in sizes)
            {
                int[] arr = RandomArrayHelper.GenerateRandomArray(size);

                Console.WriteLine($"Algorithm: {algorithm.Method.Name}, Array Length: {size}, k: {k}");

                Stopwatch stopwatch = Stopwatch.StartNew();
                int result = algorithm((int[])arr.Clone(), k);
                stopwatch.Stop();

                Console.WriteLine($"Result: {result}, Time: {stopwatch.ElapsedMilliseconds} ms");
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
