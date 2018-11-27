namespace Kata
{
    public static class MeanSquareError
    {
        public static double Solution(int[] firstArray, int[] secondArray)
        {
            double total = 0.0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                double d = firstArray[i] - secondArray[i];
                total += d * d;
            }
            return total / firstArray.Length;
        }
    }
}
