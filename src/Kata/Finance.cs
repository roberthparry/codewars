using System;

namespace Kata
{
	class Finance
    {
        public static string Amort(double rate, int bal, int term, int num_payments)
        {
            double i = 0.01 * rate / 12.0;
            double g = 1.0 + i;
            double c = (double)bal * i / (1.0 - Math.Pow(g, -(double)term));
            double gn = Math.Pow(g, (double)num_payments);
            double balance = bal * gn - c * (gn - 1.0) / i;
            double prevBalance = bal;
            if (num_payments > 1)
            {
                double gn_1 = gn / g;
                prevBalance = bal * gn_1 - c * (gn_1 - 1.0) / i;
            }
            double interest = i * prevBalance;
            double princ = c - interest;
            return $"num_payment {num_payments} c {c:#} princ {princ:#} int {interest:#} balance {balance:#}";
        }
    }	
}
