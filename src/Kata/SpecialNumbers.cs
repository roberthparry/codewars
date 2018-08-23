namespace Kata
{
	class SpecialNumbers
    {
        public static string SpecialNumber(int number)
        {
            return IsSpecialNumber(number) ? "Special!!" : "NOT!!";
        }

        private static bool IsSpecialNumber(int number)
        {
            if (0 <= number && number < 10) return number < 6;
            return IsSpecialNumber(number / 10) && IsSpecialNumber(number % 10);
        }
    }	
}
