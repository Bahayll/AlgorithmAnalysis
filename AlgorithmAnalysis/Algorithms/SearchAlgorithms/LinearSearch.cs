
namespace AlgorithmAnalysis.SearchAlgorithms
{
    public class LinearSearch 
    {
        public static int Search(int[] arr, int target, out int operationCount)
        {
            operationCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                operationCount++;
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }
    }
}
