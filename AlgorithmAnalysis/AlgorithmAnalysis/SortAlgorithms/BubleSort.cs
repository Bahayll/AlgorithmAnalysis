namespace AlgorithmAnalysis.SortAlgorithms
{
    public class BubleSort
    {
        public static int operationCount;

        public static int[] Sort(int[] array)
        {
            operationCount = 0;
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    operationCount++;
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine($"Classic Bubble Sort - Operations: {operationCount}, Big-O: O(n²)");
            return array;
        }

        // If the algorithm is Sequential, it finishes in one cycle.
        public static int[] OptimizedSort(int[] array)
        {
            operationCount = 0;
            int n = array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    operationCount++;
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }

                // If no swaps were made, break the loop
                if (!swapped)
                    break;
            }

            Console.WriteLine($"Optimized Bubble Sort - Operations: {operationCount}, Big-O: O(n²) best case O(n)");
            return array;
        }
    }
}
