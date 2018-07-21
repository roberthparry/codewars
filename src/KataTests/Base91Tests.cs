using NUnit.Framework;
using Kata;

namespace KataTests
{
    [TestFixture]
    public class Base91Tests
    {
        [TestCase("test", "fPNKd")]
        [TestCase("Hello World!", ">OwJh>Io0Tv!8PE")]
        public void EncodeTests(string input, string expected)
        {
            Assert.AreEqual(Base91.Encode(input), expected);
        }

        [TestCase("fPNKd", "test")]
        [TestCase(">OwJh>Io0Tv!8PE", "Hello World!")]
        public void DecodeTests(string input, string expected)
        {
            Assert.AreEqual(Base91.Decode(input), expected);
        }
    } 
}
