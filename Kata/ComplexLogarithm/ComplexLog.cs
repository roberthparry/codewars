using System;

namespace ComplexLogarithm
{
    public static class Complex
    {
        public static double[] Log(double[] z)
        {
            var x = z[0];
            var y = z[1];
            if (Math.Abs(x) < 1.0e-12 && Math.Abs(y) < 1.0e-12) throw new ArgumentException();
            var mag = Math.Sqrt(x * x + y * y);
            var arg = Math.Atan2(y, x);
            return new double[] { Math.Log(mag), arg };
        }
    }
}