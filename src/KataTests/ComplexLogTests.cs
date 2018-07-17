using System;
using NUnit.Framework;

using Kata;

namespace KataTests
{
    [TestFixture]
    public class LogTest
    {
        private static void AssertComplexEquals(double[] expected, double[] actual)
        {
            Assert.That(actual[0],
                Math.Abs(expected[0]) <= 1
                    ? Is.EqualTo(expected[0]).Within(1e-12)
                    : Is.EqualTo(expected[0]).Within(1e-10).Percent,
                "The real part of your returned complex number is not sufficiently close to the expected value");
            Assert.That(actual[1],
                Math.Abs(expected[1]) <= 1
                    ? Is.EqualTo(expected[1]).Within(1e-12)
                    : Is.EqualTo(expected[1]).Within(1e-10).Percent,
                "The imaginary part of your returned complex number is not sufficiently close to the expected value");
        }
        [Test]
        public void ExampleTests()
        {
            AssertComplexEquals(new double[] { 2.995732273553991, 0 }, ComplexLog.Log(new double[] { 20, 0 }));
            AssertComplexEquals(new double[] { 0, 3.141592653589793 }, ComplexLog.Log(new double[] { -1, 0 }));
            AssertComplexEquals(new double[] { 0.346573590279973, 0.785398163397448 }, ComplexLog.Log(new double[] { 1, 1 }));
            Assert.Throws<ArgumentException>(delegate { ComplexLog.Log(new double[] { 0, 0 }); });
        }
    }
}