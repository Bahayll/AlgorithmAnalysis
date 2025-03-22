using AlgorithmAnalysis.ArrayListOperations;
using AlgorithmAnalysis.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.Tester
{
    public class ArrayListOperationsTester
    {
        public static void TestArrayListAdd()
        {
            var arrayList = new ArrayListOperation();
            Console.WriteLine("\n=== Add Operation Test ===");

            TimeHelper.MeasureTime("Add 4 elements", () =>
            {
                arrayList.Add(10);
                arrayList.Add(20);
                arrayList.Add(30);
                arrayList.Add(40);
                return 0;
            });

            Console.WriteLine("Array after adding 4 elements:");
            PrintArrayList.Print(arrayList.GetArray());


            TimeHelper.MeasureTime("Add (Resize Trigger)", () =>
            {
                arrayList.Add(50);
                return 0;
            });

            Console.WriteLine("Array after adding 1 more element:");
            PrintArrayList.Print(arrayList.GetArray());

            Console.WriteLine($"Size: {arrayList.Size}, Capacity: {arrayList.Capacity}");
        }

        public static void TestArrayListRemove()
        {
            var arrayList = new ArrayListOperation();
            Console.WriteLine("\n=== Remove Operation Test ===");

            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);
            arrayList.Add(40);

            Console.WriteLine("Before removing an element:");
            PrintArrayList.Print(arrayList.GetArray());

            TimeHelper.MeasureTime("RemoveAt(2)", () =>
            {
                arrayList.RemoveAt(2);
                return 0;
            });

            Console.WriteLine("After removing index 2:");
            PrintArrayList.Print(arrayList.GetArray());
        }

        public static void TestArrayListSearch()
        {
            var arrayList = new ArrayListOperation();
            Console.WriteLine("\n=== Search Operation Test ===");

            arrayList.Add(5);
            arrayList.Add(15);
            arrayList.Add(25);
            arrayList.Add(35);

            Console.WriteLine("Array:");
            PrintArrayList.Print(arrayList.GetArray());

            TimeHelper.MeasureTime("Search 25", () => arrayList.Search(25));
            TimeHelper.MeasureTime("Search 100", () => arrayList.Search(100));
        }

        public static void TestArrayListUpdate()
        {
            var arrayList = new ArrayListOperation();
            Console.WriteLine("\n=== Update Operation Test ===");

            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);

            Console.WriteLine("Before update:");
            PrintArrayList.Print(arrayList.GetArray());

            TimeHelper.MeasureTime("Update(1, 99)", () =>
            {
                arrayList.Update(1, 99);
                return 0;
            });

            Console.WriteLine("After updating index 1:");
            PrintArrayList.Print(arrayList.GetArray());
        }

        public static void TestLargeScaleOperations(int testSize)
        {
            var arrayList = new ArrayListOperation();

            Console.WriteLine($"=== Performance Test for {testSize} Elements ===");

            // 1️⃣ **Ekleme Testi**
            TimeHelper.MeasureTime($"Add {testSize} elements", () =>
            {
                for (int i = 0; i < testSize; i++)
                {
                    arrayList.Add(i);
                }
                return 0;
            });

            Console.WriteLine($"Final Size: {arrayList.Size}, Final Capacity: {arrayList.Capacity}");

            TimeHelper.MeasureTime("Search First Element", () => arrayList.Search(0));
            TimeHelper.MeasureTime("Search Middle Element", () => arrayList.Search(testSize / 2));
            TimeHelper.MeasureTime("Search Last Element", () => arrayList.Search(testSize - 1));

            TimeHelper.MeasureTime("Remove First Element", () =>
            {
                arrayList.RemoveAt(0);
                return 0;
            });

            TimeHelper.MeasureTime("Remove Middle Element", () =>
            {
                arrayList.RemoveAt(testSize / 2);
                return 0;
            });

            TimeHelper.MeasureTime("Remove Last Element", () =>
            {
                arrayList.RemoveAt(arrayList.Size - 1);
                return 0;
            });

            TimeHelper.MeasureTime("Update First Element", () =>
            {
                arrayList.Update(0, 999);
                return 0;
            });

            TimeHelper.MeasureTime("Update Middle Element", () =>
            {
                arrayList.Update(testSize / 2, 999);
                return 0;
            });

            TimeHelper.MeasureTime("Update Last Element", () =>
            {
                arrayList.Update(arrayList.Size - 1, 999);
                return 0;
            });

            Console.WriteLine("\n=== Test Completed ===\n");
        }

    }
}
