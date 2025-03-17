using AlgorithmAnalysis.Algorithms.MaxSubArrayAlgorithms;
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
                int operationCount = 0;
                Console.WriteLine($"Array Size: {size}");
                if(size <= 500)
                {
                    
                    TimeHelper.MeasureTime("First Brute Force O(n³)", () => BruteForce.FirstBruteForce(arr, ref operationCount));
                    Console.WriteLine($"Operation Count: {operationCount}");
                }
                else
                {
                    Console.WriteLine("Brute Force O(n³): Skipped due to large input size(500)");
                    Console.WriteLine(new string('*', 50));
                }
                if (size <= 1000)
                {
                    operationCount = 0;
                    TimeHelper.MeasureTime("Secnd Brute Force O(n²)", () => BruteForce.SecondBruteForce(arr, ref operationCount));
                    Console.WriteLine($"Operation Count: {operationCount}");
                }
                else
                {
                    Console.WriteLine("Brute Force O(n²): Skipped due to large input size(1000)");
                    Console.WriteLine(new string('*', 50));
                }


                operationCount = 0;
                TimeHelper.MeasureTime("Divide and Conquer O(n log n)", () => DivideAndConquer.FindMaxSubArray(arr, ref operationCount));
                Console.WriteLine($"Operation Count: {operationCount}");
                operationCount = 0;
                TimeHelper.MeasureTime("Kadane's Algorithm O(n)", () => Kadane.FindMaxSubArray(arr, ref operationCount));
                Console.WriteLine($"Operation Count: {operationCount}");

                Console.WriteLine(new string('-', 50));
            }

        }
    }
}
