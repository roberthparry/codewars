using NUnit.Framework;
using System;

[TestFixture]
public class AdditiveTests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual("Green", AddColors.AdditiveColors("Green"));
    }

    [Test]
    public void Test2()
    {
        Assert.AreEqual("Yellow", AddColors.AdditiveColors("Red,Green"));
    }
}