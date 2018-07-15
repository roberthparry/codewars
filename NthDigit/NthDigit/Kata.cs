
public class Kata
{
    public static int FindDigit(int num, int nth)
    {
        if (nth <= 0) return -1;
        if (num < 0) num = -num;
        int denominator = 1;
        for (int i = 1; i < nth; i++) denominator *= 10;
        return (num / denominator) % 10;
    }
}