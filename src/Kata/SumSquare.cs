using System.Linq;

namespace Kata
{
    public static class SumSquare
    {
        public static int SquareSum(int[] n)
        {
            return n.Sum(m => m * m);
        }
    }  
}

