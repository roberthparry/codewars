namespace Kata
{
    public static class MaskifySolution
    {
        // return masked string
        public static string Maskify(string cc)
        {
            char[] masked = cc.ToCharArray();
            for (int i = 0; i < cc.Length - 4; i++) masked[i] = '#';
            return new string(masked);
        }
    }
}
