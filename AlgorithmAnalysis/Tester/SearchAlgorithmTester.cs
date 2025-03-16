
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

                Console.WriteLine($"Dizi Boyutu: {size}");

                // Linear Search Test
                Stopwatch sw = Stopwatch.StartNew();
                int operationCount;
                int linearIndex = LinearSearch.Search(arr, target, out operationCount);
                sw.Stop();
                Console.WriteLine($"Linear Search: Sonuç {linearIndex}, Süre: {sw.ElapsedMilliseconds} ms, Adım Sayısı: {operationCount}");

                // Binary Search Test
                sw.Restart();
                int binaryIndex = BinarySearch.Search(arr, target, out operationCount);
                sw.Stop();
                Console.WriteLine($"Binary Search: Sonuç {binaryIndex}, Süre: {sw.ElapsedMilliseconds} ms, Adım Sayısı: {operationCount}");

                // Min-Max Test
                sw.Restart();
                int min = MinMaxFinder.Min(arr, out int minOperations);
                int max = MinMaxFinder.Max(arr, out int maxOperations);
                sw.Stop();
                Console.WriteLine($"Min: {min}, Max: {max}, Süre: {sw.ElapsedMilliseconds} ms, Min Adım Sayısı: {minOperations}, Max Adım Sayısı: {maxOperations}");

                Console.WriteLine(new string('-', 50));
            }
        }
       


    }
}
