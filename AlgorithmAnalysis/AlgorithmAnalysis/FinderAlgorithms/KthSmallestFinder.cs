using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.FinderAlgorithms
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
                if (arr[i] < kSmallest[k - 1])
                {
                    kSmallest[k - 1] = arr[i];

                    for (int j = k - 2; j >= 0 && kSmallest[j] > arr[i]; j--)
                    {
                        (kSmallest[j + 1], kSmallest[j]) = (kSmallest[j], kSmallest[j + 1]);
                    }
                }
            }
            return kSmallest[k - 1];
        }
    }
}
