﻿using AlgorithmAnalysis.Algorithms.MaxSubArrayAlgorithms;
using AlgorithmAnalysis.Helpers;
using System.Diagnostics;

namespace AlgorithmAnalysis.Tester
{
    public class MaxSubArrayTester
    {
        public static void TestMaxSubArrayAlgorithms()
        {
            int[] sizes = { 100, 500, 1000, 5000 };
            Random rand = new Random();

            foreach (int size in sizes)
            {
                int[] arr = RandomArrayHelper.GenerateRandomArray(size, -100, 100);

                Console.WriteLine($"Array Size: {size}");

 
                MeasureTime("Brute Force O(n³)", () => BruteForce.FirstBruteForce(arr), size <= 500);

    
                MeasureTime("Brute Force O(n²)", () => BruteForce.SecondBruteForce(arr), size <= 1000);

                MeasureTime("Divide and Conquer O(n log n)", () => DivideAndConquer.FindMaxSubArray(arr), true);

                MeasureTime("Kadane's Algorithm O(n)", () => Kadane.FindMaxSubArray(arr), true);

                Console.WriteLine(new string('-', 50));
            }
        }

        private static void MeasureTime(string methodName, Func<int> method, bool run)
        {
            if (!run)
            {
                Console.WriteLine($"{methodName}: (Skip - Big Data Set)");
                return;
            }

            Stopwatch sw = Stopwatch.StartNew();
            int result = method();
            sw.Stop();

            Console.WriteLine($"{methodName}: Result {result}, Duration: {sw.ElapsedMilliseconds} ms");
        }
    }
}
