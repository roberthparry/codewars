namespace Kata
{
    public static class LatticePointsInCircle
    {
        public static int PointsInCircle(int radius)
        {
            int rr = radius * radius;
            int points = radius;
            for (int x = 1; x <= radius; x++)
            {
                int xx = x * x;
                for (int y = 1; y <= radius && xx + y * y <= rr; y++)
                    points++;
            }

            return points * 4 + 1;
        }
    }
}

