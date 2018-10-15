namespace Kata
{
	class SpecialNumbers
    {
        public static string SpecialNumber(int number) => IsSpecialNumber(number) ? "Special!!" : "NOT!!";

        private static bool IsSpecialNumber(int number)
            => 0 <= number && number < 10 ? number < 6 : IsSpecialNumber(number / 10) && IsSpecialNumber(number % 10);
    }	
}
