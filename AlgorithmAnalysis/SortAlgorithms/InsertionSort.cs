using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.SortAlgorithms
{
    public class InsertionSort
    {
        public static int[] SortAscending(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;

                }
                arr[j + 1] = key;
            }
            Console.WriteLine("Small to Large Sequential Series: " + string.Join(", ", arr));
            return arr; 
        }
        public static int[] SortDescending(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] < key)
                {
                    arr[j + 1] = arr[j];
                    j--;

                }
                arr[j + 1] = key;
            }
            Console.WriteLine("Large to Smaller Sequential Series: " + string.Join(", ", arr));
            return arr; 
        }

        public static int[] OptimizedSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int insertIndex = i;
                int currentValue = arr[i];

                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > currentValue)
                    {
                        arr[j + 1] = arr[j];
                        insertIndex = j;
                    }
                    else
                    {
                        break;
                    }
                }
                arr[insertIndex] = currentValue;
            }

            return arr;
        }
    }
}
