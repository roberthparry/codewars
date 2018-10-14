using System.Text;

namespace Kata
{
    public class ConvertToCamelCase
    {
        public static string ToCamelCase(string str)
        {
            if (string.IsNullOrEmpty(str)) return str;
            string[] words = str.Split('-', '_');
            var builder = new StringBuilder($"{words[0][0]}{words[0].Substring(1).ToLower()}");
            for (int i = 1; i < words.Length; i++)
                builder.Append($"{char.ToUpper(words[i][0])}{words[i].Substring(1).ToLower()}");
            return builder.ToString();
        }
    }
}
