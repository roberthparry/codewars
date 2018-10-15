namespace Kata
{
    public static class StringRepeat
    {
        public static string RepeatStr(int n, string s) => n == 0 ? "" : $"{RepeatStr(n - 1, s)}{s}";
    }
}