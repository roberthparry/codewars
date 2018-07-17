namespace Kata
{
    public static class StringRepeat
    {
        public static string repeatStr(int n, string s) => n == 0 ? "" : $"{repeatStr(n - 1, s)}{s}";
    }
}