
using NUnit.Framework;
using System;

namespace BookHelper.Tests
{
    [TestFixture]
    public class Pages
    {
        private int from;
        private int to;

        public Pages(int from, int to)
        {
            this.from = from;
            this.to = to;
        }

        [Test]
        [TestCase(0, 12)]
        [TestCase(2, 25)]
        [ExpectedException(typeof(ArgumentException))]
        public void Ctr_When_pages_passed_Then_throws_exception(int from, int to)
        {
            // Act
            new Pages(from, to);
        }
    }
}
