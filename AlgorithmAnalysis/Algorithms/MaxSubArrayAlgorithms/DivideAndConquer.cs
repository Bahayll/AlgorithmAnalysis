using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.Algorithms.MaxSubArrayAlgorithms
{
    public class DivideAndConquer
    {
        public static int FindMaxSubArray(int[] arr)
        {
            return MaxSum(arr, 0, arr.Length - 1);
        }

        private static int MaxSum(int[] arr, int left, int right)
        {
            if (left == right)
                return arr[left]; 

            int mid = (left + right) / 2;

     
            int leftMax = MaxSum(arr, left, mid);
            int rightMax = MaxSum(arr, mid + 1, right);
            int crossMax = MaxCrossingSum(arr, left, mid, right);


            return Math.Max(leftMax, Math.Max(rightMax, crossMax));
        }

        private static int MaxCrossingSum(int[] arr, int left, int mid, int right)
        {
            int sum = 0;
            int leftSum = int.MinValue;

   
            for (int i = mid; i >= left; i--)
            {
                sum += arr[i];
                leftSum = Math.Max(leftSum, sum);
            }

            sum = 0;
            int rightSum = int.MinValue;


            for (int i = mid + 1; i <= right; i++)
            {
                sum += arr[i];
                rightSum = Math.Max(rightSum, sum);
            }

            return leftSum + rightSum; 
        }
    }
}
