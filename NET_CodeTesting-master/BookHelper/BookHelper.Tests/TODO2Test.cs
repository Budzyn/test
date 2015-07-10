using NUnit.Framework;

namespace BookHelper.Tests
{
    [TestFixture]
    public  class TODO2Test
    {
        [Test]
        public void HowMushPagesLeft_When_given_few_ranges_Then_should_be_less_or_equal_pages()
        {
            // Arrange
            var book = new Book(10);
            book.AddRange(3, 4);
            book.AddRange(6, 8);

            // Act
            var leftPages = book.HowManyPagesLeft();

            // Assert
            Assert.AreEqual(7,14,leftPages);
        }
    }
}
