namespace Complex
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void RealPart()
        {
            var zero = new Complex(0, 0);
            var one = new Complex(1, 0);
            var i = new Complex(0, 1);
            var w = new Complex(3, 4);

            Assert.AreEqual(0, zero.Real);
            Assert.AreEqual(1, one.Real);
            Assert.AreEqual(0, i.Real);
            Assert.AreEqual(3, w.Real);
        }

        [Test]
        public void ImaginaryPart()
        {
            var zero = new Complex(0, 0);
            var one = new Complex(1, 0);
            var i = new Complex(0, 1);
            var w = new Complex(3, 4);

            Assert.AreEqual(0, zero.Imaginary);
            Assert.AreEqual(0, one.Imaginary);
            Assert.AreEqual(1, i.Imaginary);
            Assert.AreEqual(4, w.Imaginary);
        }

        [Test]
        public void ComplexAddition()
        {
            var zero = new Complex(0, 0);
            var one = new Complex(1, 0);
            var i = new Complex(0, 1);
            var v = new Complex(2, 4);
            var w = new Complex(3, 1);

            Assert.AreEqual(one, zero + one);
            Assert.AreEqual(i, i + zero);
            Assert.AreEqual(new Complex(1, 1), one + i);
            Assert.AreEqual(new Complex(5, 5), v + w);
        }

        [Test]
        public void ComplexMultiplication()
        {
            var zero = new Complex(0, 0);
            var one = new Complex(1, 0);
            var i = new Complex(0, 1);
            var v = new Complex(2, 4);
            var w = new Complex(3, 1);

            Assert.AreEqual(zero, zero * one);
            Assert.AreEqual(i, i * one);
            Assert.AreEqual(new Complex(2, 14), v * w);
        }
    }
}