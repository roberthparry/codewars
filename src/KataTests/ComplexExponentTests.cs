namespace KataTests
{
    using NUnit.Framework;
    using System;
    using Kata;

    [TestFixture]
    public class ComplexExponentTests
    {
        protected static void AssertComplexEquals(double[] expected, double[] actual)
        {
            if (Math.Abs(expected[0]) <= 1)
            {
                Assert.That(actual[0], Is.EqualTo(expected[0]).Within(1e-12), "The real part of your returned complex number is not sufficiently close to the expected value");
            }
            else
            {
                Assert.That(actual[0], Is.EqualTo(expected[0]).Within(1e-10).Percent, "The real part of your returned complex number is not sufficiently close to the expected value");
            }
            if (Math.Abs(expected[1]) <= 1)
            {
                Assert.That(actual[1], Is.EqualTo(expected[1]).Within(1e-12), "The imaginary part of your returned complex number is not sufficiently close to the expected value");
            }
            else
            {
                Assert.That(actual[1], Is.EqualTo(expected[1]).Within(1e-10).Percent, "The imaginary part of your returned complex number is not sufficiently close to the expected value");
            }
        }
        [Test]
        public void FixedTests()
        {
            AssertComplexEquals(new double[] { 20.085536923187668, 0 }, ComplexExponent.Exp(new double[] { 3, 0 }));
            AssertComplexEquals(new double[] { -1, 0 }, ComplexExponent.Exp(new double[] { 0, Math.PI }));
            AssertComplexEquals(new double[] { -1, 0 }, ComplexExponent.Exp(new double[] { 0, 3 * Math.PI }));
        }
    }
}