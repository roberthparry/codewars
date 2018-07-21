using System;

namespace Kata
{
    public class ComplexExponent
    {
        public static double[] Exp(double[] z)
        {
            double x = z[0]; // Real part of z = x + iy
            double y = z[1]; // Imaginary part of z = x + iy
            double expX = Math.Exp(x);
            (double sinY, double cosY) = SinCos(y);

            return new double[] { expX * cosY, expX * sinY };
        }

        private static (double, double) SinCos(double angle)
        {
            double sin = Math.Sin(angle);
            double cos = IsSmall(sin) ? (1.0 - 0.5 * sin * sin) : Math.Sqrt(1.0 - sin * sin);
            int quadrant = GetAngleQuadrant(angle);
            if (1 < quadrant && quadrant < 4)
                cos = -cos;
            return (sin, cos);
        }

        private static int GetAngleQuadrant(double angle)
        {
            angle = angle % (2.0 * Math.PI);
            if (angle < 0.0) angle += 2.0 * Math.PI;
            return (int)Math.Floor(2.0 * angle / Math.PI) + 1;
        }

        private static bool IsSmall(double value)
        {
            return (-1.0e-3 < value && value < 1.0e-3);
        }
    }    
}
