using AlgorithmAnalysis.Algorithms.SortAlgorithms;
using AlgorithmAnalysis.Helpers;
using System.Diagnostics;


namespace AlgorithmAnalysis.Tester
{
    public class SortingAlgorithmTester
    {
            public static void TestSortAlgorithms()
            {
                int[] sizes = { 100, 500, 1000, 5000 };

                foreach (int size in sizes)
                {
                    int[] arr = RandomArrayHelper.GenerateRandomArray(size, -100, 100);
                    int operationCount = 0;

                    Console.WriteLine($"Array Size: {size}");
                    operationCount = 0;
                    TimeHelper.MeasureTime("Bubble Sort (O(n²))", () => BubleSort.Sort((int[])arr.Clone(), ref operationCount));
                    Console.WriteLine($"Bubble Sort Operation Count: {operationCount}");

                    operationCount = 0;
                    TimeHelper.MeasureTime("Optimized Bubble Sort (O(n²))", () => BubleSort.OptimizedSort((int[])arr.Clone(), ref operationCount));
                    Console.WriteLine($"Optimized Bubble Sort Operation Count: {operationCount}");

                    operationCount = 0;
                    TimeHelper.MeasureTime("Insertion Sort (O(n²))", () => InsertionSort.SortAscending((int[])arr.Clone(), ref operationCount));
                    Console.WriteLine($"Insertion Sort Operation Count: {operationCount}");
                    operationCount = 0;
                    TimeHelper.MeasureTime("Optimized Insertion Sort (O(n²))", () => InsertionSort.OptimizedSort((int[])arr.Clone(), ref operationCount));
                    Console.WriteLine($"Insertion Sort Operation Count: {operationCount}");

                    Console.WriteLine(new string('-', 50));
                }
            
        }
    }
}
