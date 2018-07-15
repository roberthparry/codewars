class Kata
{
    public static string Solve(string s)
    {
        int uppers = 0, lowers = 0;
        foreach (char ch in s)
        {
            if (char.IsUpper(ch))
                uppers++;
            else if (char.IsLower(ch))
                lowers++;
        }
        return (uppers > lowers) ? s.ToUpper() : s.ToLower();
    }
}