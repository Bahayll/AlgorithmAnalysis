namespace AlgorithmAnalysis.Helpers
{
    public class RandomArrayHelper
    {
        public static int[] GenerateRandomArray(int length, int minValue = 1, int maxValue = 100)
        {
            Random rand = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(minValue, maxValue + 1);
            }

            return array;
        }
    }
}
