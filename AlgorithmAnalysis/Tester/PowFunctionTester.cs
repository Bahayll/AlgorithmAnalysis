using AlgorithmAnalysis.Algorithms.PowFuncitonAlgorithms;
using AlgorithmAnalysis.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.Tester
{
    public class PowFunctionTester
    {
        public static void TestPowAlgorithms()
        {
            int baseNumber = 2;
            int[] exponents = { 10, 15 ,20, 25 };

            Console.WriteLine("Testing Power Function Algorithms:\n");

            foreach (int exponent in exponents)
            {
                Console.WriteLine($"Exponent: {exponent}");

                int iterOps;
                iterOps = TimeHelper.MeasureTime("Iterative O(n)", () => PowFunction.Iterative(baseNumber, exponent, out iterOps));
                Console.WriteLine($"Operations (Iterative): {iterOps}");

                int recOps = 0;
                TimeHelper.MeasureTime("Recursive O(log n)", () => PowFunction.Recursive(baseNumber, exponent, ref recOps));
                Console.WriteLine($"Operations (Recursive): {recOps}");

                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
