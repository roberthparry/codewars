namespace Kata
{
    public class DigitalSum
    {
        public int DigitalRoot(long n) => (int)(1 + (n - 1) % 9);
    }
}
