namespace Kata
{
    public class ReverseNumbers
    {
        public int ReverseNumber(int n)
        {
            int Reverse(int m, int rev) => (m == 0) ? rev : Reverse(m / 10, rev * 10 + m % 10);
            return Reverse(n, 0);
        }
    }
}
