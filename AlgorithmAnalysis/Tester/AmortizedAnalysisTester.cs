using AlgorithmAnalysis.ArrayListOperations;
using AlgorithmAnalysis.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.Tester
{
    public class AmortizedAnalysisTester
    {
        public static void TestArrayOperation()
        {
            var arrayList = new ArrayListOperation();

            Console.WriteLine("Index\tTime (ms)\tCapacity");

            for (int i = 1; i <= arrayList.Size; i++)
            {
                TimeHelper.MeasureTime($"Add({i})", () => {
                    arrayList.Add(i);
                    return i;
                });

                if (arrayList.Size == arrayList.Capacity / 2) // Print when resizing occurs
                {
                    Console.WriteLine($"{i}\t{arrayList.Capacity}");
                }
            }

            Console.WriteLine($"Final Size: {arrayList.Size}");
            Console.WriteLine($"Final Capacity: {arrayList.Capacity}");
        }
    }
    }

