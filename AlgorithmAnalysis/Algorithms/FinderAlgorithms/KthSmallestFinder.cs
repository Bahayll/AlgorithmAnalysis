using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.Algorithms.FinderAlgorithms
{
    public class KthSmallestFinder
    {
        public static int FindKthSmallest_Sort(int[] arr, int k)
        {
            int[] temp = (int[])arr.Clone();
            Array.Sort(temp);
            return temp[k - 1];
        }

        public static int FindKthSmallest_Insertion(int[] arr, int k)
        {
            int[] kSmallest = new int[k];
            Array.Copy(arr, kSmallest, k);
            Array.Sort(kSmallest);

            for (int i = k; i < arr.Length; i++)
            {
                int newValue = arr[i];
                if (newValue < kSmallest[k - 1])
                {
                    int j = k - 2;

                    while (j >= 0 && kSmallest[j] > newValue)
                    {
                        kSmallest[j + 1] = kSmallest[j];
                        j--;
                    }
                    kSmallest[j + 1] = newValue;
                }
            }
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine(string.Join(", ", kSmallest));
            return kSmallest[k - 1];
        }
    }
}
