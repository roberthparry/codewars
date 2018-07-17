﻿using System;
using NUnit.Framework;

[TestFixture]
public class RomanDecodeTests
{
    [TestCase(1, "I")]
    public void Test(int expected, string roman)
    {
        Assert.AreEqual(expected, RomanDecode.Solution(roman));
    }
}

