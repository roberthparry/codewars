﻿using Kata;

namespace KataTests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class AverageSolutionTests
    {
        [Test]
        public void ExampleTest()
        {
            double[] array = new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };
            Assert.AreEqual(200.0 / 13.0, AverageSolution.FindAverage(array));

            // Should return 0 on empty array
            Assert.AreEqual(0, AverageSolution.FindAverage(new double[] { }));
        }
    }
}