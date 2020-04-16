using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void IsPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Book");

            Assert.Equal("New Book", book1.Name);
        }
        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void IsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Book");

            Assert.Equal("Book 1", book1.Name);
        }
        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Book");

            Assert.Equal("New Book", book1.Name);
        }
        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnDifObj()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        [Fact]
        public void TwovarsReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(object.ReferenceEquals(book1, book2));
        }
        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
