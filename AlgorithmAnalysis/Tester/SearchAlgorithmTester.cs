
using AlgorithmAnalysis.Algorithms.SearchAlgorithms;
using AlgorithmAnalysis.Helpers;
using AlgorithmAnalysis.SearchAlgorithms;
using System.Buffers;
using System.Diagnostics;

namespace AlgorithmAnalysis.Tester
{
    public class SearchAlgorithmTester
    {
        public static void TestSearchAlgorithm()
        {
            int[] sizes = { 1000, 5000, 10000, 50000 };
            int target = 500;

            foreach (int size in sizes)
            {
                int[] arr = RandomArrayHelper.GenerateRandomArray(size, 1, 1000);
                Array.Sort(arr);

                Console.WriteLine($"Array Size: {size}");

                // Linear Search Test
                int operationCount = 0;
                TimeHelper.MeasureTime("Linear Search O(n)", () => LinearSearch.Search(arr, target, ref operationCount));
                Console.WriteLine($"Operation Count: {operationCount}");

                // Binary Search Test
                operationCount = 0;
                TimeHelper.MeasureTime("Binary Search O(log n)", () => BinarySearch.Search(arr, target, ref operationCount));
                Console.WriteLine($"Operation Count: {operationCount}");

                // Min-Max Test
                int minOperations = 0, maxOperations = 0;
                int min = TimeHelper.MeasureTime("Min Element Search O(n)", () => MinMaxFinder.Min(arr, ref minOperations));
                int max = TimeHelper.MeasureTime("Max Element Search O(n)", () => MinMaxFinder.Max(arr, ref maxOperations));

                Console.WriteLine($"Min: {min}, Max: {max}");
                Console.WriteLine($"Min Element Search Operation Count: {minOperations}, Max Element Search Operation Count: {maxOperations}");

                Console.WriteLine(new string('-', 50));
            }
        }


    }
}
