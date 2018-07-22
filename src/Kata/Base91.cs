using System.Collections.Generic;
using System.Linq;
using System.Text;


class Base91
{
    private static string EncodeTable = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!#$%&()*+,./:;<=>?@[]^_`{|}~";

    private static readonly Dictionary<byte, int> DecodeTable = EncodeTable
        .Select((v, i) => new { Key = (byte)v, Value = i })
        .ToDictionary(o => o.Key, o => o.Value);

    public static string Encode(string input)
    {
        StringBuilder builder = new StringBuilder();
        int b = 0, n = 0, v = 0;
        for (int i = 0; i < input.Length; i++)
        {
            b |= (byte)input[i] << n;
            n += 8;
            if (n > 13)
            {
                v = b & 8191;
                if (v > 88)
                {
                    b >>= 13;
                    n -= 13;
                }
                else
                {
                    v = b & 16383;
                    b >>= 14;
                    n -= 14;
                }
                builder.Append(EncodeTable[v % 91]);
				builder.Append(EncodeTable[v / 91]);
			}
		}

		if (n != 0)
        {
            builder.Append(EncodeTable[b % 91]);
            if (n > 7 || b > 90)
                builder.Append(EncodeTable[b / 91]);
        }
        return builder.ToString();
    }

    public static string Decode(string input)
    {
        StringBuilder builder = new StringBuilder();
        int c = 0;
        int v = -1;
        int b = 0;
        int n = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (!DecodeTable.TryGetValue((byte)input[i], out c))
                continue;

            if (v < 0)
            {
                v = c;
            }
            else
            {
                v += c * 91;
                b |= v << n;
                n += (v & 8191) > 88 ? 13 : 14;
                do
                {
                    builder.Append((char)(b & 0xFF));
                    b >>= 8;
                    n -= 8;
                } while (n > 7);
                v = -1;
            }
        }
        if (v + 1 != 0)
        {
            builder.Append((char)((b | v << n) & 0xFF));
        }
        return builder.ToString();
    }

}