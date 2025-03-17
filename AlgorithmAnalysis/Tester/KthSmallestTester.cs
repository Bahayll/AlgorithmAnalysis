using AlgorithmAnalysis.Algorithms.FinderAlgorithms;
using AlgorithmAnalysis.Helpers;
using System.Diagnostics;

namespace AlgorithmAnalysis.Tester
{
    public class KthSmallestTester
    {
        public static void TestKthSmallestAlgorithm()
        {

            int[] sizeArray = { 10, 100,1000 };
            int[] kValues = { 3, 5, 7 }; // Farklı k değerleri

            foreach (int size in sizeArray)
            {
                int[] arr = RandomArrayHelper.GenerateRandomArray(size);

                foreach (int kValue in kValues)
                {
                    Console.WriteLine($"Array Length: {size}, k: {kValue}");

                    int operationCount = 0;
                    int result = TimeHelper.MeasureTime("FindKthSmallest_Sort (O(n log n))", () => KthSmallestFinder.FindKthSmallest_Sort((int[])arr.Clone(), kValue, ref operationCount));
                    Console.WriteLine($"Operation Count: {operationCount}");
                    operationCount = 0;
                    result = TimeHelper.MeasureTime("FindKthSmallest_Insertion (O(n*k))", () => KthSmallestFinder.FindKthSmallest_Insertion((int[])arr.Clone(), kValue, ref operationCount));
                    Console.WriteLine($"Operation Count: {operationCount}");

                    Console.WriteLine(new string('-', 50));
                }
            }
        }
    }
}
