using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(89.9);
            book.AddGrade(91.9);
            book.AddGrade(79.9);

            //act
            var result = book.GetStatistics();
            //assert
            Assert.Equal(87.2, result.Average, 1);
            Assert.Equal(91.9, result.High, 1);
            Assert.Equal(79.9, result.Low, 1);
        }
    }
}
