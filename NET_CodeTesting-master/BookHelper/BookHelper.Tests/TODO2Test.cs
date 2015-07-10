using NUnit.Framework;

namespace BookHelper.Tests
{
    [TestFixture]
    public  class TODO2Test
    {
        [Test]
        public void HowMushPagesLeft_When_overlap_few_page_Then_should_be_right_page_say()
        {
            // Arrange
            var book = new Book(10);
            book.AddRange(3, 7);
            book.AddRange(7, 9);

            // Act
            var leftPages = book.HowManyPagesLeft();

            // Assert
            Assert.AreEqual(1,leftPages);
        }
    }
}
