using System;
using Xunit;

namespace GradeBook.Tests
{
    // access modifier, delegate keyword , return type then the name of the delegate
    public delegate string WriteLogDelegate(string logMessage); // declaring a delegate
    // delegates define how methods will look like.
    public class TypeTests
    {
        int count = 0;
        [Fact]
        public void WriteLogDelegateReturnMessage()
        {
            //initiate the delegate
            WriteLogDelegate logDelegate = ReturnMessage;

            // assign delegate
            logDelegate += ReturnMessage;
            logDelegate += IncrementCount;

            var result = logDelegate("Elsie");
            Assert.Equal(3, count);
        }
        string IncrementCount(string message)
        {
            count++;
            return message;
        }
        string ReturnMessage(string message)
        {
            count++;
            return message;
        }
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
