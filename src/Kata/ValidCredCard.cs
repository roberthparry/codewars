using System;

namespace Kata
{
    public class ValidCredCard
    {
        public bool Validate(string n)
        {
            int sum = 0;
            bool doubleIt = false;
            for (int i = n.Length - 1; i >= 0; i--)
            {
                char ch = n[i];
                if (ch == ' ') continue;
                int digit = n[i] - '0';
                if (doubleIt)
                {
                    digit *= 2;
                    if (digit > 9) digit -= 9;
                }
                sum += digit;
                doubleIt = !doubleIt;
            }
            return (sum % 10) == 0;
        }
	}    
}
