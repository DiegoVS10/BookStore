using BookStore.Domain.Books.Entities;
using BookStore.Domain.Books.Interfaces.Repository;
using BookStore.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Infra.Data.Books.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }

        public void Add(Book book)
        {
            _context.Books.Add(book);
        }

        public void Delete(Guid id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            _context.Books.Remove(book);
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books.OrderBy(x => x.Title);
        }

        public Book GetById(Guid id)
        {
            return _context.Books.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Book book)
        {
            _context.Books.Update(book);
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }

            GC.SuppressFinalize(this);
        }
    }
}
