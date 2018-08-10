using BookStore.Domain.Books.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace BookStore.Domain.Tests
{
    [TestClass]
    public class BookTests
    {
        private readonly string _title = "Book title";
        private readonly string _author = "Author";
        private readonly string _edition = "Edition";
        private readonly string _publisher = "Publisher";
        private readonly string _isbn = "8521312369";
        private readonly int _quantity = 2;
        private readonly decimal _price = 100;        

        [TestMethod]   
        public void GivenAnInvalidTitleShouldReturnANotification()
        {
            var book = new Book(string.Empty, _author, _edition, _publisher, _isbn, _quantity, _price);
            var error = book.Notifications.Any(x => x.Property == "Title");
            Assert.IsTrue(error);
        }

        [TestMethod]
        public void GivenAnInvalidAuthorShouldReturnANotification()
        {
            var book = new Book(_title, string.Empty, _edition, _publisher, _isbn, _quantity, _price);
            var error = book.Notifications.Any(x => x.Property == "Author");
            Assert.IsTrue(error);
        }

        [TestMethod]
        public void GivenAnInvalidEditionShouldReturnANotification()
        {
            var book = new Book(_title, _author, string.Empty, _publisher, _isbn, _quantity, _price);
            var error = book.Notifications.Any(x => x.Property == "Edition");
            Assert.IsTrue(error);
        }

        [TestMethod]
        public void GivenAnInvalidPublisherShouldReturnANotification()
        {
            var book = new Book(_title, _author, _edition, string.Empty, _isbn, _quantity, _price);
            var error = book.Notifications.Any(x => x.Property == "Publisher");
            Assert.IsTrue(error);
        }

        [TestMethod]
        public void GivenAnInvalidIsbnShouldReturnANotification()
        {
            var book = new Book(_title, _author, _edition, _publisher, string.Empty, _quantity, _price);
            var error = book.Notifications.Any(x => x.Property == "Isbn");
            Assert.IsTrue(error);
        }

        [TestMethod]
        public void GivenAnInvalidQuantityShouldReturnANotification()
        {
            var book = new Book(_title, _author, _edition, _publisher, _isbn, -1, _price);
            var error = book.Notifications.Any(x => x.Property == "Quantity");
            Assert.IsTrue(error);
        }

        [TestMethod]
        public void GivenAnInvalidPriceShouldReturnANotification()
        {
            var book = new Book(_title, _author, _edition, _publisher, _isbn, _quantity, 0);
            var error = book.Notifications.Any(x => x.Property == "Price");
            Assert.IsTrue(error);
        }
    }
}
