using System.Linq;

public static class SumSquare
{
    public static int SquareSum(int[] n)
    {
		return n.Sum(m => m * m);
    }
}
