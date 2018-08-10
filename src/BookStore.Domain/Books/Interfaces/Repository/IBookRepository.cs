using BookStore.Domain.Books.Entities;
using System;
using System.Collections.Generic;

namespace BookStore.Domain.Books.Interfaces.Repository
{
    public interface IBookRepository : IDisposable
    {
        IEnumerable<Book> GetAll();
        Book GetById(Guid id);
        void Add(Book book);
        void Update(Book book);
        void Delete(Guid id);
         
    }
}
