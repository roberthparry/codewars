using System;
using NUnit.Framework;

[TestFixture]
public class ComparingTests
{
    [TestCase(-1, "-1<0")]
    [TestCase(0, "0=0")]
    [TestCase(3, "1+2+3=6")]
    [TestCase(10, "1+2+3+4+5+6+7+8+9+10=55")]
    public void SequenceTest(int n, string sequenceString)
    {
        Assert.AreEqual(sequenceString, SumSequence.SequenceString(n));
    }
}