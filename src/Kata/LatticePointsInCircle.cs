namespace Kata
{
    public static class LatticePointsInCircle
    {
        public static int PointsInCircle(int radius)
        {
            int r2 = radius * radius;
            int count = radius;
            for (int i = 1; i <= radius; i++)
            {
                int i2 = i * i;
                for (int j = 1; j <= radius; j++)
                {
                    if (i2 + j * j > r2) break;
                    count++;
                }
            }

            return count * 4 + 1;
        }
    }
}

