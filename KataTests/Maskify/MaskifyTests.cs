using NUnit.Framework;

[TestFixture]
public class MaskifyTests
{
    [Test]
    public void ExamplesTests()
    {
        Assert.AreEqual("############5616", MaskifySolution.Maskify("4556364607935616"));
        Assert.AreEqual("1", MaskifySolution.Maskify("1"));
        Assert.AreEqual("#1111", MaskifySolution.Maskify("11111"));
    }
}