using System.Linq;

namespace Kata
{
    public static class AverageSolution
    {
        public static double FindAverage(double[] array) => array.Length == 0 ? 0 : array.Average();
    }
}

