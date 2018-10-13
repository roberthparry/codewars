namespace Kata
{
    public class MyJinxin
    {
        public string ReverseLetter(string str)
        {
            string Letter(char ch) => char.IsLetter(ch) ? $"{ch}" : "";
            return string.IsNullOrEmpty(str) ? str : $"{ReverseLetter(str.Substring(1))}{Letter(str[0])}";
        }
    }
}
