using System;

namespace Kata
{
    public class Complex
    {
        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public int Real { get; private set; }
        public int Imaginary { get; private set; }

        public static Complex operator+(Complex z, Complex w)
        {
            return new Complex(z.Real + w.Real, z.Imaginary + w.Imaginary);
        }
        public static Complex operator*(Complex z, Complex w)
        {
            return new Complex(z.Real * w.Real - z.Imaginary*w.Imaginary, z.Real*w.Imaginary + z.Imaginary*w.Real);
        }
        public override string ToString()
        {
            return $"Complex({Real}, {Imaginary})";
        }
        public override bool Equals(object obj)
        {
            if (obj is Complex)
            {
                var w = (Complex)obj;
                return (w.Real == Real) && (w.Imaginary == Imaginary);
            }
            return false;
        }

        public override int GetHashCode()
        {
            var hashCode = -837395861;
            hashCode = hashCode * -1521134295 + Real.GetHashCode();
            hashCode = hashCode * -1521134295 + Imaginary.GetHashCode();
            return hashCode;
        }
    }
}
