using System.Text;

namespace Kata
{
	public class AddingBigNumbers
    {
        public static string Add(string a, string b)
        {
            StringBuilder res = new StringBuilder();

            int carry = 0;
            int maxLen = (a.Length > b.Length) ? a.Length : b.Length;

            int i = a.Length - 1;
            int j = b.Length - 1;

            for (int k = 0; k < maxLen; k++, i--, j--)
            {
                int addend = carry;
                if (i >= 0) addend += a[i] - '0';
                if (j >= 0) addend += b[j] - '0';
                carry = addend / 10;
                addend = addend % 10;
                res.Insert(0, addend);
            }

            if (carry != 0) res.Insert(0, carry);

            return res.ToString();
        }
    }	
}
