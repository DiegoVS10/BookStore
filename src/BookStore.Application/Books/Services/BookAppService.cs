using System;
using System.Collections.Generic;
using BookStore.Application.Books.Services.Interfaces;
using BookStore.Domain.Books.Entities;
using BookStore.Domain.Books.Interfaces.Services;

namespace BookStore.Application.Books.Services
{
    public class BookAppService : IBookAppService
    {
        private readonly IBookService _bookService;

        public BookAppService(IBookService bookService)
        {
            _bookService = bookService;
        }

        public void Add(Book book)
        {
            _bookService.Add(book);
        }

        public void Delete(Guid id)
        {
            _bookService.Delete(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookService.GetAll();
        }

        public Book GetById(Guid id)
        {
            return _bookService.GetById(id);
        }

        public void Update(Book book)
        {
            _bookService.Update(book);
        }
    }
}
