using System;
using NUnit.Framework;

[TestFixture]
public static class ThirteenTests
{

    private static void testing(long actual, long expected)
    {
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public static void test1()
    {
        Console.WriteLine("Testing Thirt");
        testing(Thirteen.Thirt(8529), 79);
        testing(Thirteen.Thirt(85299258), 31);
        testing(Thirteen.Thirt(5634), 57);
        testing(Thirteen.Thirt(1111111111), 71);
        testing(Thirteen.Thirt(987654321), 30);
    }
}
